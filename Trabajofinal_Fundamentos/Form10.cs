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
    public partial class Form10 : Form
    {
        nServicios_adicional servis = new nServicios_adicional();
        public Form10()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form5 formulario5 = new Form5();

            formulario5.Show();

            this.Close();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            String elemento_seleccion = comboBox1.SelectedItem.ToString();


            if (comboBox1.SelectedItem != null)
            {
                dataGridView1.DataSource = servis.listar(elemento_seleccion);
            }


        }

        private void Form10_Load(object sender, EventArgs e)
        {
            label1.BackColor = Color.Transparent;
            label2.BackColor = Color.Transparent;
            label3.BackColor = Color.Transparent;
        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (dataGridView1.SelectedRows.Count > 0)
            {

                DataGridViewRow filaSeleccionada = dataGridView1.SelectedRows[0];

                int orden = Convert.ToInt32(filaSeleccionada.Cells["Orden"].Value.ToString());
                int monto = Convert.ToInt32(filaSeleccionada.Cells["Precio"].Value.ToString());

                MessageBox.Show($"{monto}");

                Conexion_forms.orden = orden;
                Conexion_forms.precio_Ser = monto;
                Conexion_forms.Stipo_pago = comboBox2.SelectedItem.ToString();

                Form14 form = new Form14();

                form.Show();

                this.Close();

            }

           
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
