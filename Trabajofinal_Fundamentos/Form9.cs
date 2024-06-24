using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

using Negocio;
using Entidades;

namespace Trabajofinal_Fundamentos
{
    public partial class Form9 : Form
    {
        nPagos pagos = new nPagos();
        ePagos page = new ePagos();
        nReserva reser = new nReserva();
        nUsuario usuario = new nUsuario();
        eUsuario user = new eUsuario();
        nDisponibilidad dispo = new nDisponibilidad();
        nExtra extra = new nExtra();
        nHabitacion hat = new nHabitacion();
        string tipo_pago;

       
        public Form9()
        {
            InitializeComponent();
            textBox4.PasswordChar = '*';
            
        }

        private void Form9_Load(object sender, EventArgs e)
        {
            label1.Hide();
            label2.Hide();
            label4.Hide();
            label3.Hide();
            textBox2.Hide();
            textBox3.Hide();
            textBox4.Hide();

            int precio = Conexion_forms.tiempo_hospedaje * Conexion_forms.precio;

            label11.Text = $"{precio} $";
            label12.Text = $"{Conexion_forms.tipo_de_habitacion}";
            label10.Text = $"{Conexion_forms.numero_personas}";
            label13.Text = $"{Conexion_forms.orden}";

            label11.BackColor = Color.Transparent;
            label12.BackColor = Color.Transparent;
            label10.BackColor = Color.Transparent;
            label13.BackColor = Color.Transparent;

            label5.BackColor = Color.Transparent;
            label7.BackColor = Color.Transparent;
            label9.BackColor = Color.Transparent;
            label8.BackColor = Color.Transparent;




        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
             tipo_pago = comboBox1.SelectedItem.ToString();

            if(tipo_pago=="CREDITO" || tipo_pago=="DEBITO")
            {
                label1.Visible = true;

                label2.Visible=true;
                label4.Visible=true;
                label3.Visible=true;
                textBox2.Visible=true;
                textBox3.Visible=true;
                textBox4.Visible=true;
            }
            else
            {
                if(tipo_pago=="CONTADO")
                {
                    label1.Hide();
                    label2.Hide();
                    label4.Hide();
                    label3.Hide();
                    textBox2.Hide();
                    textBox3.Hide();
                    textBox4.Hide();
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            DateTime fechaHoy = DateTime.Today;


            int id = 0;
            string cadena = "";
            if(tipo_pago=="CONTADO")
            {
                id = 1;
                cadena = "VIGENTE";
            }
            else
            {
                if(tipo_pago == "CREDITO")
                {
                    id = 2;

                    cadena = "PAGADO";
                }
                else
                {
                    if(tipo_pago == "DEBITO")
                    {
                        id = 3;

                        cadena = "PAGADO";
                    }
                }
            }

            if (cadena=="PAGADO")
            {
                DateTime fecha = DateTime.Today;
                int pago_id = pagos.idMayor();
                int precio = Conexion_forms.precio * Conexion_forms.tiempo_hospedaje;
                string mensaje=pagos.RegistrarPago(pago_id, precio, fecha, cadena, id, 4);


                MessageBox.Show(mensaje);

                user = usuario.Validar(Conexion_forms.correo);

                if (Conexion_forms.lista_extra.Count>0)
                {
                    foreach (eExtra i in Conexion_forms.lista_extra)
                    {

                        extra.RegistrarUser(i.nombre, i.apellido_P, i.apellido_M, i.correo, i.nacionalidad, i.genero, i.telefono, i.edad, i.codigo_U);
                    }
                }

                int ha_id=hat.getId(Conexion_forms.orden);
                reser.RegistrarReserva(Conexion_forms.tiempo_hospedaje,fecha,user.codigo_U,pago_id,ha_id);

                dispo.ActualizarReserva(Conexion_forms.tiempo_hospedaje,Conexion_forms.orden);


                
                Form13 formulario13 = new Form13();
                formulario13.Show();

                this.Close();


            }
            else
            {
                if(cadena=="VIGENTE")
                {

                    DateTime fecha = fechaHoy.AddDays(1);
                    int pago_id = pagos.idMayor();
                   string mensaje= pagos.RegistrarPago(pago_id, Conexion_forms.precio, fecha, cadena, id, 4);
                    
                    MessageBox.Show(mensaje);
                    user = usuario.Validar(Conexion_forms.correo);
                    int ha_id = hat.getId(Conexion_forms.orden);

                    MessageBox.Show($"Fanjar: {pagos.idMayor()}");
                   

                    Form12 formulario12 = new Form12();
                    formulario12.Show();

                    this.Close();
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
            Form8 formualario8 = new Form8();

            formualario8.Show();

            this.Close();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            textBox4.PasswordChar = '*';
            pictureBox4.Hide();
            pictureBox3.Show();

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            textBox4.PasswordChar = '\0';

            pictureBox3.Hide();
            pictureBox4.Show();
        }
    }
}
