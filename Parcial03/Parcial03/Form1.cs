using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Parcial03
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string usuario,pass;
            
            usuario = textBox1.Text;
            pass = textBox2.Text;

            if (usuario=="UTEC" && pass=="programacion01")
            {
                Form2 obj1 = new Form2();
                for (int i=1; i>=24;i++)
                {
                    progressBar1.Step = i;
                }
            }
            else
            {
                MessageBox.Show("INTENTE NUEVAMENTE");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void progressBar1_Click(object sender, EventArgs e)
        {
            
        }
    }
}
