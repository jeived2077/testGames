namespace WinFormsApp1
{
    partial class Form7
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(86, 67);
            button1.Name = "button1";
            button1.Size = new Size(195, 23);
            button1.TabIndex = 0;
            button1.Text = "Сходить в гости - 5$";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(86, 129);
            button2.Name = "button2";
            button2.Size = new Size(195, 23);
            button2.TabIndex = 1;
            button2.Text = "Сауна с девушками - 20$";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(86, 193);
            button3.Name = "button3";
            button3.Size = new Size(195, 23);
            button3.TabIndex = 2;
            button3.Text = "Игра арканоид - 30$";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.Location = new Point(304, 260);
            button4.Name = "button4";
            button4.Size = new Size(195, 23);
            button4.TabIndex = 3;
            button4.Text = "Вернуться";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(71, 262);
            label1.Name = "label1";
            label1.Size = new Size(115, 15);
            label1.TabIndex = 4;
            label1.Text = "Ваше настроение • ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(192, 264);
            label2.Name = "label2";
            label2.Size = new Size(72, 15);
            label2.TabIndex = 5;
            label2.Text = "Нормально";
            // 
            // label3
            // 
            label3.Location = new Point(99, 295);
            label3.Name = "label3";
            label3.Size = new Size(145, 36);
            label3.TabIndex = 6;
            label3.Text = "Как вы хотите развлечься ? ";
            label3.Click += label3_Click;
            // 
            // Form7
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Name = "Form7";
            Text = "Form7";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        public Button button1;
        public Button button2;
        public Button button3;
        public Button button4;
        public Label label1;
        public Label label2;
        public Label label3;
    }
}