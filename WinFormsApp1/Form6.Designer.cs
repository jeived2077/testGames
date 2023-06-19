namespace WinFormsApp1
{
    partial class Form6
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
            textBox1 = new TextBox();
            label1 = new Label();
            button3 = new Button();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(12, 84);
            button1.Name = "button1";
            button1.Size = new Size(194, 23);
            button1.TabIndex = 0;
            button1.Text = "Звонить на CinBBS";
            button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new Point(12, 129);
            button2.Name = "button2";
            button2.Size = new Size(194, 34);
            button2.TabIndex = 1;
            button2.Text = "Создать свою";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(35, 200);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(160, 23);
            textBox1.TabIndex = 2;
            // 
            // label1
            // 
            label1.Location = new Point(45, 252);
            label1.Name = "label1";
            label1.Size = new Size(128, 44);
            label1.TabIndex = 3;
            label1.Text = "Для работы нужен комп и винчестре";
            label1.Click += label1_Click;
            // 
            // button3
            // 
            button3.Location = new Point(249, 264);
            button3.Name = "button3";
            button3.Size = new Size(75, 23);
            button3.TabIndex = 4;
            button3.Text = "Вернутся";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // Form6
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(368, 305);
            Controls.Add(button3);
            Controls.Add(label1);
            Controls.Add(textBox1);
            Controls.Add(button2);
            Controls.Add(button1);
            Name = "Form6";
            Text = "Form6";
            Load += Form6_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        public Button button1;
        public Button button2;
        public TextBox textBox1;
        public Label label1;
        public Button button3;
    }
}