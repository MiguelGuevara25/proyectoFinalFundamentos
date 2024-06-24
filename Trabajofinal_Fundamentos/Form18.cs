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
using Entidades;
namespace Trabajofinal_Fundamentos
{
    public partial class Form18 : Form
    {
        nUsuario usuario = new nUsuario();
        eUsuario user=null;
        
        public Form18()
        {
            InitializeComponent();
            
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void Form18_Load(object sender, EventArgs e)
        {
            panel1.BackColor = Color.FromArgb(128, 0, 0, 190);

            user = usuario.Validar(Conexion_forms.correo);

            label8.Text = user.nombre;
            label9.Text = user.apellido_P+"  " + user.apellido_M;
            label10.Text = $"{user.edad}";
            label11.Text = user.genero;
            label12.Text = user.nacionalidad;
            label13.Text = user.correo;
            label14.Text = $"{user.telefono}";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form5 formulario5 = new Form5();

            formulario5.Show();

            this.Close();
        }
    }
}
