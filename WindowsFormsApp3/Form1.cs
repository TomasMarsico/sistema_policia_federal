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
    public partial class Form1 : Form
    {
        public struct cabina
        {
            public string nombre;
            public int sector;
            public int velocidadR;
            public int velocidadL;
            public int dia;
            public int mes;
            public int año;
            public double multa;
            public string registro;

            public cabina(string n, int e, int c, int p, int q, int w, int g, double m, string r)
            {
                nombre = n;
                sector = e;
                velocidadR = c;
                velocidadL = p;
                dia = q;
                mes = w;
                año = g;
                multa = m;
                registro = r;
            }
        }//ESTRUCTURA1

        //////////////////////////////////////////////////

        public Form1()
        {
            InitializeComponent();
        }//FORM1

        //////////////////////////////////////////////////

        public cabina[] vector = new cabina[100];                                         //
        public int x = 1,c, y, j=2, v3, v4, v5, v6, v7, v8, v10, contS1, contS2,         //
        contS3, contS4, tempx;                                                          // DECLARACION
        public bool flag = false, flag2 = false;                                       //  DE
        public string v1, v2;                                                         //   VARIABLES
        public double multa = 2000, valor1, valor2, valor3, valor4, porcentaje1,     //
        porcentaje2, porcentaje3, porcentaje4;                                      //

        ///////////////////////////////////////////////////////

        private void Form1_Load(object sender, EventArgs e)//CARGA DE FORM1
        {

        }

        ///////////////////////////////////////////////////////

        public void Button1_Click_1(object sender, EventArgs e)//PRESIONADO DE BOTON1
        {
            j++;
            Form2 f2 = new Form2();
            //INGRESO DE DATOS
            vector[x].nombre = textBox1.Text.TrimEnd();
            vector[x].registro = maskedTextBox1.Text.TrimEnd();
            vector[x].velocidadR = int.Parse(textBox3.Text);
            vector[x].velocidadL = int.Parse(textBox4.Text);
            vector[x].dia = int.Parse(textBox5.Text);
            vector[x].mes = int.Parse(textBox6.Text);
            vector[x].año = int.Parse(textBox7.Text);
            vector[x].sector = int.Parse(comboBox1.Text);
            //CUENTA DE MULTA
            if(vector[x].velocidadR> vector[x].velocidadL)
            {
                vector[x].multa= 2000+(vector[x].velocidadR - vector[x].velocidadL) * 1.5;
            }
            else
            {
                vector[x].multa = 2000;
            }
            //VALIDACION DE SECTOR
            if (vector[x].sector == 1)
            {
                contS1++;
                valor1 = valor1 + vector[x].multa;
                button5.Enabled = true;

            }
            else if (vector[x].sector == 2)
            {
                contS2++;
                valor2 = valor2 + vector[x].multa;
            }
            else if (vector[x].sector == 3)
            {
                contS3++;
                valor3 = valor3 + vector[x].multa;
           
            }
            else if (vector[x].sector == 4)
            {
                contS4++;
                valor4 = valor4 + vector[x].multa;

            }
            else
            {
                MessageBox.Show("Error, sector incorrecto");
                //INGRESAR EN FORMA DE ERROR
                vector[x].nombre = "Usuario ingresado incorrectamente";
                vector[x].registro = "0";
                vector[x].velocidadR = 0;
                vector[x].velocidadL = 0;
                vector[x].dia = 0;
                vector[x].mes = 0;
                vector[x].año = 0;
                vector[x].sector = 0;
            }
            //MUESTRA EN EL COMBOBOX
            comboBox2.Items.Add(x);
            if (!comboBox4.Items.Contains(vector[x].registro))
                {
                comboBox4.Items.Add(vector[x].registro);
                }
            //SUMA DE X
            x++;
            //MOSTRADO EN LOS TEXT
            label12.Text = ("Usuario: " + x.ToString());
            button1.Text = ("Cargar usuario: " + x.ToString());
            //LIMPIEZA
            textBox1.Clear();
            maskedTextBox1.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox5.Clear();
            textBox6.Clear();
            textBox7.Clear();
            //HABILITA BOTON5
            button3.Enabled = true;
            button6.Enabled = true;
            //CAMBIO DE FORMA
            if (flag == false)
            {
                for (y = 403; y < 555; y++)
                {
                    Height = y;
                    Cursor.Current = Cursors.WaitCursor;
                }
                Cursor.Current = Cursors.Default;
                flag = true;
            }
            //SUMA DE VARIABLES
            c++;
        }

        ///////////////////////////////////////////////////////

        public void Button2_Click(object sender, EventArgs e)//PRESIONADO DE BOTON2 (APERTURA DE FORM2)
        {
            tempx = x;
            Form2 f2 = new Form2();
            x = int.Parse(comboBox2.Text);
            v1 = vector[x].nombre;
            v2 = vector[x].registro;
            v3 = vector[x].velocidadR;
            v4 = vector[x].velocidadL;
            v5 = vector[x].sector;
            v6 = vector[x].dia;
            v7 = vector[x].año;
            v8 = vector[x].mes;
            v10 = x;
            multa = vector[x].multa;
            x = tempx;
            f2.recibirDatos(v1, v2, v3, v4, v5, v6, v7, v8, v10, multa);
            f2.Show();                                       
        }

        ///////////////////////////////////////////////////////

        private void button6_Click(object sender, EventArgs e)//ENVIADO DE DATOS A FORM3
        {
            porcentaje1 = valor1 / contS1;
            porcentaje2 = valor2 / contS2;
            porcentaje3 = valor3 / contS3;
            porcentaje4 = valor4 / contS4;

            Form3 f3 = new Form3();
            Form1 f1 = new Form1();

            f3.recibirDatos(contS1, contS2, contS3, contS4, porcentaje1, porcentaje2, porcentaje3, porcentaje4);
            f3.Show();
        }

        ///////////////////////////////////////////////////////
        
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)//PRESIONADO DE COMBOBOX1
        {
            button1.Enabled = true;
            comboBox2.Enabled = true;
        }

        ///////////////////////////////////////////////////////
        
        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)//PRESIONADO DE COMBOBOX2
        {
            button2.Enabled = true;
        }

        ///////////////////////////////////////////////////////

        private void button5_Click(object sender, EventArgs e)//PRESIONADO DE BOTON5
        {
            listBox1.Items.Clear();
            button5.Enabled = false;
        }

        ///////////////////////////////////////////////////////
       
        private void comboBox3_SelectedIndexChanged_1(object sender, EventArgs e)//EVENTO COMBOBOX4
        {
            button5.Enabled = true;
            listBox1.Items.Clear();
            for (c = 1; c < j; c++)
            {
                {
                    if (vector[c].registro == comboBox4.Text)
                    {
                        if (comboBox3.Text == vector[c].sector.ToString())
                        {
                            listBox1.Items.Add("Multa de el registrado " + vector[c].registro + " en el sector " + vector[c].sector + ": " + vector[c].multa + "$");

                        }
                    }
                }
            }
        }

        ///////////////////////////////////////////////////////

        private void comboBox4_SelectedIndexChanged(object sender, EventArgs e)//EVENTO COMBOBOX4
        {
            button5.Enabled = true;
            listBox1.Items.Clear();
            for (c = 1; c < j; c++)
            {
                {
                    if (vector[c].registro == comboBox4.Text)
                    {
                        if (comboBox3.Text == vector[c].sector.ToString())
                        {
                            listBox1.Items.Add("Multa de el registrado " + vector[c].registro + " en el sector " + vector[c].sector + ": " + vector[c].multa + "$");

                        }
                    }
                }
            }
        }
    }
}