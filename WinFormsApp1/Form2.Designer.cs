namespace WinFormsApp1
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            textBox1 = new TextBox();
            button1 = new Button();
            label1 = new Label();
            timer1 = new System.Windows.Forms.Timer(components);
            pictureBox1 = new PictureBox();
            menuStrip1 = new MenuStrip();
            файлToolStripMenuItem = new ToolStripMenuItem();
            новаяИграToolStripMenuItem1 = new ToolStripMenuItem();
            сахранитьИгруToolStripMenuItem1 = new ToolStripMenuItem();
            загрузитьИгруToolStripMenuItem1 = new ToolStripMenuItem();
            настройкиToolStripMenuItem = new ToolStripMenuItem();
            музон1ToolStripMenuItem = new ToolStripMenuItem();
            помощьToolStripMenuItem = new ToolStripMenuItem();
            вкратцеToolStripMenuItem = new ToolStripMenuItem();
            описаниеToolStripMenuItem = new ToolStripMenuItem();
            разноеToolStripMenuItem = new ToolStripMenuItem();
            оПрограммеToolStripMenuItem = new ToolStripMenuItem();
            vToolStripMenuItem = new ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.Location = new Point(123, 124);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(180, 23);
            textBox1.TabIndex = 0;
            // 
            // button1
            // 
            button1.Location = new Point(132, 153);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 1;
            button1.Text = "Ввести";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(0, 132);
            label1.Name = "label1";
            label1.Size = new Size(105, 15);
            label1.TabIndex = 2;
            label1.Text = "Введите своё Имя";
            // 
            // timer1
            // 
            timer1.Tick += timer1_Tick;
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = (Image)resources.GetObject("pictureBox1.BackgroundImage");
            pictureBox1.Location = new Point(4, 27);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(299, 91);
            pictureBox1.TabIndex = 17;
            pictureBox1.TabStop = false;
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { файлToolStripMenuItem, настройкиToolStripMenuItem, помощьToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(307, 24);
            menuStrip1.TabIndex = 18;
            menuStrip1.Text = "menuStrip1";
            // 
            // файлToolStripMenuItem
            // 
            файлToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { новаяИграToolStripMenuItem1, сахранитьИгруToolStripMenuItem1, загрузитьИгруToolStripMenuItem1 });
            файлToolStripMenuItem.Name = "файлToolStripMenuItem";
            файлToolStripMenuItem.Size = new Size(48, 20);
            файлToolStripMenuItem.Text = "Файл";
            // 
            // новаяИграToolStripMenuItem1
            // 
            новаяИграToolStripMenuItem1.Name = "новаяИграToolStripMenuItem1";
            новаяИграToolStripMenuItem1.Size = new Size(160, 22);
            новаяИграToolStripMenuItem1.Text = "Новая игра";
            // 
            // сахранитьИгруToolStripMenuItem1
            // 
            сахранитьИгруToolStripMenuItem1.Name = "сахранитьИгруToolStripMenuItem1";
            сахранитьИгруToolStripMenuItem1.Size = new Size(160, 22);
            сахранитьИгруToolStripMenuItem1.Text = "Сахранить игру";
            // 
            // загрузитьИгруToolStripMenuItem1
            // 
            загрузитьИгруToolStripMenuItem1.Name = "загрузитьИгруToolStripMenuItem1";
            загрузитьИгруToolStripMenuItem1.Size = new Size(160, 22);
            загрузитьИгруToolStripMenuItem1.Text = "Загрузить игру";
            // 
            // настройкиToolStripMenuItem
            // 
            настройкиToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { музон1ToolStripMenuItem, vToolStripMenuItem });
            настройкиToolStripMenuItem.Name = "настройкиToolStripMenuItem";
            настройкиToolStripMenuItem.Size = new Size(79, 20);
            настройкиToolStripMenuItem.Text = "Настройки";
            // 
            // музон1ToolStripMenuItem
            // 
            музон1ToolStripMenuItem.Name = "музон1ToolStripMenuItem";
            музон1ToolStripMenuItem.Size = new Size(180, 22);
            музон1ToolStripMenuItem.Text = "Музон №1";
            музон1ToolStripMenuItem.Click += музон1ToolStripMenuItem_Click;
            // 
            // помощьToolStripMenuItem
            // 
            помощьToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { вкратцеToolStripMenuItem, описаниеToolStripMenuItem, разноеToolStripMenuItem, оПрограммеToolStripMenuItem });
            помощьToolStripMenuItem.Name = "помощьToolStripMenuItem";
            помощьToolStripMenuItem.Size = new Size(68, 20);
            помощьToolStripMenuItem.Text = "Помощь";
            // 
            // вкратцеToolStripMenuItem
            // 
            вкратцеToolStripMenuItem.Name = "вкратцеToolStripMenuItem";
            вкратцеToolStripMenuItem.Size = new Size(149, 22);
            вкратцеToolStripMenuItem.Text = "Вкратце";
            вкратцеToolStripMenuItem.Click += вкратцеToolStripMenuItem_Click;
            // 
            // описаниеToolStripMenuItem
            // 
            описаниеToolStripMenuItem.Name = "описаниеToolStripMenuItem";
            описаниеToolStripMenuItem.Size = new Size(149, 22);
            описаниеToolStripMenuItem.Text = "Описание";
            описаниеToolStripMenuItem.Click += описаниеToolStripMenuItem_Click;
            // 
            // разноеToolStripMenuItem
            // 
            разноеToolStripMenuItem.Name = "разноеToolStripMenuItem";
            разноеToolStripMenuItem.Size = new Size(149, 22);
            разноеToolStripMenuItem.Text = "Разное";
            разноеToolStripMenuItem.Click += разноеToolStripMenuItem_Click;
            // 
            // оПрограммеToolStripMenuItem
            // 
            оПрограммеToolStripMenuItem.Name = "оПрограммеToolStripMenuItem";
            оПрограммеToolStripMenuItem.Size = new Size(149, 22);
            оПрограммеToolStripMenuItem.Text = "О программе";
            оПрограммеToolStripMenuItem.Click += оПрограммеToolStripMenuItem_Click;
            // 
            // vToolStripMenuItem
            // 
            vToolStripMenuItem.Checked = true;
            vToolStripMenuItem.CheckState = CheckState.Checked;
            vToolStripMenuItem.Name = "vToolStripMenuItem";
            vToolStripMenuItem.Size = new Size(180, 22);
            vToolStripMenuItem.Text = "Музыка";
            vToolStripMenuItem.Click += vToolStripMenuItem_Click;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(307, 188);
            Controls.Add(menuStrip1);
            Controls.Add(pictureBox1);
            Controls.Add(label1);
            Controls.Add(button1);
            Controls.Add(textBox1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "Form2";
            Text = "Form2";
            FormClosing += Form2_FormClosing;
            Load += Form2_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        public TextBox textBox1;
        public Button button1;
        public Label label1;
        public System.Windows.Forms.Timer timer1;
        public PictureBox pictureBox1;
        public MenuStrip menuStrip1;
        public ToolStripMenuItem файлToolStripMenuItem;
        public ToolStripMenuItem новаяИграToolStripMenuItem1;
        public ToolStripMenuItem сахранитьИгруToolStripMenuItem1;
        public ToolStripMenuItem загрузитьИгруToolStripMenuItem1;
        public ToolStripMenuItem настройкиToolStripMenuItem;
        public ToolStripMenuItem музон1ToolStripMenuItem;
        public ToolStripMenuItem помощьToolStripMenuItem;
        public ToolStripMenuItem вкратцеToolStripMenuItem;
        public ToolStripMenuItem описаниеToolStripMenuItem;
        public ToolStripMenuItem разноеToolStripMenuItem;
        public ToolStripMenuItem оПрограммеToolStripMenuItem;
        public ToolStripMenuItem vToolStripMenuItem;
    }
}