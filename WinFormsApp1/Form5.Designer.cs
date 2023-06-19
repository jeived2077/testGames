namespace WinFormsApp1
{
    partial class Form5
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
            panel1 = new Panel();
            button7 = new Button();
            button6 = new Button();
            button5 = new Button();
            button4 = new Button();
            button3 = new Button();
            button1 = new Button();
            label1 = new Label();
            label2 = new Label();
            button8 = new Button();
            label3 = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(button7);
            panel1.Controls.Add(button6);
            panel1.Controls.Add(button5);
            panel1.Controls.Add(button4);
            panel1.Controls.Add(button3);
            panel1.Controls.Add(button1);
            panel1.Location = new Point(12, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(157, 241);
            panel1.TabIndex = 1;
            // 
            // button7
            // 
            button7.Location = new Point(3, 203);
            button7.Name = "button7";
            button7.Size = new Size(149, 34);
            button7.TabIndex = 6;
            button7.Text = "Sound Blaster";
            button7.UseVisualStyleBackColor = true;
            button7.Click += button7_Click;
            button7.MouseMove += button7_MouseMove;
            // 
            // button6
            // 
            button6.Location = new Point(3, 163);
            button6.Name = "button6";
            button6.Size = new Size(149, 34);
            button6.TabIndex = 5;
            button6.Text = "апгрейд CD-ROM";
            button6.UseVisualStyleBackColor = true;
            button6.Click += button6_Click;
            button6.MouseMove += button6_MouseMove;
            // 
            // button5
            // 
            button5.Location = new Point(3, 123);
            button5.Name = "button5";
            button5.Size = new Size(149, 34);
            button5.TabIndex = 4;
            button5.Text = "апгрейд модема";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            button5.MouseMove += button5_MouseMove;
            // 
            // button4
            // 
            button4.Location = new Point(3, 83);
            button4.Name = "button4";
            button4.Size = new Size(149, 34);
            button4.TabIndex = 3;
            button4.Text = "апгрейд винчестера";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            button4.MouseMove += button4_MouseMove;
            // 
            // button3
            // 
            button3.Location = new Point(3, 43);
            button3.Name = "button3";
            button3.Size = new Size(149, 34);
            button3.TabIndex = 2;
            button3.Text = "Апгрейд памяти";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            button3.MouseMove += button3_MouseMove;
            // 
            // button1
            // 
            button1.Location = new Point(3, 3);
            button1.Name = "button1";
            button1.Size = new Size(149, 34);
            button1.TabIndex = 0;
            button1.Text = "Апгрейд компьютера";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            button1.MouseMove += button1_MouseMove;
            // 
            // label1
            // 
            label1.Location = new Point(175, 26);
            label1.Name = "label1";
            label1.Size = new Size(91, 104);
            label1.TabIndex = 2;
            label1.Text = "Вы хотите обновить ваш компьютер?  Нет проблем";
            // 
            // label2
            // 
            label2.Location = new Point(197, 328);
            label2.Name = "label2";
            label2.Size = new Size(139, 50);
            label2.TabIndex = 3;
            // 
            // button8
            // 
            button8.Location = new Point(217, 111);
            button8.Name = "button8";
            button8.Size = new Size(130, 34);
            button8.TabIndex = 7;
            button8.Text = "Вернутся";
            button8.UseVisualStyleBackColor = true;
            button8.Click += button8_Click;
            // 
            // label3
            // 
            label3.Location = new Point(185, 186);
            label3.Name = "label3";
            label3.Size = new Size(137, 52);
            label3.TabIndex = 8;
            // 
            // Form5
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(386, 353);
            Controls.Add(label3);
            Controls.Add(button8);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(panel1);
            Name = "Form5";
            Text = "Form5";
            Load += Form5_Load;
            panel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        public Panel panel1;
        public Button button7;
        public Button button6;
        public Button button5;
        public Button button4;
        public Button button3;
        public Button button1;
        public Label label1;
        public Label label2;
        public Button button8;
        public Label label3;
    }
}