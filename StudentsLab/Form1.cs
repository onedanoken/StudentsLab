using System.Runtime.InteropServices;
using System.Text.Json;
using System.Xml.Serialization;

namespace StudentsLab
{
    public partial class Form1 : Form
    {
        WorkWithStudents students;
        int currentStudent = 0; // ������� �������
        List<int> indexes = new List<int>(); // ���� �������� (��� ������ 7)
        int index = 0;

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
            ����������������ToolStripMenuItem.Enabled = true;
            ���������������ToolStripMenuItem.Enabled = true;
            // ����������������ToolStripMenuItem.Enabled = false;
            �������������ToolStripMenuItem.Enabled = true;
            comboBox1.Enabled = true;
        }

        public void NoStudent()
        {
            textBox1.ReadOnly = true;
            textBox2.ReadOnly = true;
            textBox3.ReadOnly = true;
            textBox4.ReadOnly = true;
            label4.Visible = false;
            textBox4.Visible = false;
            ������ToolStripMenuItem.Enabled = false;
            ���������ToolStripMenuItem.Enabled = false;
            button1.Enabled = false;
            button2.Enabled = false;
        }

        public void checkFirstLastOrNull(int count)
        {
            if (count > 0)
            {
                if (index == 0)
                {
                    button1.Enabled = false;
                    ������ToolStripMenuItem.Enabled = false;
                }
                else
                {
                    button1.Enabled = true;
                    ������ToolStripMenuItem.Enabled = true;
                }
                if (index == count - 1)
                {
                    button2.Enabled = false;
                    ���������ToolStripMenuItem.Enabled = false;
                }
                else
                {
                    button2.Enabled = true;
                    ���������ToolStripMenuItem.Enabled = true;
                }
            }
            else if (count == 0 || count == null)
            {
                button1.Enabled = false;
                button2.Enabled = false;
                ������ToolStripMenuItem.Enabled = false; // ����������)
                ���������ToolStripMenuItem.Enabled = false;
                ���������������ToolStripMenuItem.Enabled = false;
            }
        }

        public bool AddStudent()
        {
            Form2 f = new Form2();
            f.ShowDialog();
            int result = f.Result;
            if (result == 1)
            {
                indexes.Add(students.Students.Count);
                students.Students.Add(new Bachelor());
                index = students.Students.Count - 1;
                if (students.Students.Count == 1)
                {
                    textBox1.ReadOnly = false;
                    textBox2.ReadOnly = false;
                    textBox3.ReadOnly = false;
                    textBox4.ReadOnly = false;
                    ���������������ToolStripMenuItem.Enabled = true;
                    �������������ToolStripMenuItem.Enabled = true;
                }
                button3.Visible = true;
                currentStudent = indexes[index];
                textBox1.Text = null;
                textBox2.Text = null;
                textBox3.Text = null;
                textBox4.Text = null;
                textBox4.Visible = false;
                label4.Visible = false;
                checkFirstLastOrNull(indexes.Count);
                return true;
            }
            else if (result == 2)
            {
                indexes.Add(students.Students.Count);
                students.Students.Add(new GradStudent());
                index = students.Students.Count - 1;
                if (students.Students.Count == 1)
                {
                    textBox1.ReadOnly = false;
                    textBox2.ReadOnly = false;
                    textBox3.ReadOnly = false;
                    textBox4.ReadOnly = false;
                    ���������������ToolStripMenuItem.Enabled = true;
                    �������������ToolStripMenuItem.Enabled = true;
                }
                button3.Visible = false;
                currentStudent = indexes[index];
                textBox1.Text = null;
                textBox2.Text = null;
                textBox3.Text = null;
                textBox4.Text = null;
                textBox4.Visible = true;
                label4.Visible = true;
                checkFirstLastOrNull(indexes.Count);
                return true;
            }
            else
                return false;
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

        private void ������ToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private async void �����������ToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void ����������������ToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void �������������ToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void ���������ToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void ����������������ToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void ���������������ToolStripMenuItem_Click(object sender, EventArgs e)
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

        private void ����������������ToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            MessageBox.Show("������ ����! �� ��������� ������ 1 �������-��������. ��� ����, ����� ��������� ������, " +
                "�������� �������� �� �������: �������� -> �������� �������� \n��� ���� ����� ������� �������� ���������, ������� �� ������: ������� ���������",
                "����� ������", MessageBoxButtons.OK, MessageBoxIcon.Information);
            students = new WorkWithStudents();
            indexes = new List<int>();
            students.Students.Add(new Bachelor());
            indexes.Add(0);
            currentStudent = indexes[index];
            EnableForm();
            ShowInfo();
            checkFirstLastOrNull(students.Students.Count);
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
            index++;
            currentStudent = indexes[index];
            ShowInfo();
            checkFirstLastOrNull(indexes.Count);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            index--;
            currentStudent = indexes[index];
            ShowInfo();
            checkFirstLastOrNull(indexes.Count);
        }

        private void ����������������ToolStripMenuItem_Click_1(object sender, EventArgs e)
        {

            AddStudent();
            currentStudent = indexes[index];
            checkFirstLastOrNull(indexes.Count);
        }

        private void ���������������ToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            students.Students.RemoveAt(currentStudent);
            indexes.Remove(currentStudent);
            if (index > students.Students.Count - 1 && indexes.Count != 0)
            {
                index = students.Students.Count - 1;
                currentStudent = indexes[index];
                checkFirstLastOrNull(indexes.Count);
                ShowInfo();
            }
            else if (students.Students.Count == 0)
            {
                checkFirstLastOrNull(indexes.Count);
                index = -1;
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
                �������������ToolStripMenuItem.Enabled = false;
                comboBox1.Enabled = false;
                textBox5.Enabled = false;
            }
            else
            {
                checkFirstLastOrNull(indexes.Count);
                ShowInfo();
            }
        }

        private void ������ToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            button1_Click(sender, e);
        }

        private void ���������ToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            button2_Click(sender, e);
        }

        private void �������������ToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "XML �����(*.xml)|*.xml";
            saveFileDialog.FilterIndex = 1;
            saveFileDialog.RestoreDirectory = true;
            saveFileDialog.DefaultExt = ".xml";
            if (saveFileDialog.ShowDialog() == DialogResult.Cancel)
                return;
            FileStream writer = new FileStream(saveFileDialog.FileName, FileMode.Create);
            XmlSerializer serializer = new XmlSerializer(typeof(List<Student>));
            serializer.Serialize(writer, students.Students);
            writer.Close();
            MessageBox.Show("���� �������");
        }

        private void �����������ToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            students = new WorkWithStudents();
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "XML �����(*.xml)|*.xml";
            openFileDialog.FilterIndex = 1;
            openFileDialog.RestoreDirectory = true;
            if (openFileDialog.ShowDialog() == DialogResult.Cancel)
                return;
            try
            {
                FileStream reader = new FileStream(openFileDialog.FileName, FileMode.Open);
                XmlSerializer serializer = new XmlSerializer(typeof(List<Student>));
                students.Students = new List<Student>(serializer.Deserialize(reader) as List<Student>);
                indexes = new List<int>();
                for (int i = 0; i < students.Students.Count; i++)
                {
                    indexes.Add(i);
                }
                reader.Close();
                index = 0;
                currentStudent = indexes[index];
                ShowInfo();
                checkFirstLastOrNull(indexes.Count());
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
            {
                indexes = new List<int>();
                for (int i = 0; i < students.Students.Count(); ++i)
                {
                    indexes.Add(i);
                }
                index = currentStudent;
                currentStudent = indexes[index];
                checkFirstLastOrNull(indexes.Count);
                return;
            }

            if (students.Students.Count == 1)
                return;
            string v = comboBox1.SelectedItem.ToString();
            string template = textBox5.Text;
            indexes = new List<int>();
            switch (v)
            {
                case "���":
                    for (int i = 0; i < students.Students.Count; ++i)
                    {
                        if (students.Students[i].firstName != null)
                        {
                            if (students.Students[i].firstName.StartsWith(template))
                            {
                                indexes.Add(i);
                            }
                        }
                    }
                    if (indexes.Count == 0)
                    {
                        NoStudent();
                    }
                    else
                    {
                        index = 0;
                        currentStudent = indexes[index];
                        ShowInfo();
                        checkFirstLastOrNull(indexes.Count);
                        return;
                    }
                    break;
                case "�������":
                    for (int i = 0; i < students.Students.Count; ++i)
                    {
                        if (students.Students[i].Surname != null)
                        {
                            if (students.Students[i].Surname.StartsWith(template))
                            {
                                indexes.Add(i);
                            }
                        }
                    }
                    if (indexes.Count == 0)
                    {
                        NoStudent();
                        return;
                    }
                    else
                    {
                        index = 0;
                        currentStudent = indexes[index];
                        ShowInfo();
                        checkFirstLastOrNull(indexes.Count);
                        return;
                    }
                    break;
                case "���������":
                    for (int i = 0; i < students.Students.Count; ++i)
                    {
                        if (students.Students[i].Faculty != null)
                        {
                            if (students.Students[i].Faculty.StartsWith(template))
                            {
                                indexes.Add(i);
                            }
                        }
                    }
                    if (indexes.Count == 0)
                    {
                        NoStudent();
                        return;
                    }
                    else
                    {
                        index = 0;
                        currentStudent = indexes[index];
                        ShowInfo();
                        checkFirstLastOrNull(indexes.Count);
                        return;
                    }
                    break;
                default:
                    for (int i = 0; i < students.Students.Count; ++i)
                    {
                        if (students.Students[i].Education != null)
                        {
                            if (students.Students[i].Education.StartsWith(template))
                            {
                                indexes.Add(i);
                            }
                        }
                    }
                    if (indexes.Count == 0)
                    {
                        NoStudent();
                    }
                    else
                    {
                        index = 0;
                        currentStudent = indexes[index];
                        ShowInfo();
                        checkFirstLastOrNull(indexes.Count);
                        return;
                    }
                    break;
            }
        }

        private void comboBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            textBox5.ReadOnly = false;
        }

    }
}