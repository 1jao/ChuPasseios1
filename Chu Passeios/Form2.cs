﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Chu_Passeios
{
    public partial class Form2 : Form
    {
        //form2 é a primeira tela do site
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
            //este botão leva o usuário ao form3
        {
            Form3 form3 = new Form3();
            form3.Show(); 
        }

        private void btmforms2_Click(object sender, EventArgs e)
        //este botão leva o usuário ao form4
        {
            Form4 form4 = new Form4();
            form4.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        //este botão leva o usuário ao form1
        {
            Form1 form1 = new Form1();
            form1.Show();
        }
    }
}
