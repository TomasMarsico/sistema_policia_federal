   
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;//LIBRERIAS

namespace WindowsFormsApp3
{
    
    public partial class Form2 : Form
    {
        public Form2()//FORM2
        {
            InitializeComponent();
        }
        
        public int x = 1, y = 1; //DECLARACION DE VARIABLES

        /////////////////////////////////////////////////////

        public void Form2_Load(object sender, EventArgs e)//CARGA DE FORM2
        {

        }

        /////////////////////////////////////////////////////

        private void ToolStripButton3_Click(object sender, EventArgs e)//PRESIONADO DE BOTON3
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /////////////////////////////////////////////////////

        public void recibirDatos(string v1, string v2, int v3, int v4, int v5, int v6, int v7, int v8, int v10, double multa)
            //METODO RECEPTOR DE DATOS
            //Y MOSTRADO EN LOS LABELS
        {
            toolStripLabel1.Text = "Usuario: "+v10.ToString();
            label12.Text = v1;
            label13.Text = v2;
            label14.Text = v3.ToString();
            label15.Text = v4.ToString();
            label16.Text = v5.ToString();
            label20.Text = v6.ToString();
            label18.Text = multa.ToString();
            label19.Text = v8.ToString();
            label17.Text = v7.ToString();
        }
    }
}

