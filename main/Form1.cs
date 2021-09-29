using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FIBONACCI_DINAMICA_MEMOIZACION
{
    public partial class ProgDinMem : Form
    {
        /// <summary>
        /// PROYECTO FIBONACCI PARA DEMOSTRAR LA EFICIENCIA DE LA PROGRAMACION DINAMICA (RECURSIVIDAD)
        /// VS. PROGRAMACION DINAMICA CON MEMOIZACION
        /// </summary>

        int MAX = 30;
        public ProgDinMem()
        {
            InitializeComponent();
        }

        /// <summary>
        /// PROGRAMACION DINAMICA.- La programacion dinamica permite el uso de la recursion generando instancias
        /// con estructuras optimas, es decir, estructuras capaces de resolver un pequeño problema que en su 
        /// conjunto total de instancias, producen a su vez, la solucion a un problema mas grande.
        /// </summary>
        int contador;
        private void button1_Click(object sender, EventArgs e)
        {
            contador = 0;
            lbx1.Items.Clear();
            try
            {
                int numero = Int32.Parse(txt1.Text);
                if (numero <= MAX)
                {
                    int result = FibDin(numero);
                    lbx1.Items.Add("TOTAL INSTANCIAS GENERADAS: " + contador);
                    txtResultado1.Text = result.ToString();
                }
                else
                {
                    MessageBox.Show("El numero debe ser menor o igual a 30");
                    txt1.Text = "";
                }
            }
            catch
            {
                MessageBox.Show("Solo se pude calcular la serie para números enteros positivos");
                txt1.Text = "";
            }
        }
        public int FibDin(int n)
        {
            if (n <= 1)
            {
                contador++;
                lbx1.Items.Add("////Instancia Generada////");
                return n; 
            }
            else
                return FibDin(n - 1) + FibDin(n - 2);
        }

        /// <summary>
        /// MEMOIZACION.- La memoizacion permite almacenar en memoria los resultados obtenidos por cada instancia
        /// de la recursion, de esta manera se ahorra recursos impidiendo que el programa recalcule un resultado
        /// ya calculado en alguna instancia anterior.
        /// </summary>

        private void button2_Click(object sender, EventArgs e)
        {
            IniciarLista();
            contador = 0;
            lbx2.Items.Clear();
            try
            {
                int numero = Int32.Parse(txt2.Text);
                if (numero <= MAX)
                {
                    int result = FibMem(numero);
                    lbx2.Items.Add("TOTAL INSTANCIAS GENERADAS: " + contador);
                    txtResultado2.Text = result.ToString();
                }
                else
                {
                    MessageBox.Show("El numero debe ser menor o igual a 30");
                    txt1.Text = "";
                }
            }
            catch
            {
                MessageBox.Show("Solo se pude calcular la serie para números enteros positivos");
                txt2.Text = "";
            }
        }

        int[] F = new int[50];              //LISTA DONDE SE ALMACENARAN LOS RESULTADOS GENERADOS EN CADA INSTANCIA DE RECURSION
        private void IniciarLista()         //INICIALIZACION DE LA LISTA
        {
            for (int i = 0; i < 50; i++)
            {
                F[i] = -1;
            }
        }
        public int FibMem(int n)            //ALGORITMO DE RECURSION PARA FIBONACCI CON MEMOIZACION
        {
            if (n <= 1)
            {
                contador++;
                lbx2.Items.Add("////Instancia Generada////");
                return n;
            }
            if (F[n] != -1)
                return F[n];
            F[n] = FibMem(n - 1) + FibMem(n - 2);
            return F[n];
        }

        //BOTON SALIR
        private void btnSalir_MouseDown(object sender, MouseEventArgs e)
        {
            Application.Exit();
        }
        private void btnSalir_MouseMove(object sender, MouseEventArgs e)
        {
            btnSalir.BorderStyle = BorderStyle.FixedSingle;
        }
        private void btnSalir_MouseLeave(object sender, EventArgs e)
        {
            btnSalir.BorderStyle = BorderStyle.None;
        }

        //BOTON MINIMIZAR
        private void btnMinimizar_MouseDown(object sender, MouseEventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }
        private void btnMinimizar_MouseMove(object sender, MouseEventArgs e)
        {
            btnMinimizar.BorderStyle = BorderStyle.FixedSingle;
        }
        private void btnMinimizar_MouseLeave(object sender, EventArgs e)
        {
            btnMinimizar.BorderStyle = BorderStyle.None;
        }
    }
}
