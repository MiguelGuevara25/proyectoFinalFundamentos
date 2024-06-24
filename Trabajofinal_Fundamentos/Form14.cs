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
        nPagos pago = new nPagos();
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

            MessageBox.Show(Conexion_forms.Stipo_pago);
          
            if (Conexion_forms.Stipo_pago == "CREDITO" || Conexion_forms.Stipo_pago == "DEBITO")
            {
                eReserva reserva;
                int id_pago = 0;
                if (Conexion_forms.Stipo_pago == "CREDITO")
                {
                    id_pago = 2;
                }
                else
                {
                    if (Conexion_forms.Stipo_pago == "DEBITO")
                    {
                        id_pago = 3;
                    }

                }

                DateTime fecha = DateTime.Today;
                pago.RegistrarPago(pago.idMayor(), Conexion_forms.precio_Ser, fecha, "PAGADO", id_pago, 4);

                reserva = reser.UltimaReserva(Conexion_forms.correo);



                server.InsertarServicioAdicional(reserva, Conexion_forms.orden);


                server.actualizarEstado(Conexion_forms.orden);
                MessageBox.Show("Felidades a Reservado correctamente");

                Form5 formulario5 = new Form5();

                formulario5.Show();

                this.Close();


            }
            else
            {
                if (Conexion_forms.Stipo_pago == "CONTADO")
                {
                    
                        int id_pago = 1;
                      
                        DateTime fecha = DateTime.Today;
                        pago.RegistrarPago(pago.idMayor(), Conexion_forms.precio_Ser, fecha, "VIGENTE", id_pago, 4);


                        Form17 formulario = new Form17();

                        formulario.Show();

                        this.Close();
                    
                }
            }
        }
    }
}
