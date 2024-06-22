using Entidades;
using Negocio;
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
    public partial class Form14 : Form
    {
        nReserva reser = new nReserva();
        nServicios_adicional server = new nServicios_adicional();
        public Form14()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form5 formulario5 = new Form5();

            formulario5.Show();

            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form10 formulario10 = new Form10();

            formulario10.Show();

            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if(Conexion_forms.Stipo_pago=="CREDITO" || Conexion_forms.Stipo_pago == "DEBITO")
            {
                eReserva reserva;
                reserva=reser.UltimaReserva(Conexion_forms.correo);



                server.InsertarServicioAdicional(reserva,Conexion_forms.orden);

                MessageBox.Show("Felidades a Reservado correctamente");


            }
            else
            {
                if(Conexion_forms.Stipo_pago=="CONTADO")
                {


                    Form17 formulario = new Form17();

                    formulario.Show();

                    this.Close();
                }
            }
        }
    }
}
