using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp3
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        public void recibirDatos(int contS1, int contS2, int contS3, int contS4, double porcentaje1, double porcentaje2, double porcentaje3, double porcentaje4)
        //METODO RECEPTOR DE DATOS
        //Y MOSTRADO EN LOS LABELS
        {
            label8.Text = contS1.ToString();
            label9.Text = contS2.ToString();
            label10.Text = contS3.ToString();
            label11.Text = contS4.ToString();
            label12.Text = porcentaje1.ToString();
            label16.Text = porcentaje2.ToString();
            label17.Text = porcentaje3.ToString();
            label18.Text = porcentaje4.ToString();
        }
    }
}
