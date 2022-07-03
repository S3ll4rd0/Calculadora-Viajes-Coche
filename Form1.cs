using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AlqCoche
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            double kmInicio = (double)numericUpDown1.Value;
            double kmFin = (double)numericUpDown2.Value;
            double kmRecorrido = kmFin - kmInicio;
            double kmPrecio = 0.39;
            double kmGasto;

            if (kmInicio > kmFin)
            {
                MessageBox.Show("El valor de los Km de inicio no puede \nser mayor que los km de llegada");
            }

            kmGasto = kmRecorrido * kmPrecio;
            label4.Text = ($"El total es: {kmGasto}€");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            double kmInicio = (double)numericUpDown1.Value;
            double kmFin = (double)numericUpDown2.Value;
            double kmRecorrido = kmFin - kmInicio;
            {
                MessageBox.Show($"Ha recorrido {kmRecorrido} Kms");
            }
        }
    }
}
