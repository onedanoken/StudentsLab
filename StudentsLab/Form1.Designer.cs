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
            сохранитьToolStripMenuItem = new ToolStripMenuItem();
            просмотрToolStripMenuItem = new ToolStripMenuItem();
            следуюToolStripMenuItem = new ToolStripMenuItem();
            следующийToolStripMenuItem = new ToolStripMenuItem();
            студентыToolStripMenuItem = new ToolStripMenuItem();
            добавитьСтудентаToolStripMenuItem = new ToolStripMenuItem();
            удалитьСтудентаToolStripMenuItem = new ToolStripMenuItem();
            button3 = new Button();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Enabled = false;
            button1.Location = new Point(59, 379);
            button1.Margin = new Padding(3, 4, 3, 4);
            button1.Name = "button1";
            button1.Size = new Size(152, 44);
            button1.TabIndex = 0;
            button1.Text = "Предыдущий";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Enabled = false;
            button2.Location = new Point(266, 379);
            button2.Margin = new Padding(3, 4, 3, 4);
            button2.Name = "button2";
            button2.Size = new Size(152, 44);
            button2.TabIndex = 1;
            button2.Text = "Следующий";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(173, 81);
            textBox1.Margin = new Padding(3, 4, 3, 4);
            textBox1.Name = "textBox1";
            textBox1.ReadOnly = true;
            textBox1.Size = new Size(181, 27);
            textBox1.TabIndex = 2;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(173, 140);
            textBox2.Margin = new Padding(3, 4, 3, 4);
            textBox2.Name = "textBox2";
            textBox2.ReadOnly = true;
            textBox2.Size = new Size(181, 27);
            textBox2.TabIndex = 3;
            textBox2.TextChanged += textBox2_TextChanged;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(173, 203);
            textBox3.Margin = new Padding(3, 4, 3, 4);
            textBox3.Name = "textBox3";
            textBox3.ReadOnly = true;
            textBox3.Size = new Size(181, 27);
            textBox3.TabIndex = 4;
            textBox3.TextChanged += textBox3_TextChanged;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(173, 265);
            textBox4.Margin = new Padding(3, 4, 3, 4);
            textBox4.Name = "textBox4";
            textBox4.ReadOnly = true;
            textBox4.Size = new Size(181, 27);
            textBox4.TabIndex = 5;
            textBox4.TextChanged += textBox4_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(110, 85);
            label1.Name = "label1";
            label1.Size = new Size(39, 20);
            label1.TabIndex = 6;
            label1.Text = "Имя";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(83, 144);
            label2.Name = "label2";
            label2.Size = new Size(73, 20);
            label2.TabIndex = 7;
            label2.Text = "Фамилия";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(79, 207);
            label3.Name = "label3";
            label3.Size = new Size(78, 20);
            label3.TabIndex = 8;
            label3.Text = "Факультет";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(25, 269);
            label4.Name = "label4";
            label4.Size = new Size(142, 20);
            label4.TabIndex = 9;
            label4.Text = "Диплом бакалавра";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(25, 441);
            label5.Name = "label5";
            label5.Size = new Size(52, 20);
            label5.TabIndex = 10;
            label5.Text = "Поиск";
            // 
            // textBox5
            // 
            textBox5.Location = new Point(266, 480);
            textBox5.Margin = new Padding(3, 4, 3, 4);
            textBox5.Name = "textBox5";
            textBox5.ReadOnly = true;
            textBox5.Size = new Size(181, 27);
            textBox5.TabIndex = 11;
            textBox5.TextChanged += textBox5_TextChanged;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(231, 484);
            label6.Name = "label6";
            label6.Size = new Size(19, 20);
            label6.TabIndex = 12;
            label6.Text = "=";
            // 
            // comboBox1
            // 
            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox1.Enabled = false;
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Имя", "Фамилия", "Факультет", "Диплом бакалавра" });
            comboBox1.Location = new Point(25, 480);
            comboBox1.Margin = new Padding(3, 4, 3, 4);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(186, 28);
            comboBox1.TabIndex = 13;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged_1;
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { toolStripMenuItem1, toolStripMenuItem2, просмотрToolStripMenuItem, студентыToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Padding = new Padding(7, 3, 0, 3);
            menuStrip1.Size = new Size(485, 30);
            menuStrip1.TabIndex = 14;
            menuStrip1.Text = "menuStrip1";
            // 
            // toolStripMenuItem1
            // 
            toolStripMenuItem1.Name = "toolStripMenuItem1";
            toolStripMenuItem1.Size = new Size(14, 24);
            // 
            // toolStripMenuItem2
            // 
            toolStripMenuItem2.DropDownItems.AddRange(new ToolStripItem[] { открытьФайлToolStripMenuItem, создатьНовыйФайлToolStripMenuItem, сохранитьФайлToolStripMenuItem, сохранитьToolStripMenuItem });
            toolStripMenuItem2.Name = "toolStripMenuItem2";
            toolStripMenuItem2.Size = new Size(59, 24);
            toolStripMenuItem2.Text = "Файл";
            // 
            // открытьФайлToolStripMenuItem
            // 
            открытьФайлToolStripMenuItem.Name = "открытьФайлToolStripMenuItem";
            открытьФайлToolStripMenuItem.Size = new Size(236, 26);
            открытьФайлToolStripMenuItem.Text = "Открыть файл";
            открытьФайлToolStripMenuItem.Click += открытьФайлToolStripMenuItem_Click_1;
            // 
            // создатьНовыйФайлToolStripMenuItem
            // 
            создатьНовыйФайлToolStripMenuItem.Name = "создатьНовыйФайлToolStripMenuItem";
            создатьНовыйФайлToolStripMenuItem.Size = new Size(236, 26);
            создатьНовыйФайлToolStripMenuItem.Text = "Создать новый файл";
            создатьНовыйФайлToolStripMenuItem.Click += создатьНовыйФайлToolStripMenuItem_Click_1;
            // 
            // сохранитьФайлToolStripMenuItem
            // 
            сохранитьФайлToolStripMenuItem.Enabled = false;
            сохранитьФайлToolStripMenuItem.Name = "сохранитьФайлToolStripMenuItem";
            сохранитьФайлToolStripMenuItem.Size = new Size(236, 26);
            сохранитьФайлToolStripMenuItem.Text = "Сохранить файл";
            сохранитьФайлToolStripMenuItem.Click += сохранитьФайлToolStripMenuItem_Click_1;
            // 
            // сохранитьToolStripMenuItem
            // 
            сохранитьToolStripMenuItem.Enabled = false;
            сохранитьToolStripMenuItem.Name = "сохранитьToolStripMenuItem";
            сохранитьToolStripMenuItem.Size = new Size(236, 26);
            сохранитьToolStripMenuItem.Text = "Сохранить";
            сохранитьToolStripMenuItem.Click += сохранитьToolStripMenuItem_Click;
            // 
            // просмотрToolStripMenuItem
            // 
            просмотрToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { следуюToolStripMenuItem, следующийToolStripMenuItem });
            просмотрToolStripMenuItem.Name = "просмотрToolStripMenuItem";
            просмотрToolStripMenuItem.Size = new Size(94, 24);
            просмотрToolStripMenuItem.Text = "Просмотр";
            // 
            // следуюToolStripMenuItem
            // 
            следуюToolStripMenuItem.Enabled = false;
            следуюToolStripMenuItem.Name = "следуюToolStripMenuItem";
            следуюToolStripMenuItem.Size = new Size(184, 26);
            следуюToolStripMenuItem.Text = "Предыдущий";
            следуюToolStripMenuItem.Click += следуюToolStripMenuItem_Click_1;
            // 
            // следующийToolStripMenuItem
            // 
            следующийToolStripMenuItem.Enabled = false;
            следующийToolStripMenuItem.Name = "следующийToolStripMenuItem";
            следующийToolStripMenuItem.Size = new Size(184, 26);
            следующийToolStripMenuItem.Text = "Следующий";
            следующийToolStripMenuItem.Click += следующийToolStripMenuItem_Click_1;
            // 
            // студентыToolStripMenuItem
            // 
            студентыToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { добавитьСтудентаToolStripMenuItem, удалитьСтудентаToolStripMenuItem });
            студентыToolStripMenuItem.Name = "студентыToolStripMenuItem";
            студентыToolStripMenuItem.Size = new Size(87, 24);
            студентыToolStripMenuItem.Text = "Студенты";
            // 
            // добавитьСтудентаToolStripMenuItem
            // 
            добавитьСтудентаToolStripMenuItem.Enabled = false;
            добавитьСтудентаToolStripMenuItem.Name = "добавитьСтудентаToolStripMenuItem";
            добавитьСтудентаToolStripMenuItem.Size = new Size(222, 26);
            добавитьСтудентаToolStripMenuItem.Text = "Добавить студента";
            добавитьСтудентаToolStripMenuItem.Click += добавитьСтудентаToolStripMenuItem_Click_1;
            // 
            // удалитьСтудентаToolStripMenuItem
            // 
            удалитьСтудентаToolStripMenuItem.Enabled = false;
            удалитьСтудентаToolStripMenuItem.Name = "удалитьСтудентаToolStripMenuItem";
            удалитьСтудентаToolStripMenuItem.Size = new Size(222, 26);
            удалитьСтудентаToolStripMenuItem.Text = "Удалить студента";
            удалитьСтудентаToolStripMenuItem.Click += удалитьСтудентаToolStripMenuItem_Click_1;
            // 
            // button3
            // 
            button3.Location = new Point(153, 269);
            button3.Margin = new Padding(3, 4, 3, 4);
            button3.Name = "button3";
            button3.Size = new Size(180, 44);
            button3.TabIndex = 15;
            button3.Text = "Сделать магистром!";
            button3.UseVisualStyleBackColor = true;
            button3.Visible = false;
            button3.Click += button3_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(485, 588);
            Controls.Add(button3);
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
            Name = "Form1";
            Text = "Студенты";
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
        private Button button3;
        private ToolStripMenuItem сохранитьToolStripMenuItem;
    }
}