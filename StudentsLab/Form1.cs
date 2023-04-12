using System.Runtime.InteropServices;
using System.Text.Json;
using System.Xml.Serialization;

namespace StudentsLab
{
    public partial class Form1 : Form
    {
        WorkWithStudents students;
        int currentStudent = 0; // óêàçàòåëü íà òåêóùåãî ñòóäåíòà

        public Form1()
        {
            InitializeComponent();
            label4.Visible = false;
            textBox4.Visible = false;
        }

        public void ShowInfo()
        {
            if (students.Students[currentStudent] is Bachelor)
            {
                textBox1.Text = students.Students[currentStudent].FirstName;
                textBox2.Text = students.Students[currentStudent].Surname;
                textBox3.Text = students.Students[currentStudent].Faculty;
                textBox4.Visible = false;
                label4.Visible = false;
                button3.Visible = true;
            }
            else
            {
                textBox4.Visible = true;
                label4.Visible = true;
                textBox1.Text = students.Students[currentStudent].FirstName;
                textBox2.Text = students.Students[currentStudent].Surname;
                textBox3.Text = students.Students[currentStudent].Faculty;
                textBox4.Text = students.Students[currentStudent].Education;
                button3.Visible = false;
            }
        }

        public void EnableForm()
        {
            textBox1.ReadOnly = false;
            textBox2.ReadOnly = false;
            textBox3.ReadOnly = false;
            textBox4.ReadOnly = false;
            äîáàâèòüÑòóäåíòàToolStripMenuItem.Enabled = true;
            óäàëèòüÑòóäåíòàToolStripMenuItem.Enabled = true;
            // ñîçäàòüÍîâûéÔàéëToolStripMenuItem.Enabled = false;
            ñîõğàíèòüÔàéëToolStripMenuItem.Enabled = true;
            comboBox1.Enabled = true;
        }

        public void checkFirstLastOrNull()
        {
            if (students.Students.Count > 0)
            {
                if (currentStudent == 0)
                {
                    button1.Enabled = false;
                    ñëåäóşToolStripMenuItem.Enabled = false;
                } 
                else
                {
                    button1.Enabled = true;
                    ñëåäóşToolStripMenuItem.Enabled = true;
                }
                if (currentStudent == students.Students.Count - 1)
                {
                    button2.Enabled = false;
                    ñëåäóşùèéToolStripMenuItem.Enabled = false;
                }
                else
                {
                    button2.Enabled = true;
                    ñëåäóşùèéToolStripMenuItem.Enabled = true;
                }
            }
            else if (students.Students.Count == 0 || students.Students == null)
            {
                button1.Enabled = false;
                button2.Enabled = false;
                ñëåäóşToolStripMenuItem.Enabled = false; // ïğåäûäóùèé)
                ñëåäóşùèéToolStripMenuItem.Enabled = false;
                óäàëèòüÑòóäåíòàToolStripMenuItem.Enabled = false;
            }
        }

        public void AddStudent()
        {
            Form2 f = new Form2();
            f.ShowDialog();
            int result = f.Result;
            if (result == 1)
            {
                students.Students.Add(new Bachelor());
                if (students.Students.Count == 1)
                {
                    textBox1.ReadOnly = false;
                    textBox2.ReadOnly = false;
                    textBox3.ReadOnly = false;
                    textBox4.ReadOnly = false;
                    óäàëèòüÑòóäåíòàToolStripMenuItem.Enabled = true;
                    ñîõğàíèòüÔàéëToolStripMenuItem.Enabled = true;
                }
                button3.Visible = true;
                textBox1.Text = null;
                textBox2.Text = null;
                textBox3.Text = null;
                textBox4.Text = null;
                textBox4.Visible = false;
                label4.Visible = false;
                checkFirstLastOrNull();
            }
            else
            {
                students.Students.Add(new GradStudent());
                if (students.Students.Count == 1)
                {
                    textBox1.ReadOnly = false;
                    textBox2.ReadOnly = false;
                    textBox3.ReadOnly = false;
                    textBox4.ReadOnly = false;
                    óäàëèòüÑòóäåíòàToolStripMenuItem.Enabled = true;
                    ñîõğàíèòüÔàéëToolStripMenuItem.Enabled = true;
                }
                button3.Visible = false;
                textBox1.Text = null;
                textBox2.Text = null;
                textBox3.Text = null;
                textBox4.Text = null;
                textBox4.Visible = true;
                label4.Visible = true;
            }
        }

        public void CheckStudent()
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {

        }

        private void ñëåäóşToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private async void îòêğûòüÔàéëToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
        }

        private void ñîçäàòüÍîâûéÔàéëToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void ñîõğàíèòüÔàéëToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void ñëåäóşùèéToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void äîáàâèòüÑòóäåíòàToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void óäàëèòüÑòóäåíòàToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (students.Students.Count == 0)
                return;

            students.Students[currentStudent].FirstName = textBox1.Text;
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            if (students.Students.Count == 0)
                return;

            students.Students[currentStudent].Surname = textBox2.Text;
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            if (students.Students.Count == 0)
                return;

            students.Students[currentStudent].Faculty = textBox3.Text;
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            if (students.Students.Count == 0)
                return;

