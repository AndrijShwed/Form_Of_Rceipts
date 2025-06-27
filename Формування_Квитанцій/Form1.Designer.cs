namespace Формування_Квитанцій
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            textBoxНомер_колонки_ПІП = new TextBox();
            label3 = new Label();
            textBoxСума_Податку = new TextBox();
            Квитанції = new Button();
            label2 = new Label();
            label4 = new Label();
            textBoxНазва_Файла = new TextBox();
            ВибратиШлхДоФайлу = new Button();
            label5 = new Label();
            textBoxНазваНовогоФайлу = new TextBox();
            Довідка = new Label();
            label7 = new Label();
            textBoxДата = new TextBox();
            label6 = new Label();
            comboBoxШаблони = new ComboBox();
            textBoxCount = new TextBox();
            textBoxPayKod = new TextBox();
            label8 = new Label();
            label9 = new Label();
            SuspendLayout();
            // 
            // textBoxНомер_колонки_ПІП
            // 
            textBoxНомер_колонки_ПІП.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            textBoxНомер_колонки_ПІП.Location = new Point(615, 145);
            textBoxНомер_колонки_ПІП.Name = "textBoxНомер_колонки_ПІП";
            textBoxНомер_колонки_ПІП.Size = new Size(125, 34);
            textBoxНомер_колонки_ПІП.TabIndex = 2;
            textBoxНомер_колонки_ПІП.KeyDown += textBoxНомер_колонки_ПІП_KeyDown;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Brown;
            label3.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = SystemColors.ButtonHighlight;
            label3.Location = new Point(12, 266);
            label3.Name = "label3";
            label3.Size = new Size(404, 28);
            label3.TabIndex = 3;
            label3.Text = "Введіть номер колонки з сумою податку";
            // 
            // textBoxСума_Податку
            // 
            textBoxСума_Податку.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            textBoxСума_Податку.Location = new Point(615, 263);
            textBoxСума_Податку.Name = "textBoxСума_Податку";
            textBoxСума_Податку.Size = new Size(125, 34);
            textBoxСума_Податку.TabIndex = 4;
            textBoxСума_Податку.KeyDown += textBoxСума_Податку_KeyDown;
            // 
            // Квитанції
            // 
            Квитанції.BackColor = Color.Red;
            Квитанції.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            Квитанції.ForeColor = SystemColors.ButtonHighlight;
            Квитанції.Location = new Point(218, 485);
            Квитанції.Name = "Квитанції";
            Квитанції.Size = new Size(186, 54);
            Квитанції.TabIndex = 5;
            Квитанції.Text = "Виконати";
            Квитанції.UseVisualStyleBackColor = false;
            Квитанції.Click += Квитанції_Click;
            Квитанції.MouseClick += Квитанції_MouseClick;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Brown;
            label2.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = SystemColors.ButtonHighlight;
            label2.Location = new Point(12, 148);
            label2.Name = "label2";
            label2.Size = new Size(295, 28);
            label2.TabIndex = 1;
            label2.Text = "Введіть номер колонки з ПІП";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Brown;
            label4.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = SystemColors.ButtonHighlight;
            label4.Location = new Point(12, 84);
            label4.Name = "label4";
            label4.Size = new Size(236, 28);
            label4.TabIndex = 6;
            label4.Text = "Виберіть таблицю Excel";
            // 
            // textBoxНазва_Файла
            // 
            textBoxНазва_Файла.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            textBoxНазва_Файла.Location = new Point(274, 81);
            textBoxНазва_Файла.Name = "textBoxНазва_Файла";
            textBoxНазва_Файла.Size = new Size(466, 34);
            textBoxНазва_Файла.TabIndex = 1;
            // 
            // ВибратиШлхДоФайлу
            // 
            ВибратиШлхДоФайлу.BackColor = Color.DarkRed;
            ВибратиШлхДоФайлу.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            ВибратиШлхДоФайлу.ForeColor = SystemColors.ButtonHighlight;
            ВибратиШлхДоФайлу.Location = new Point(768, 79);
            ВибратиШлхДоФайлу.Name = "ВибратиШлхДоФайлу";
            ВибратиШлхДоФайлу.Size = new Size(110, 36);
            ВибратиШлхДоФайлу.TabIndex = 11;
            ВибратиШлхДоФайлу.Text = "Вибрати";
            ВибратиШлхДоФайлу.UseVisualStyleBackColor = false;
            ВибратиШлхДоФайлу.Click += ВибратиШлхДоФайлу_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Brown;
            label5.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label5.ForeColor = SystemColors.ButtonHighlight;
            label5.Location = new Point(12, 387);
            label5.Name = "label5";
            label5.Size = new Size(278, 28);
            label5.TabIndex = 12;
            label5.Text = "Введіть назву нового файлу";
            // 
            // textBoxНазваНовогоФайлу
            // 
            textBoxНазваНовогоФайлу.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            textBoxНазваНовогоФайлу.Location = new Point(465, 381);
            textBoxНазваНовогоФайлу.Name = "textBoxНазваНовогоФайлу";
            textBoxНазваНовогоФайлу.Size = new Size(275, 34);
            textBoxНазваНовогоФайлу.TabIndex = 13;
            textBoxНазваНовогоФайлу.KeyDown += textBoxНазваНовогоФайлу_KeyDown;
            // 
            // Довідка
            // 
            Довідка.Location = new Point(0, 0);
            Довідка.Name = "Довідка";
            Довідка.Size = new Size(100, 23);
            Довідка.TabIndex = 28;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.Brown;
            label7.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label7.ForeColor = SystemColors.ButtonHighlight;
            label7.Location = new Point(12, 436);
            label7.Name = "label7";
            label7.Size = new Size(130, 28);
            label7.TabIndex = 18;
            label7.Text = "Введіть дату";
            // 
            // textBoxДата
            // 
            textBoxДата.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            textBoxДата.Location = new Point(465, 433);
            textBoxДата.Name = "textBoxДата";
            textBoxДата.Size = new Size(275, 34);
            textBoxДата.TabIndex = 19;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.Brown;
            label6.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label6.ForeColor = SystemColors.ButtonHighlight;
            label6.Location = new Point(12, 22);
            label6.Name = "label6";
            label6.Size = new Size(298, 28);
            label6.TabIndex = 20;
            label6.Text = "Виберіть відповідний шаблон";
            // 
            // comboBoxШаблони
            // 
            comboBoxШаблони.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            comboBoxШаблони.FormattingEnabled = true;
            comboBoxШаблони.Location = new Point(355, 19);
            comboBoxШаблони.Name = "comboBoxШаблони";
            comboBoxШаблони.Size = new Size(385, 36);
            comboBoxШаблони.TabIndex = 23;
            // 
            // textBoxCount
            // 
            textBoxCount.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            textBoxCount.Location = new Point(615, 326);
            textBoxCount.Name = "textBoxCount";
            textBoxCount.Size = new Size(125, 34);
            textBoxCount.TabIndex = 24;
            textBoxCount.KeyDown += textBoxCount_KeyDown;
            // 
            // textBoxPayKod
            // 
            textBoxPayKod.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            textBoxPayKod.Location = new Point(615, 206);
            textBoxPayKod.Name = "textBoxPayKod";
            textBoxPayKod.Size = new Size(125, 34);
            textBoxPayKod.TabIndex = 25;
            textBoxPayKod.KeyDown += textBoxPayKod_KeyDown;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BackColor = Color.Brown;
            label8.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label8.ForeColor = SystemColors.ButtonHighlight;
            label8.Location = new Point(12, 329);
            label8.Name = "label8";
            label8.Size = new Size(351, 28);
            label8.TabIndex = 26;
            label8.Text = "Введіть номер колонки з рахунком";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.BackColor = Color.Brown;
            label9.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label9.ForeColor = SystemColors.ButtonHighlight;
            label9.Location = new Point(12, 209);
            label9.Name = "label9";
            label9.Size = new Size(406, 28);
            label9.TabIndex = 27;
            label9.Text = "Введіть номер колонки з кодом платежу";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkSalmon;
            ClientSize = new Size(890, 554);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(textBoxPayKod);
            Controls.Add(textBoxCount);
            Controls.Add(comboBoxШаблони);
            Controls.Add(label6);
            Controls.Add(textBoxДата);
            Controls.Add(label7);
            Controls.Add(Довідка);
            Controls.Add(textBoxНазваНовогоФайлу);
            Controls.Add(label5);
            Controls.Add(ВибратиШлхДоФайлу);
            Controls.Add(textBoxНазва_Файла);
            Controls.Add(label4);
            Controls.Add(Квитанції);
            Controls.Add(textBoxСума_Податку);
            Controls.Add(label3);
            Controls.Add(textBoxНомер_колонки_ПІП);
            Controls.Add(label2);
            Name = "Form1";
            Text = "Формування_Квитанцій";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox textBoxНомер_колонки_ПІП;
        private Label label3;
        private TextBox textBoxСума_Податку;
        private Button Квитанції;
        private Label label2;
        private Label label4;
        private TextBox textBoxНазва_Файла;
        private Button ВибратиШлхДоФайлу;
        private Label label5;
        private TextBox textBoxНазваНовогоФайлу;
        private Label Довідка;
        private Label label7;
        private TextBox textBoxДата;
        private Label label6;
        private ComboBox comboBoxШаблони;
        private TextBox textBoxCount;
        private TextBox textBoxPayKod;
        private Label label8;
        private Label label9;
    }
}