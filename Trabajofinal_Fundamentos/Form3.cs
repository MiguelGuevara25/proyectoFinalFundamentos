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
    public partial class Form3 : Form
    {
        eUsuario usuario=new eUsuario();
        nUsuario nuario=new nUsuario();
        nDisponibilidad dipon = new nDisponibilidad();
        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            label2.BackColor = Color.Transparent;
            label3.BackColor = Color.Transparent;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Conexion_forms.correo = textBox1.Text;
            //Error en esta parte del código arreglar
            usuario = nuario.Validar(textBox1.Text);

            try
            { 
                if (usuario.correo == null)
                {
                    MessageBox.Show("Correo no encontrado");

                }
                else
                {
                    if (usuario.contrasena != textBox2.Text)
                    {
                        MessageBox.Show("Contraseña incorrecta");
                    }
                    else
                    {
                        MessageBox.Show("Bienvenido Usuario");
                        Conexion_forms.correo = usuario.correo;

                        dipon.Liberar();

                        Form5 formulario5 = new Form5();
                        formulario5.Show();

                        this.Close();
                    }
                }

            }catch(NullReferenceException)
            {
                MessageBox.Show("No se encuentra el correo");
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 formulario1 = new Form1();

            formulario1.Show();

            this.Hide();
        }
    }
}
