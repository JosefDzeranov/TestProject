﻿using System;
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
            if (textBox1.Text == "" && textBox2.Text == "")
            {
                MessageBox.Show("Поля не должны быть пустыми");
            }
            else
            {
                string lastName = textBox1.Text;
                string firstName = textBox2.Text;
                Program.usernames.Add(new string[2] { lastName, firstName });
                FormQuestions formquest = new FormQuestions();
                formquest.Show();
                this.Visible = false;
            }
            
        }
    }
}
