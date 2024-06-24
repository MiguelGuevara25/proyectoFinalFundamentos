using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Trabajofinal_Fundamentos
{
    public partial class Form13 : Form
    {
        public Form13()
        {
            InitializeComponent();
        }

        private void Form13_Load(object sender, EventArgs e)
        {
            label6.Text = $"{Conexion_forms.tipo_de_habitacion}";
            label7.Text = $"{Conexion_forms.numero_personas}";

            DateTime fecha = Conexion_forms.fecha;
            DateTime fecha_fin=fecha.AddDays(Conexion_forms.tiempo_hospedaje);
            label8.Text = $"{Conexion_forms.fecha}-{fecha_fin}";

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form5 formulario5 = new Form5();

            formulario5.Show();

            this.Close();
        }
    }
}
