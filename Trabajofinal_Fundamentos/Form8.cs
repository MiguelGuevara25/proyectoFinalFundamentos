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
        nUsuario user = new nUsuario();
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
                            eUsuario usuario = null;
                             usuario=user.Validar(Conexion_forms.correo);
                                
                                conexion.Close();
                                Conexion_forms.numero_personas = Conexion_forms.numero_personas + 1;

                            eExtra ex = new eExtra()
                            {
                                nombre = nombre.Text,
                                apellido_M=apellido_m.Text,
                                apellido_P=apellido_p.Text,
                                correo=correo.Text,
                                nacionalidad=nacionalidad.Text,
                                genero=genero.Text,
                                telefono= Convert.ToInt32(telefono.Text),
                                edad= Convert.ToInt32(edad.Text),
                                codigo_U=usuario.codigo_U

                            };


                            Conexion_forms.lista_extra.Add(ex);

                            this.Close();

                           
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

 

        private void Form8_Load(object sender, EventArgs e)
        {
            label1.BackColor = Color.Transparent;
            label2.BackColor = Color.Transparent;
            label4.BackColor = Color.Transparent;
            label6.BackColor = Color.Transparent;
            label11.BackColor = Color.Transparent;
            label10.BackColor = Color.Transparent;
            label9.BackColor = Color.Transparent;
            label7.BackColor = Color.Transparent;


     




        }
    }
}
