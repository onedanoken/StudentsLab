namespace StudentsLab
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
            button1 = new Button();
            button2 = new Button();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            textBox5 = new TextBox();
            label6 = new Label();
            comboBox1 = new ComboBox();
            menuStrip1 = new MenuStrip();
            toolStripMenuItem1 = new ToolStripMenuItem();
            toolStripMenuItem2 = new ToolStripMenuItem();
            открытьФайлToolStripMenuItem = new ToolStripMenuItem();
            создатьНовыйФайлToolStripMenuItem = new ToolStripMenuItem();
            сохранитьФайлToolStripMenuItem = new ToolStripMenuItem();
            просмотрToolStripMenuItem = new ToolStripMenuItem();
            следуюToolStripMenuItem = new ToolStripMenuItem();
            следующийToolStripMenuItem = new ToolStripMenuItem();
            студентыToolStripMenuItem = new ToolStripMenuItem();
            добавитьСтудентаToolStripMenuItem = new ToolStripMenuItem();
            удалитьСтудентаToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(52, 284);
            button1.Name = "button1";
            button1.Size = new Size(133, 33);
            button1.TabIndex = 0;
            button1.Text = "Предыдущий";
            button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new Point(233, 284);
            button2.Name = "button2";
            button2.Size = new Size(133, 33);
            button2.TabIndex = 1;
            button2.Text = "Следующий";
            button2.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(151, 61);
            textBox1.Name = "textBox1";
            textBox1.ReadOnly = true;
            textBox1.Size = new Size(159, 23);
            textBox1.TabIndex = 2;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(151, 105);
            textBox2.Name = "textBox2";
            textBox2.ReadOnly = true;
            textBox2.Size = new Size(159, 23);
            textBox2.TabIndex = 3;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(151, 152);
            textBox3.Name = "textBox3";
            textBox3.ReadOnly = true;
            textBox3.Size = new Size(159, 23);
            textBox3.TabIndex = 4;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(151, 199);
            textBox4.Name = "textBox4";
            textBox4.ReadOnly = true;
            textBox4.Size = new Size(159, 23);
            textBox4.TabIndex = 5;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(96, 64);
            label1.Name = "label1";
            label1.Size = new Size(31, 15);
            label1.TabIndex = 6;
            label1.Text = "Имя";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(73, 108);
            label2.Name = "label2";
            label2.Size = new Size(58, 15);
            label2.TabIndex = 7;
            label2.Text = "Фамилия";
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(69, 155);
            label3.Name = "label3";
            label3.Size = new Size(63, 15);
            label3.TabIndex = 8;
            label3.Text = "Факультет";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(22, 202);
            label4.Name = "label4";
            label4.Size = new Size(112, 15);
            label4.TabIndex = 9;
            label4.Text = "Диплом бакалавра";
            label4.Click += label4_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(22, 365);
            label5.Name = "label5";
            label5.Size = new Size(42, 15);
            label5.TabIndex = 10;
            label5.Text = "Поиск";
            label5.Click += label5_Click;
            // 
            // textBox5
            // 
            textBox5.Location = new Point(233, 394);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(159, 23);
            textBox5.TabIndex = 11;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(202, 397);
            label6.Name = "label6";
            label6.Size = new Size(15, 15);
            label6.TabIndex = 12;
            label6.Text = "=";
            // 
            // comboBox1
            // 
            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Имя", "Фамилия", "Факультет" });
            comboBox1.Location = new Point(22, 394);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(163, 23);
            comboBox1.TabIndex = 13;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { toolStripMenuItem1, toolStripMenuItem2, просмотрToolStripMenuItem, студентыToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(424, 24);
            menuStrip1.TabIndex = 14;
            menuStrip1.Text = "menuStrip1";
            // 
            // toolStripMenuItem1
            // 
            toolStripMenuItem1.Name = "toolStripMenuItem1";
            toolStripMenuItem1.Size = new Size(12, 20);
            // 
            // toolStripMenuItem2
            // 
            toolStripMenuItem2.DropDownItems.AddRange(new ToolStripItem[] { открытьФайлToolStripMenuItem, создатьНовыйФайлToolStripMenuItem, сохранитьФайлToolStripMenuItem });
            toolStripMenuItem2.Name = "toolStripMenuItem2";
            toolStripMenuItem2.Size = new Size(48, 20);
            toolStripMenuItem2.Text = "Файл";
            toolStripMenuItem2.Click += toolStripMenuItem2_Click;
            // 
            // открытьФайлToolStripMenuItem
            // 
            открытьФайлToolStripMenuItem.Name = "открытьФайлToolStripMenuItem";
            открытьФайлToolStripMenuItem.Size = new Size(188, 22);
            открытьФайлToolStripMenuItem.Text = "Открыть файл";
            открытьФайлToolStripMenuItem.Click += открытьФайлToolStripMenuItem_Click;
            // 
            // создатьНовыйФайлToolStripMenuItem
            // 
            создатьНовыйФайлToolStripMenuItem.Name = "создатьНовыйФайлToolStripMenuItem";
            создатьНовыйФайлToolStripMenuItem.Size = new Size(188, 22);
            создатьНовыйФайлToolStripMenuItem.Text = "Создать новый файл";
            создатьНовыйФайлToolStripMenuItem.Click += создатьНовыйФайлToolStripMenuItem_Click;
            // 
            // сохранитьФайлToolStripMenuItem
            // 
            сохранитьФайлToolStripMenuItem.Name = "сохранитьФайлToolStripMenuItem";
            сохранитьФайлToolStripMenuItem.Size = new Size(188, 22);
            сохранитьФайлToolStripMenuItem.Text = "Сохранить файл";
            сохранитьФайлToolStripMenuItem.Click += сохранитьФайлToolStripMenuItem_Click;
            // 
            // просмотрToolStripMenuItem
            // 
            просмотрToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { следуюToolStripMenuItem, следующийToolStripMenuItem });
            просмотрToolStripMenuItem.Name = "просмотрToolStripMenuItem";
            просмотрToolStripMenuItem.Size = new Size(76, 20);
            просмотрToolStripMenuItem.Text = "Просмотр";
            // 
            // следуюToolStripMenuItem
            // 
            следуюToolStripMenuItem.Name = "следуюToolStripMenuItem";
            следуюToolStripMenuItem.Size = new Size(148, 22);
            следуюToolStripMenuItem.Text = "Предыдущий";
            следуюToolStripMenuItem.Click += следуюToolStripMenuItem_Click;
            // 
            // следующийToolStripMenuItem
            // 
            следующийToolStripMenuItem.Name = "следующийToolStripMenuItem";
            следующийToolStripMenuItem.Size = new Size(180, 22);
            следующийToolStripMenuItem.Text = "Следующий";
            следующийToolStripMenuItem.Click += следующийToolStripMenuItem_Click;
            // 
            // студентыToolStripMenuItem
            // 
            студентыToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { добавитьСтудентаToolStripMenuItem, удалитьСтудентаToolStripMenuItem });
            студентыToolStripMenuItem.Name = "студентыToolStripMenuItem";
            студентыToolStripMenuItem.Size = new Size(71, 20);
            студентыToolStripMenuItem.Text = "Студенты";
            // 
            // добавитьСтудентаToolStripMenuItem
            // 
            добавитьСтудентаToolStripMenuItem.Name = "добавитьСтудентаToolStripMenuItem";
            добавитьСтудентаToolStripMenuItem.Size = new Size(180, 22);
            добавитьСтудентаToolStripMenuItem.Text = "Добавить студента";
            добавитьСтудентаToolStripMenuItem.Click += добавитьСтудентаToolStripMenuItem_Click;
            // 
            // удалитьСтудентаToolStripMenuItem
            // 
            удалитьСтудентаToolStripMenuItem.Name = "удалитьСтудентаToolStripMenuItem";
            удалитьСтудентаToolStripMenuItem.Size = new Size(180, 22);
            удалитьСтудентаToolStripMenuItem.Text = "Удалить студента";
            удалитьСтудентаToolStripMenuItem.Click += удалитьСтудентаToolStripMenuItem_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(424, 441);
            Controls.Add(comboBox1);
            Controls.Add(label6);
            Controls.Add(textBox5);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(textBox4);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Margin = new Padding(3, 2, 3, 2);
            Name = "Form1";
            Text = "Студенты";
            Load += Form1_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Button button2;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private TextBox textBox4;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox textBox5;
        private Label label6;
        private ComboBox comboBox1;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem toolStripMenuItem1;
        private ToolStripMenuItem toolStripMenuItem2;
        private ToolStripMenuItem открытьФайлToolStripMenuItem;
        private ToolStripMenuItem создатьНовыйФайлToolStripMenuItem;
        private ToolStripMenuItem просмотрToolStripMenuItem;
        private ToolStripMenuItem следуюToolStripMenuItem;
        private ToolStripMenuItem студентыToolStripMenuItem;
        private ToolStripMenuItem следующийToolStripMenuItem;
        private ToolStripMenuItem добавитьСтудентаToolStripMenuItem;
        private ToolStripMenuItem удалитьСтудентаToolStripMenuItem;
        private ToolStripMenuItem сохранитьФайлToolStripMenuItem;
    }
}