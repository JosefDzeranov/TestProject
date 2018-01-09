using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TestProjectApp
{
    public partial class FormQuestions : Form
    {
        string[] questions = new string[2];
        string[,] answer = new string[2,4];
        string[] rightanswer = new string[2];
        public FormQuestions()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void FormQuestions_Load(object sender, EventArgs e)
        {

        }

        private void yes_Click(object sender, EventArgs e)
        {
            
        }
    }
}
