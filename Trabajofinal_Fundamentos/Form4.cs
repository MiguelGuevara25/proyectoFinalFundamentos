using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Trabajofinal_Fundamentos
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 formualri1 = new Form1();

            formualri1.Show();

            this.Hide();
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            label1.BackColor = Color.Transparent;
            label3.BackColor = Color.Transparent;
            label2.BackColor = Color.Transparent;
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }
    }
}
