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
    public partial class Form6 : Form
    {
        string eleccion;
        public Form6()
        {
            InitializeComponent();

            this.button3.MouseEnter += new System.EventHandler(this.button3_MouseEnter);
            this.button3.MouseLeave += new System.EventHandler(this.button3_MouseLeave);

            this.button4.MouseEnter += new System.EventHandler(this.button4_MouseEnter);
            this.button4.MouseLeave += new System.EventHandler(this.button4_MouseLeave);

            this.button5.MouseEnter += new System.EventHandler(this.button5_MouseEnter);
            this.button5.MouseLeave += new System.EventHandler(this.button5_MouseLeave);

            this.button6.MouseEnter += new System.EventHandler(this.button6_MouseEnter);
            this.button6.MouseLeave += new System.EventHandler(this.button6_MouseLeave);

            this.button7.MouseEnter += new System.EventHandler(this.button7_MouseEnter);
            this.button7.MouseLeave += new System.EventHandler(this.button7_MouseLeave);

            this.button8.MouseEnter += new System.EventHandler(this.button8_MouseEnter);
            this.button8.MouseLeave += new System.EventHandler(this.button8_MouseLeave);

            this.button9.MouseEnter += new System.EventHandler(this.button9_MouseEnter);
            this.button9.MouseLeave += new System.EventHandler(this.button9_MouseLeave);

            this.button10.MouseEnter += new System.EventHandler(this.button10_MouseEnter);
            this.button10.MouseLeave += new System.EventHandler(this.button10_MouseLeave);

           
        }

        private void button3_MouseEnter(object sender, EventArgs e)
        {
            // Código a ejecutar cuando el mouse entra en el botón
            this.button3.BackColor = Color.LightBlue; 

            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;

            pictureBox1.Image = Properties.Resources.Estandar;
           
            
        }

        private void button3_MouseLeave(object sender, EventArgs e)
        {
            // Código a ejecutar cuando el mouse sale del botón
            this.button3.BackColor = SystemColors.Control; 
            pictureBox1.Image = null;

        }

        private void button4_MouseEnter(object sender, EventArgs e)
        {
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            // Código a ejecutar cuando el mouse entra en el botón
            this.button3.BackColor = Color.LightBlue; 
            pictureBox1.Image = Properties.Resources.doble;
        }

        private void button4_MouseLeave(object sender, EventArgs e)
        {
            // Código a ejecutar cuando el mouse sale del botón
            this.button4.BackColor = SystemColors.Control; 
            pictureBox1.Image = null;

        }

        private void button5_MouseEnter(object sender, EventArgs e)
        {
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            // Código a ejecutar cuando el mouse entra en el botón
            this.button5.BackColor = Color.LightBlue; // Cambiar color de fondo del botón
           
            pictureBox1.Image = Properties.Resources.suite;
        }

        private void button5_MouseLeave(object sender, EventArgs e)
        {
            // Código a ejecutar cuando el mouse sale del botón
            this.button5.BackColor = SystemColors.Control;
            pictureBox1.Image = null;

        }

        private void button6_MouseEnter(object sender, EventArgs e)
        {
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            // Código a ejecutar cuando el mouse entra en el botón
            this.button6.BackColor = Color.LightBlue; // Cambiar color de fondo del botón
            pictureBox1.Image = Properties.Resources.Familiar;
        }

        private void button6_MouseLeave(object sender, EventArgs e)
        {
            // Código a ejecutar cuando el mouse sale del botón
            this.button6.BackColor = SystemColors.Control;
            pictureBox1.Image = null;

        }

        private void button7_MouseEnter(object sender, EventArgs e)
        {
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            // Código a ejecutar cuando el mouse entra en el botón
            this.button7.BackColor = Color.LightBlue; // Cambiar color de fondo del botón

            
            pictureBox1.Image = Properties.Resources.Ejecutiva;
        }

        private void button7_MouseLeave(object sender, EventArgs e)
        {
            // Código a ejecutar cuando el mouse sale del botón
            this.button7.BackColor = SystemColors.Control;
            pictureBox1.Image = null;

        }

        private void button8_MouseEnter(object sender, EventArgs e)
        {
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            // Código a ejecutar cuando el mouse entra en el botón
            this.button8.BackColor = Color.LightBlue; // Cambiar color de fondo del botón
           
            pictureBox1.Image = Properties.Resources.Deluxe;
        }

        private void button8_MouseLeave(object sender, EventArgs e)
        {
            // Código a ejecutar cuando el mouse sale del botón
            this.button8.BackColor = SystemColors.Control;
            pictureBox1.Image = null;

        }

        private void button9_MouseEnter(object sender, EventArgs e)
        {
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            // Código a ejecutar cuando el mouse entra en el botón
            this.button9.BackColor = Color.LightBlue; // Cambiar color de fondo del botón
            pictureBox1.Image = Properties.Resources.Queen;
        }

        private void button9_MouseLeave(object sender, EventArgs e)
        {
            // Código a ejecutar cuando el mouse sale del botón
            this.button9.BackColor = SystemColors.Control;
            pictureBox1.Image = null;

        }

        private void button10_MouseEnter(object sender, EventArgs e)
        {
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            // Código a ejecutar cuando el mouse entra en el botón
            this.button10.BackColor = Color.LightBlue; // Cambiar color de fondo del botó
            pictureBox1.Image = Properties.Resources.Estandar;
        }

        private void button10_MouseLeave(object sender, EventArgs e)
        {
            // Código a ejecutar cuando el mouse sale del botón
            this.button10.BackColor = SystemColors.Control;
            pictureBox1.Image = null;

        }

        private void button9_Click(object sender, EventArgs e)
        {
            eleccion = "QUEEN";
        }



        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            eleccion ="ESTANDAR";
        }

        private void Form6_Load(object sender, EventArgs e)
        {
            Conexion_forms.tipo_de_habitacion = "ESTANDAR";
            Conexion_forms.fecha = DateTime.Today;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Conexion_forms.fecha = monthCalendar1.SelectionStart;


            MessageBox.Show(Conexion_forms.tipo_de_habitacion);
            if (Conexion_forms.tipo_de_habitacion!="" )
            {
                Conexion_forms.tipo_de_habitacion = eleccion;
                if (Conexion_forms.fecha<DateTime.Today)
                {

                    MessageBox.Show("Por favor, seleccione una fecha reciente");
          
                }
                else
                {
                    Form7 formulario = new Form7();

                    formulario.Show();

                    this.Close();
                }
            }
            else
            {
                MessageBox.Show("Por favor, seleccione una habitación");
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            eleccion = "DOBLE";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            eleccion = "SUIT";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            eleccion = "FAMILIAR";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            eleccion = "EJECUTIVA";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            eleccion = "DELUXE";
        }

        private void button10_Click(object sender, EventArgs e)
        {
            eleccion = "CUADRUPLES";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form5 formualario5 = new Form5();

            formualario5.Show();

            this.Close();
        }

        private void panel3_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
