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
         


            if (comboBox1.SelectedItem != null)
            {
                String elemento_seleccion = comboBox1.SelectedItem.ToString();
                dataGridView1.DataSource = servis.listar(elemento_seleccion);
            }
            else
            {
                MessageBox.Show("Por Favor, elija una opción de tipo");
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


                
                String tipo_servicio = filaSeleccionada.Cells["Tipo_servicio"].Value.ToString();
                int numero_servico = Convert.ToInt32(filaSeleccionada.Cells["numero_servicio"].Value.ToString());

               

                MessageBox.Show($"{monto}");

                Conexion_forms.orden = orden;
                Conexion_forms.precio_Ser = monto;
                Conexion_forms.Stipo_pago = comboBox2.SelectedItem.ToString();
                Conexion_forms.tipo_de_servicio = tipo_servicio;
                Conexion_forms.numero_servico = numero_servico;

                if(Conexion_forms.Stipo_pago=="CONTADO")
                {
                    Form12 formulario12 = new Form12();

                    formulario12.Show();

                    this.Close();
                }
                else
                {
                    if(Conexion_forms.Stipo_pago=="CREDITO" || Conexion_forms.Stipo_pago=="DEBITO")
                    {
                        Form14 form = new Form14();

                        form.Show();

                        this.Close();
                    }
                }
               

            }
            else
            {
                MessageBox.Show("Por favor, seleccione una fila");
            }

           

           
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
