using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio5
{
    class generar
    {
        //atributos 
        private int _aleatorio;


        //Propiedades
        public int Aleatorio
        {
            get { return _aleatorio; }
            set { _aleatorio = value; }
        }

        //constructores
        public generar()
        {

        }

        public generar(int aleatorio)
        {
            Aleatorio = aleatorio;
        }

        //                      
        public void Main(string[]args)
        {
            Random aleatorio = new Random();
            int numeros = aleatorio.Next(1, 1001);


            return numeros + " " + aleatorio;
        }













    }
}
