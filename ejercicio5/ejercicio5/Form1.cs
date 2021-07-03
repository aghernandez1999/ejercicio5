using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ejercicio5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }




        double[,] numeros;

        int datos;

        private void btn_tamaño_Click(object sender, EventArgs e)
        {
            try
            {
                if (txt_valor.Text.Trim() != "")
                {


                    datos = int.Parse(txt_valor.Text.Trim());

                    
                    numeros = new double[datos,datos];

                }


                for (int filas = 0; filas < numeros.GetLength(0); filas++)
                    {
                        for (int columnas = 0; columnas < numeros.GetLength(0); columnas++)
                        {
                            numeros[filas, columnas] = aleatorio
         
                                        
                       

               
                        }




            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void btn_mostrar_Click(object sender, EventArgs e)
        {
            for (int filas = 0; filas < numeros.GetLength(0); filas++)
            {
                for (int columnas = 0; columnas < numeros.GetLength(0); columnas++)
                {
                    






                }
            }
    }
 }
  