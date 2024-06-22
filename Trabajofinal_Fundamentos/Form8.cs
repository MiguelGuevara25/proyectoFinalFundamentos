using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades;
using Negocio;

namespace Trabajofinal_Fundamentos
{
    public partial class Form8 : Form
    {
        nExtra extra = new nExtra();
        public Form8()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (nombre.Text == "" || apellido_p.Text == "" || apellido_m.Text == "" || edad.Text == "" || genero.Text == "" || correo.Text == "" || nacionalidad.Text == "" || telefono.Text == "")
            {
                MessageBox.Show("Por favor, rellene los cuadros faltantes");

            }
            else
            {
                if (!(edad.Text.All(char.IsDigit) && telefono.Text.All(char.IsDigit)))
                {
                    MessageBox.Show("Teléfono y edad inválidos");

                }
                else
                {
                    if (Convert.ToInt32(edad.Text) < 18)
                    {
                        MessageBox.Show("Es menor de edad");

                    }
                    else
                    {
                        SqlConnection conexion;
                        conexion = new SqlConnection("Data Source=.;Initial Catalog=HotelBooking;Integrated Security=True;");
                        conexion.Open();
                        string query = "SELECT COUNT(*) FROM Usuario WHERE correo = @correoBuscar";


                        SqlCommand command = new SqlCommand(query, conexion);

                        command.Parameters.AddWithValue("@correoBuscar", correo.Text);

                        try
                        {

                            int count = (int)command.ExecuteScalar();

                            if (count != 0)
                            {
                                MessageBox.Show("El correo electrónico ya esta registrado en el sistema. Por favor, verifique sus datos");
                                conexion.Close();



                            }
                            else
                            {
                                
                                    extra.RegistrarUser(nombre.Text, apellido_p.Text, apellido_m.Text, correo.Text, nacionalidad.Text, genero.Text, Convert.ToInt32(telefono.Text), Convert.ToInt32(edad.Text));
                                    conexion.Close();
                                Conexion_forms.numero_personas = Conexion_forms.numero_personas + 1;
                           
                            }
                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine($"Error al intentar verificar la presencia del elemento en la base de datos: {ex.Message}");
                            conexion.Close();
                        }
                    }
                }
            }

            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form7 formulario7 = new Form7();

            formulario7.Show();

            this.Close();
        }
    }
}
