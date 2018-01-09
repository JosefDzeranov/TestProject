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
             
        public FormQuestions()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void FormQuestions_Load(object sender, EventArgs e)
        {
            textBox1.Text = Program.questions[0];
            textBox2.Text = Program.questions[1];
        }


        private void button2_Click(object sender, EventArgs e)
        {
            Program.hisanswer[0] = Program.answer[0, 1];
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Program.hisanswer[0] = Program.answer[0,0];
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Program.hisanswer[0] = Program.answer[0, 2];
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Program.hisanswer[0] = Program.answer[0, 3];
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Program.hisanswer[1] = Program.answer[1, 0];
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Program.hisanswer[1] = Program.answer[1, 1];
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Program.hisanswer[1] = Program.answer[1, 2];
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Program.hisanswer[1] = Program.answer[1, 3];
        }

        private void button9_Click(object sender, EventArgs e)
        {
            new Result().Show();
        }
    }
}
