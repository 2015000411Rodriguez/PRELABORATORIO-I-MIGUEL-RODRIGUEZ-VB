using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LABORATORIO_I
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e) // Boton aceptar
        {

            if (txtContraseña.Text == "3011") // Si lo que se escribe es igual a 3011 la condicion se cumple 
            {
                
                Form2 ventana2 = new Form2(); // Se declara una variable para el formulario 
                ventana2.Show(); // Se muestra el formulario del crud
                this.Hide(); // Se oculta el login
            }
            else // Si lo que se escribe no es igual a 3011 la condicion no se cumple 
            {
                MessageBox.Show("Contraseña incorrecta"); // Se muestra un mensaje 
                txtContraseña.Clear(); // Se borra lo que se escribió 
            }
        }
    }
}
