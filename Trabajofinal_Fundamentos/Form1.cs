using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Negocio;

namespace Trabajofinal_Fundamentos
{
    public partial class Form1 : Form
    {
        nDisponibilidad dispon=new nDisponibilidad();
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
            
            dispon.ActualizarInicio();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 formulario2 = new Form2();

            formulario2.Show();

            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
            Form3 formulario3 = new Form3();

            formulario3.Show();

            this.Hide();

            
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form16 formulario = new Form16();

            formulario.Show();

            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form4 formulario4 = new Form4();

            formulario4.Show();

            this.Hide();
        }
    }
}
