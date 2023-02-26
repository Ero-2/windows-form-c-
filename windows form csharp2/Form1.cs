using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Contracts;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace windows_form_csharp2
{
    public partial class Form1 : Form
    {
        private int personas = 0;
        private int registrados = 0;
        private int cantidad = 0;
        private contacto[] arreglo;

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            if ((registrados < cantidad))
            {
                var nuevocontacto = new contacto();

                nuevocontacto.FechaDenacimiento_ = DTPP.Value;
                nuevocontacto.Nombre_ = txtnombre.Text;
                nuevocontacto.telefono_ = txttelefono.Text;
                nuevocontacto.Correo = txtcorreo.Text;
                arreglo[registrados] = nuevocontacto;
                registrados = registrados + 1;
                string nuevaLinea = nuevocontacto.Nombre_ + ", " + nuevocontacto.Edad.ToString() + ", " + nuevocontacto.telefono_.ToString() + ", " + nuevocontacto.Correo.ToString() + Environment.NewLine;
                lbl1.Text = lbl1.Text + nuevaLinea;
            }
            else
            {
                MessageBox.Show("No se pueden registrar más personas.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
              
            
            
            
            
                
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            int valor;
                 if (int.TryParse(textBox2.Text, out valor))
            {
                cantidad = valor;
                registrados = 0;
                arreglo = new contacto[cantidad + 1];
            }
            else
            {
                MessageBox.Show("Debe ingresar un número válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBox2.Text = "";
                cantidad = 0;
                registrados = 0;
                arreglo = new contacto[cantidad + 1];
            }
        }
    }
}
