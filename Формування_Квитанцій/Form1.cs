using OfficeOpenXml;
using System.Diagnostics;
using Xceed.Words.NET;

namespace Формування_Квитанцій
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Квитанції.BackColor = Color.DarkRed;
            textBoxНазва_Файла.Focus();

        }

        private void Квитанції_MouseClick(object sender, MouseEventArgs e)
        {
            Квитанції.BackColor = Color.Blue;
        }

        int col_PIP = 0;
        int col_Sum = 0;

        private void Квитанції_Click(object sender, EventArgs e)
        {
            Квитанції.BackColor = Color.Blue;
            if (textBoxНазва_Файла.Text != "" && textBoxНомер_колонки_ПІП.Text != "" && textBoxСума_Податку.Text != "")
            {
                if (int.TryParse(textBoxНомер_колонки_ПІП.Text, out col_PIP))
                { }
                else
                {
                    MessageBox.Show("Некоректне значення поля номер колонки ПІП");
                    return;
                }
                if (int.TryParse(textBoxСума_Податку.Text, out col_Sum))
                { }
                else
                {
                    MessageBox.Show("Некоректне значення поля номер колонки суми податку");
                    return;
                }

            }
            else
            {
                MessageBox.Show("Спочатку заповніть усі поля");
                return;
            }
            List<People> peoples = new List<People>();

            string filePath = textBoxНазва_Файла.Text;

            // Перевірка чи існує файл
            if (File.Exists(filePath))
            {
                ExcelPackage.LicenseContext = LicenseContext.NonCommercial;
                using (var package = new ExcelPackage(new FileInfo(filePath)))
                {
                    ExcelWorksheet worksheet = package.Workbook.Worksheets[0]; // Вибираємо перший лист у книзі Excel

                    int rowCount = worksheet.Dimension.Rows; // Отримуємо кількість рядків
                    int colCount = worksheet.Dimension.Columns; // Отримуємо кількість колонок

                    // Проходимо через кожну комірку та виводимо її значення
                    for (int row = 2; row <= rowCount; row++)
                    {

                        peoples.Add(new People(worksheet.Cells[row, col_PIP].Value.ToString(),
                        Convert.ToDouble(worksheet.Cells[row, col_Sum].Value)));

                    }
                }
            }
            else
            {
                Console.WriteLine("Файл не знайдено.");
            }

            // Заміна слова у всьому документі
            Dictionary<string, string> replacements = new Dictionary<string, string>();
            string nameNewFile = textBoxНазваНовогоФайлу.Text.ToString();
            //string statFile = textBoxФайлШаблон.Text.ToString();
            string date = textBoxДата.Text.ToString();

            // Визначення шляху до тимчасової папки
            string tempFolderPath = @"C:\Податки";
            string tempFilePath = Path.Combine(tempFolderPath, nameNewFile + ".docx");

            // Створення папки, якщо її немає
            if (!Directory.Exists(tempFolderPath))
            {
                Directory.CreateDirectory(tempFolderPath);
            }

            using (DocX mergedDoc = DocX.Create(tempFilePath))
            {

                for (int i = 0; i < peoples.Count; i++)
                {
                    DocX document = DocX.Load(@"DocTemplates\Шаблон.docx");
                    replacements.Add("ПІП", peoples[i].PIP);
                    replacements.Add("Сума", peoples[i].sum.ToString());
                    replacements.Add("Дата", date);

                    foreach (var replacement in replacements)
                    {
                        document.ReplaceText(replacement.Key, replacement.Value, false);
                    }
                    foreach (var paragraph in document.Paragraphs)
                    {
                       mergedDoc.InsertParagraph(paragraph);
                    }

                    replacements.Clear();
                }
                mergedDoc.MarginRight = 40;
                mergedDoc.MarginTop = 20;
                mergedDoc.Save();

                // Відкриваємо документ в Word для перегляду
                Process.Start(new ProcessStartInfo
                {
                    FileName = tempFilePath,
                    UseShellExecute = true
                });

            }

            MessageBox.Show("Файл " + nameNewFile + " збережено на диску С в папці - Податки");
        }

        private void ВибратиШлхДоФайлу_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "Excel Files|*.xlsx";
                openFileDialog.FilterIndex = 1;
                openFileDialog.RestoreDirectory = true;

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    // Встановлюємо шлях до обраного файлу в текстове поле
                    textBoxНазва_Файла.Text = openFileDialog.FileName;
                }
            }
        }

        private void Довідка_MouseHover(object sender, EventArgs e)
        {
            MessageBox.Show("На вашому пк на диску `D` має бути створена папка 'Податки' де має бути файл(.docx) " +
                "з назвою 'Шаблон' на якому розміщений шаблонний текст оголошення чи повідомлення з " +
                "ключовими словами для заміни програмою (це слова `ПІП` і `Cума` ). Програма їх замінить" +
                " на відповідні значення з вказаної вами таблиці .xlsx");
        }

    }
}