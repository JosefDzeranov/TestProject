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
    public partial class Author : Form
    {
        public Author()
        {
            InitializeComponent();
        }

        private void Author_Load(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "Иосиф" && textBox2.Text == "Дзеранов")
            {
                MessageBox.Show("Успешная авторизация!");
                this.Close();
            }
            else
            {
                MessageBox.Show("Неверные данные!");
                this.Close();
            }
        }
    }
}
