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
            label1 = new Label();
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
            buttonВибірШаблона = new Button();
            comboBoxШаблони = new ComboBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Firebrick;
            label1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(776, 28);
            label1.TabIndex = 0;
            label1.Text = "Опрацьовуваний файл Excel має бути поміщений на дису \"D\" в папці \"Податки\"";
            // 
            // textBoxНомер_колонки_ПІП
            // 
            textBoxНомер_колонки_ПІП.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            textBoxНомер_колонки_ПІП.Location = new Point(615, 186);
            textBoxНомер_колонки_ПІП.Name = "textBoxНомер_колонки_ПІП";
            textBoxНомер_колонки_ПІП.Size = new Size(125, 34);
            textBoxНомер_колонки_ПІП.TabIndex = 2;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.LightCoral;
            label3.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = SystemColors.ButtonHighlight;
            label3.Location = new Point(12, 255);
            label3.Name = "label3";
            label3.Size = new Size(404, 28);
            label3.TabIndex = 3;
            label3.Text = "Введіть номер колонки з сумою податку";
            // 
            // textBoxСума_Податку
            // 
            textBoxСума_Податку.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            textBoxСума_Податку.Location = new Point(615, 249);
            textBoxСума_Податку.Name = "textBoxСума_Податку";
            textBoxСума_Податку.Size = new Size(125, 34);
            textBoxСума_Податку.TabIndex = 4;
            // 
            // Квитанції
            // 
            Квитанції.BackColor = Color.DarkRed;
            Квитанції.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            Квитанції.ForeColor = SystemColors.ButtonHighlight;
            Квитанції.Location = new Point(230, 438);
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
            label2.BackColor = Color.LightCoral;
            label2.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = SystemColors.ButtonHighlight;
            label2.Location = new Point(12, 192);
            label2.Name = "label2";
            label2.Size = new Size(295, 28);
            label2.TabIndex = 1;
            label2.Text = "Введіть номер колонки з ПІП";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.LightCoral;
            label4.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = SystemColors.ButtonHighlight;
            label4.Location = new Point(12, 132);
            label4.Name = "label4";
            label4.Size = new Size(236, 28);
            label4.TabIndex = 6;
            label4.Text = "Виберіть таблицю Excel";
            // 
            // textBoxНазва_Файла
            // 
            textBoxНазва_Файла.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            textBoxНазва_Файла.Location = new Point(274, 126);
            textBoxНазва_Файла.Name = "textBoxНазва_Файла";
            textBoxНазва_Файла.Size = new Size(466, 34);
            textBoxНазва_Файла.TabIndex = 1;
            // 
            // ВибратиШлхДоФайлу
            // 
            ВибратиШлхДоФайлу.BackColor = Color.DarkRed;
            ВибратиШлхДоФайлу.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            ВибратиШлхДоФайлу.ForeColor = SystemColors.ButtonHighlight;
            ВибратиШлхДоФайлу.Location = new Point(768, 124);
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
            label5.BackColor = Color.LightCoral;
            label5.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label5.ForeColor = SystemColors.ButtonHighlight;
            label5.Location = new Point(12, 318);
            label5.Name = "label5";
            label5.Size = new Size(266, 28);
            label5.TabIndex = 12;
            label5.Text = "Введіть назву нового фалу";
            // 
            // textBoxНазваНовогоФайлу
            // 
            textBoxНазваНовогоФайлу.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            textBoxНазваНовогоФайлу.Location = new Point(465, 312);
            textBoxНазваНовогоФайлу.Name = "textBoxНазваНовогоФайлу";
            textBoxНазваНовогоФайлу.Size = new Size(275, 34);
            textBoxНазваНовогоФайлу.TabIndex = 13;
            // 
            // Довідка
            // 
            Довідка.AutoSize = true;
            Довідка.BackColor = Color.OrangeRed;
            Довідка.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            Довідка.ForeColor = SystemColors.ActiveCaptionText;
            Довідка.Location = new Point(562, 464);
            Довідка.Name = "Довідка";
            Довідка.Size = new Size(226, 28);
            Довідка.TabIndex = 14;
            Довідка.Text = "Довідкова інформація";
            Довідка.MouseHover += Довідка_MouseHover;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.LightCoral;
            label7.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label7.ForeColor = SystemColors.ButtonHighlight;
            label7.Location = new Point(12, 372);
            label7.Name = "label7";
            label7.Size = new Size(130, 28);
            label7.TabIndex = 18;
            label7.Text = "Введіть дату";
            // 
            // textBoxДата
            // 
            textBoxДата.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            textBoxДата.Location = new Point(465, 366);
            textBoxДата.Name = "textBoxДата";
            textBoxДата.Size = new Size(275, 34);
            textBoxДата.TabIndex = 19;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.LightCoral;
            label6.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label6.ForeColor = SystemColors.ButtonHighlight;
            label6.Location = new Point(12, 67);
            label6.Name = "label6";
            label6.Size = new Size(298, 28);
            label6.TabIndex = 20;
            label6.Text = "Виберіть відповідний шаблон";
            // 
            // buttonВибірШаблона
            // 
            buttonВибірШаблона.BackColor = Color.DarkRed;
            buttonВибірШаблона.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            buttonВибірШаблона.ForeColor = SystemColors.ButtonHighlight;
            buttonВибірШаблона.Location = new Point(768, 59);
            buttonВибірШаблона.Name = "buttonВибірШаблона";
            buttonВибірШаблона.Size = new Size(110, 36);
            buttonВибірШаблона.TabIndex = 22;
            buttonВибірШаблона.Text = "Вибрати";
            buttonВибірШаблона.UseVisualStyleBackColor = false;
            buttonВибірШаблона.Click += buttonВибірШаблона_Click;
            // 
            // comboBoxШаблони
            // 
            comboBoxШаблони.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            comboBoxШаблони.FormattingEnabled = true;
            comboBoxШаблони.Location = new Point(355, 59);
            comboBoxШаблони.Name = "comboBoxШаблони";
            comboBoxШаблони.Size = new Size(385, 36);
            comboBoxШаблони.TabIndex = 23;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkSalmon;
            ClientSize = new Size(890, 504);
            Controls.Add(comboBoxШаблони);
            Controls.Add(buttonВибірШаблона);
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
            Controls.Add(label1);
            Name = "Form1";
            Text = "Формування_Квитанцій";
            ResumeLayout(false);
            PerformLayout();
        }


        #endregion
        private Label label1;
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
        private Button buttonВибірШаблона;
        private ComboBox comboBoxШаблони;
    }
}