using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
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
            if (dataGridView1.SelectedRows.Count > 0)
            {
                DataGridViewRow filaSeleccionada = dataGridView1.SelectedRows[0];
                int espacios = Convert.ToInt32(filaSeleccionada.Cells["Espacios"].Value.ToString());

                if (Conexion_forms.numero_personas > espacios - 1)
                {
                    MessageBox.Show("Ya no puede poner más personas en esta reserva");
                    button1.Enabled = false;

                }
                else
                {
                    Form8 formulario8 = new Form8();

                    formulario8.Show();
                }
                

            }

                
        }

        private void Form7_Load(object sender, EventArgs e)
        {
            
            pictureBox2.BackColor = Color.Transparent;
            label1.BackColor = Color.Transparent;
            label3.BackColor = Color.Transparent;
            label2.BackColor = Color.Transparent;

            Conexion_forms.numero_personas = 0;
            Conexion_forms.lista_extra = new List<eExtra>();
            MostrarTabla();
        }

        public void MostrarTabla()
        {
            dataGridView1.DataSource = hat.listarDipon(Conexion_forms.tipo_de_habitacion, Conexion_forms.fecha);
        }

        private void button3_Click(object sender, EventArgs e)
        {


            if (Int32.TryParse(textBox1.Text,out Conexion_forms.tiempo_hospedaje))
            {
               
            }
            else
            {
                MessageBox.Show("Por favor, no olvide poner su tiempo de hospedaje o coloco mal el formato de número");
            }


            if (dataGridView1.SelectedRows.Count > 0)
            {
                Conexion_forms.tiempo_hospedaje = Convert.ToInt32(textBox1.Text);

                DataGridViewRow filaSeleccionada = dataGridView1.SelectedRows[0];

                int precio = Convert.ToInt32(filaSeleccionada.Cells["Precio"].Value.ToString());
                int order = Convert.ToInt32(filaSeleccionada.Cells["Orden"].Value.ToString());
                String tipo = filaSeleccionada.Cells["Tipo"].Value.ToString();

                string fecha_inicio = filaSeleccionada.Cells["Disponibilidad"].Value.ToString();

                String fecha = "";

                for (int i = 0; i < fecha_inicio.Length; i++)
                {
                    if (i == 19 && fecha_inicio[i] == ':')
                    {
                        fecha = fecha + " ";  // Reemplazar ':' en la posición 19 con un espacio en blanco
                    }
                    else
                    {
                        fecha = fecha + fecha_inicio[i];  // Conservar el carácter original
                    }
                }

                DateTime fecha_n = Convert.ToDateTime(fecha);

                Conexion_forms.precio = precio;
                Conexion_forms.orden = order;
                Conexion_forms.tipo_de_habitacion =tipo;
                Conexion_forms.fecha = fecha_n;

                if (Int32.TryParse(textBox1.Text, out Conexion_forms.tiempo_hospedaje))
                {
                    Form9 formulario9 = new Form9();

                    formulario9.Show();

                    this.Close();
                }
                else
                {
                    MessageBox.Show("Por favor, no olvide poner su tiempo de hospedaje o coloco mal el formato de número");
                }
              
            }
            else
            {
                MessageBox.Show("Por favor elija un opción de reserva");
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
