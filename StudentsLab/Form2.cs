using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentsLab
{
    public partial class Form2 : Form
    {
        private int result = 0;

        public int Result 
        {
            get { return this.result; }
            set { this.result = value; }
        }
        public Form2()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            result = 1;
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            result = 2;
            this.Close();
        }
    }
}
