using Negocio;
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

namespace Trabajofinal_Fundamentos
{
    public partial class Form2 : Form
    {
        nUsuario user = new nUsuario();
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            panel1.BackColor = Color.FromArgb(128, 0, 0, 190);
            label1.BackColor = Color.Transparent;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (nombre.Text == "" || apellido_p.Text == "" || apellido_m.Text == "" || edad.Text == "" || genero.Text == "" || correo.Text == "" || nacionalidad.Text == "" || telefono.Text == "" || contrasena.Text == "")
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
                                if (contrasena.Text != vcontra.Text)
                                {
                                    MessageBox.Show("Validar contraseña es inválida. Por favor, que constraseña y validar sean iguales");
                                }
                                else
                                {
                                    user.RegistrarUser( nombre.Text, apellido_p.Text, apellido_m.Text, correo.Text, nacionalidad.Text, genero.Text, contrasena.Text, Convert.ToInt32(telefono.Text), Convert.ToInt32(edad.Text));
                                    conexion.Close();
                                }
                                conexion.Close();
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
            Form1 formulario1 = new Form1();

            formulario1.Show();

            this.Hide();
        }
    }
}