            students.Students[currentStudent].Education = textBox4.Text;
        }

        private void ñîçäàòüÍîâûéÔàéëToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            MessageBox.Show("Ñîçäàí ôàéë! Ïî óìîë÷àíèş ñîçäàí 1 ñòóäåíò-áàêàëàâğ. Äëÿ òîãî, ÷òîáû ïîïîëíèòü ñïèñîê, " +
                "äîáàâüòå ñòóäåíòà âî âêëàäêå: Ñòóäåíòû -> Äîáàâèòü ñòóäåíòà \nÄëÿ òîãî ÷òîáû ñäåëàòü ñòóäåíòà ìàãèñòğîì, íàæìèòå íà êíîïêó: Ñäåëàòü ìàãèñòğîì", 
                "Íîâûé ñïèñîê", MessageBoxButtons.OK, MessageBoxIcon.Information);
            students = new WorkWithStudents();
            currentStudent = 0;
            students.Students.Add(new Bachelor());
            EnableForm();
            ShowInfo();
            checkFirstLastOrNull();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            button3.Visible = false;
            label4.Visible = true;
            textBox4.Visible = true;
            textBox4.ReadOnly = false;
            var tmpFirstName = students.Students[currentStudent].FirstName;
            var tmpSurname = students.Students[currentStudent].Surname;
            var tmpFaculty = students.Students[currentStudent].Faculty;
            students.Students[currentStudent] = new GradStudent(tmpFirstName, tmpSurname, tmpFaculty, "");
            textBox4.Text = "";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            currentStudent++;
            ShowInfo();
            checkFirstLastOrNull();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            currentStudent--;
            ShowInfo();
            checkFirstLastOrNull();
        }

        private void äîáàâèòüÑòóäåíòàToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            if (currentStudent < students.Students.Count - 1)
            {
                currentStudent = students.Students.Count;
            } else
            {
                currentStudent++;
            }
            AddStudent();
            checkFirstLastOrNull();
        }

        private void óäàëèòüÑòóäåíòàToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            students.Students.RemoveAt(currentStudent);
            if (currentStudent > students.Students.Count - 1 && students.Students.Count != 0)
            {
                currentStudent = students.Students.Count - 1;
                checkFirstLastOrNull();
                ShowInfo();
            } else if (students.Students.Count == 0)
            {
                checkFirstLastOrNull();
                currentStudent = -1;
                textBox1.Text = "";
                textBox2.Text = "";
                textBox3.Text = "";
                textBox4.Text = "";
                textBox1.ReadOnly = true;
                textBox2.ReadOnly = true;
                textBox3.ReadOnly = true;
                textBox4.ReadOnly = true;
                button3.Visible = false;
                label4.Visible = false;
                textBox4.Visible = false;
                ñîõğàíèòüÔàéëToolStripMenuItem.Enabled = false;
            }
            else
            {
                checkFirstLastOrNull();
                ShowInfo();
            }
        }

        private void ñëåäóşToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            button1_Click(sender, e);
        }

        private void ñëåäóşùèéToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            button2_Click(sender, e);
        }

        private void ñîõğàíèòüÔàéëToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "XML ôàéëû(*.xml)|*.xml";
            saveFileDialog.FilterIndex = 1;
            saveFileDialog.RestoreDirectory = true;
            saveFileDialog.DefaultExt = ".xml";
            if (saveFileDialog.ShowDialog() == DialogResult.Cancel)
                return;
            FileStream writer = new FileStream(saveFileDialog.FileName, FileMode.Create);
            XmlSerializer serializer= new XmlSerializer(typeof(List<Student>));
            serializer.Serialize(writer, students.Students);
            writer.Close();
            MessageBox.Show("Ôàéë ñîõğàí¸í");
        }

        private void îòêğûòüÔàéëToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            students = new WorkWithStudents();
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "XML ôàéëû(*.xml)|*.xml";
            openFileDialog.FilterIndex = 1;
            openFileDialog.RestoreDirectory = true;
            if (openFileDialog.ShowDialog() == DialogResult.Cancel)
                return;
            try
            {
                FileStream reader = new FileStream(openFileDialog.FileName, FileMode.Open);
                XmlSerializer serializer = new XmlSerializer(typeof(List<Student>));
                students.Students = new List<Student>(serializer.Deserialize(reader) as List<Student>);
                reader.Close();
                currentStudent = 0;
                ShowInfo();
                checkFirstLastOrNull();
                EnableForm();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {
            if (textBox5.Text == "")
                return;
            if (students.Students.Count == 1) 
                return;
            string v = comboBox1.SelectedItem.ToString();
            string template = textBox5.Text;
            switch (v)
            {
                case "Èìÿ":
                    for (int i = 0; i < students.Students.Count; ++i)
                    {
                        if (students.Students[i].firstName != null) { 
                            if (students.Students[i].firstName.StartsWith(template))
                            {
                                currentStudent = i;
                                ShowInfo();
                            }
                        }
                    }
                    break;
                case "Ôàìèëèÿ":
                    for (int i = 0; i < students.Students.Count; ++i)
                    {
                        if (students.Students[i].Surname != null)
                        {
                            if (students.Students[i].Surname.StartsWith(template))
                            {
                                currentStudent = i;
                                ShowInfo();
                            }
                        }
                    }
                    break;
                case "Ôàêóëüòåò":
                    for (int i = 0; i < students.Students.Count; ++i)
                    {
                        if (students.Students[i].Faculty != null)
                        {
                            if (students.Students[i].Faculty.StartsWith(template))
                            {
                                currentStudent = i;
                                ShowInfo();
                            }
                        }
                    }
                    break;
                default:
                    break;
            }
        }

        private void comboBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            textBox5.ReadOnly = false;
        }

    }
}