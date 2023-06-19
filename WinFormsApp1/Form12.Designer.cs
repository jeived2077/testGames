namespace WinFormsApp1
{
    partial class Form12
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
            components = new System.ComponentModel.Container();
            timer1 = new System.Windows.Forms.Timer(components);
            label1 = new Label();
            SuspendLayout();
            // 
            // timer1
            // 
//          timer1.Tick += timer1_Tick;
            // 
            // label1
            // 
            label1.Font = new Font("Segoe UI", 72F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(82, 109);
            label1.Name = "label1";
            label1.Size = new Size(605, 223);
            label1.TabIndex = 0;
            label1.Text = "label1";
            // 
            // Form12
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Form12";
            Text = "Form12";
            Load += Form12_Load;
            ResumeLayout(false);
        }

        #endregion

        public System.Windows.Forms.Timer timer1;
        public Label label1;
    }
}