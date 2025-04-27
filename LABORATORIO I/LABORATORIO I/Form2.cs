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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }
        private void LimpiarCampos() // Método para limpiar los campos del formulario
        {
            textBox1.Clear();//Limpia del textBox1
            textBox2.Clear();//Limpia del textBox2
            textBox3.Clear();//Limpia del textBox3
            textBox4.Clear();//Limpia del textBox4
            textBox5.Clear();//Limpia del textBox5
            textBox6.Clear();//Limpia del textBox6
            textBox7.Clear();//Limpia del textBox7
            textBox8.Clear();//Limpia del textBox8
            textBox9.Clear();//Limpia del textBox9
            textBox10.Clear();//Limpia del textBox10
            textBox11.Clear();//Limpia del textBox11
            textBox12.Clear();//Limpia del textBox12
        }

        private void button1_Click(object sender, EventArgs e) // Boton guardar 
        {
            dataGridView1.Rows.Add( // Asigna los valores desde
                 textBox1.Text,     // las caja de texto a cada celda
                 textBox2.Text,    // Desde el textBox 1 al textBox12
                 textBox3.Text,
                 textBox4.Text,
                 textBox5.Text,
                 textBox6.Text,
                 textBox7.Text,
                 textBox8.Text,
                 textBox9.Text,
                 textBox10.Text,
                 textBox11.Text,
                 textBox12.Text
               );
            LimpiarCampos(); // Limpiar todos los campos del formulario
        }

        private void button3_Click(object sender, EventArgs e) // Boton eliminar
        {
            if (dataGridView1.CurrentRow != null) // Verifica que haya una fila seleccionada antes de eliminarla
                dataGridView1.Rows.RemoveAt(dataGridView1.CurrentRow.Index); // Eliminar la fila seleccionada
                LimpiarCampos(); // Limpiar todos los campos del formulario

        }

        private void button2_Click(object sender, EventArgs e) // Boton editar
        {
            if (dataGridView1.CurrentRow != null) // Verifica que haya una fila seleccionada 
            {
                DataGridViewRow fila = dataGridView1.CurrentRow; // Obtiene la fila actual seleccionada

                fila.Cells[0].Value = textBox1.Text;  // Asigna los nuevos valores de los campos del
                fila.Cells[1].Value = textBox2.Text;  // formulario a las celdas desde el Textbox1 al
                fila.Cells[2].Value = textBox3.Text;  // Textbox12
                fila.Cells[3].Value = textBox4.Text;
                fila.Cells[4].Value = textBox5.Text;
                fila.Cells[5].Value = textBox6.Text;
                fila.Cells[6].Value = textBox7.Text;
                fila.Cells[7].Value = textBox8.Text;
                fila.Cells[8].Value = textBox9.Text;
                fila.Cells[9].Value = textBox10.Text;
                fila.Cells[10].Value = textBox11.Text;
                fila.Cells[11].Value = textBox12.Text;
                

            }
           


        }

        private void button4_Click(object sender, EventArgs e) // Boton creditos 
        {
            Form3 ventana3 = new Form3();  // Se declara una variable para el formulario 
            ventana3.Show(); // Muestra la ventana de créditos 
            this.Hide(); // Se oculta el crud
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int fila = dataGridView1.CurrentCell.RowIndex; // Obtiene el índice de la fila actual seleccionada 

            textBox1.Text = dataGridView1[0, fila].Value.ToString(); // Se toma el valor y se muestra en textBox1                                              
            textBox2.Text = dataGridView1[1, fila].Value.ToString(); // Se toma el valor y se muestra en textBox2   
            textBox3.Text = dataGridView1[2, fila].Value.ToString();// Se toma el valor y se muestra en textBox3    
            textBox4.Text = dataGridView1[3, fila].Value.ToString();// Se toma el valor y se muestra en textBox4    
            textBox5.Text = dataGridView1[4, fila].Value.ToString();// Se toma el valor y se muestra en textBox5    
            textBox6.Text = dataGridView1[5, fila].Value.ToString();// Se toma el valor y se muestra en textBox6    
            textBox7.Text = dataGridView1[6, fila].Value.ToString();// Se toma el valor y se muestra en textBox7    
            textBox8.Text = dataGridView1[7, fila].Value.ToString();// Se toma el valor y se muestra en textBox8    
            textBox9.Text = dataGridView1[8, fila].Value.ToString();// Se toma el valor y se muestra en textBox9    
            textBox10.Text = dataGridView1[9, fila].Value.ToString();// Se toma el valor y se muestra en textBox10    
            textBox11.Text = dataGridView1[10, fila].Value.ToString();// Se toma el valor y se muestra en textBox11    
            textBox12.Text = dataGridView1[11, fila].Value.ToString();// Se toma el valor y se muestra en textBox12   
        }
    }
}
