namespace WinFormsApp1
{
    partial class Form3
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        public System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        public void InitializeComponent()
        {
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            label1 = new Label();
            button6 = new Button();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(145, 12);
            button1.Name = "button1";
            button1.Size = new Size(218, 48);
            button1.TabIndex = 0;
            button1.Text = "Дворник 10$ в день";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(145, 66);
            button2.Name = "button2";
            button2.Size = new Size(218, 48);
            button2.TabIndex = 1;
            button2.Text = "Слесарь 20$ в день";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(145, 120);
            button3.Name = "button3";
            button3.Size = new Size(218, 48);
            button3.TabIndex = 2;
            button3.Text = "Программист 30$ в день";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.Location = new Point(145, 224);
            button4.Name = "button4";
            button4.Size = new Size(218, 48);
            button4.TabIndex = 3;
            button4.Text = "Крутой хакер 70$ в день";
            button4.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            button5.Location = new Point(145, 170);
            button5.Name = "button5";
            button5.Size = new Size(218, 48);
            button5.TabIndex = 4;
            button5.Text = "Сис админ 40$ в день";
            button5.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.Location = new Point(12, 170);
            label1.Name = "label1";
            label1.Size = new Size(126, 74);
            label1.TabIndex = 5;
            label1.Text = "Сменить работу  можно только до 15 числа месяца";
            // 
            // button6
            // 
            button6.Location = new Point(-1, 236);
            button6.Name = "button6";
            button6.Size = new Size(140, 25);
            button6.TabIndex = 6;
            button6.Text = "Вернутся";
            button6.UseVisualStyleBackColor = true;
            button6.Click += button6_Click;
            // 
            // Form3
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(375, 294);
            Controls.Add(button6);
            Controls.Add(label1);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Name = "Form3";
            Text = "Form3";
            Load += Form3_Load;
            ResumeLayout(false);
        }

        #endregion

        public Button button1;
        public Button button2;
        public Button button3;
        public Button button4;
        public Button button5;
        public Label label1;
        public Button button6;
    }
}