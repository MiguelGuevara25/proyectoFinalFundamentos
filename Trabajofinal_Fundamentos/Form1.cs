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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            label1.BackColor = Color.Transparent;
            label2.BackColor = Color.Transparent;
            label3.BackColor = Color.Transparent;
            pictureBox1.BackColor = Color.Transparent;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 formulario2 = new Form2();

            formulario2.Show();

            this.Hide();
        }
    }
}
