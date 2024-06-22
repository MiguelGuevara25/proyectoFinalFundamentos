using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Entidades;
using Negocio;
namespace Trabajofinal_Fundamentos
{
    public partial class Form7 : Form
    {
        nHabitacion hat = new nHabitacion();
        
        public Form7()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();

            Form8 formulario8 = new Form8();

            formulario8.Show();
        }

        private void Form7_Load(object sender, EventArgs e)
        {
            MostrarTabla();
        }

        public void MostrarTabla()
        {
            dataGridView1.DataSource = hat.listarDipon(Conexion_forms.tipo_de_habitacion, Conexion_forms.fecha);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {

                DataGridViewRow filaSeleccionada = dataGridView1.SelectedRows[0];

                int precio = Convert.ToInt32(filaSeleccionada.Cells["Precio"].Value.ToString());
                int order = Convert.ToInt32(filaSeleccionada.Cells["Orden"].Value.ToString());
                String tipo = filaSeleccionada.Cells["Tipo"].Value.ToString();

                MessageBox.Show($"{order}, {precio}");

                Conexion_forms.precio = precio;
                Conexion_forms.orden = order;
                Conexion_forms.tipo_de_habitacion =tipo;

                Form9 formulario9 = new Form9();

                formulario9.Show();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form6 formualrio6 = new Form6();

            formualrio6.Show();

            this.Close();
        }
    }
}
