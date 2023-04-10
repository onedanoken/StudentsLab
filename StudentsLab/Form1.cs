using System.Text.Json;

namespace StudentsLab
{
    public partial class Form1 : Form
    {
        private List<Student> students;

        public Form1()
        {
            InitializeComponent();
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
            using (FileStream fs = new FileStream("file.json", FileMode.OpenOrCreate))
            {
                students = await JsonSerializer.DeserializeAsync<List<Student>>(fs);
            }
        }

        private void ñîçäàòüÍîâûéÔàéëToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (FileStream fs = new FileStream("file.json", FileMode.OpenOrCreate))
            {
                
            }
        }

        private void ñîõğàíèòüÔàéëToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (FileStream fs = new FileStream("file.json", FileMode.OpenOrCreate))
            {
                List<string> list = 
            }
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
    }
}