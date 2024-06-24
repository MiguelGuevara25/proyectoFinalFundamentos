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
    public partial class Form11 : Form
    {
        nReserva reser = new nReserva();

        public Form11()
        {
            InitializeComponent();
        }

        private void Form11_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = reser.MostrarResera(Conexion_forms.correo);
            label1.BackColor = Color.Transparent;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form5 formulario5 = new Form5();

            formulario5.Show();

            this.Close();
        }
    }
}
