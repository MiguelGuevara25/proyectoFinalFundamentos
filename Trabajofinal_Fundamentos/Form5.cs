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
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        private void Form5_Load(object sender, EventArgs e)
        {
            label2.BackColor = Color.Transparent;
            label1.BackColor = Color.Transparent;
            pictureBox1.BackColor = Color.Transparent;

            Conexion_forms.numero_personas = 0;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form6 formulario6 = new Form6();

            formulario6.Show();

            this.Close();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form1 formulario1 = new Form1();

            formulario1.Show();

            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form10 formualario10 = new Form10();

            formualario10.Show();

            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form11 formulario11 = new Form11();

            formulario11.Show();

            this.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            Form18 formulario18 = new Form18();

            formulario18.Show();

            this.Close();
        }
    }
}
