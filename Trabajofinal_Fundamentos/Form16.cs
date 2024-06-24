using Entidades;
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
    public partial class Form16 : Form
    {
        nHabitacion hat = new nHabitacion();
        public Form16()
        {
            InitializeComponent();
        }

        private void Form16_Load(object sender, EventArgs e)
        {
            label1.BackColor = Color.Transparent;
            pictureBox1.BackColor = Color.Transparent;

            dataGridView1.DataSource =hat.ListarTodo();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 formulario1 = new Form1();

            formulario1.Show();

            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form3 formulario2 = new Form3();

            formulario2.Show();

            this.Close();
        }
    }
}
