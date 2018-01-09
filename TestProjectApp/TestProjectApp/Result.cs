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
    public partial class Result : Form
    {
        public Result()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Result_Load(object sender, EventArgs e)
        {
            int rightAnswerCount = 0;
            for (int i = 0; i < Program.numberOfQuestions; i++)
            {
                listBox1.Items.Add(i.ToString() + " " + Program.rightanswer[i] + " : " + Program.hisanswer[i]);
                if (Program.rightanswer[i] == Program.hisanswer[i]) 
                {
                    rightAnswerCount++; 
                }
            }
            label2.Text ="Кол-во правильных ответов: " + rightAnswerCount.ToString(); 
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
