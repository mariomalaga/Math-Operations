/*
* PRÁCTICA.............: Práctica Inicial.
* NOMBRE y APELLIDOS...: Mario Olivera Castañeda
* CURSO y GRUPO........: 2o Desarrollo de Interfaces
* TÍTULO de la PRÁCTICA: Uso del IDE V.Studio
* FECHA de ENTREGA.....: 10 de Octubre de 2018
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticaInicial
{
    class Ecuacion
    {
        #region Variables
        private float a;
        private float b;
        private float c;
        #endregion
        #region Constructor
        public Ecuacion(float a, float b, float c)
        {
            this.a = a;
            this.b = b;
            this.c = c;
        }
        #endregion
        #region Metodos
        #region Calcular
        public void Calcular()
        {
            float x1;
            float raiz;
            float dentroRaiz = (float) Math.Pow(b, 2) - (4 * a * c);
            if (a != 0)
            {
                if (dentroRaiz > 0)
                {
                    float x2;
                    raiz = (float) Math.Sqrt(dentroRaiz);
                    x1 = (float)Math.Round(((b * -1) + raiz) / (2 * a),2);
                    x2 = (float)Math.Round(((b * -1) - raiz) / (2 * a),2);
                    Console.ForegroundColor = ConsoleColor.Green;
                    Imprimir("El primer resultado es: " + x1);
                    Imprimir("El segundo resultado es: " + x2);
                }
                else if (dentroRaiz == 0)
                {
                    x1 = (float)Math.Round((b * -1 / (2 * a)),2);
                    Console.ForegroundColor = ConsoleColor.Green;
                    Imprimir("El resultado es: "+x1);
                }
                else if (dentroRaiz < 0)
                {
                    float denominador;
                    float cuentaRealizada;
                    string x3;
                    string x4;
                    denominador = 2 * a;
                    cuentaRealizada = (b * -1) / denominador;
                    raiz = (float)Math.Round(Math.Sqrt(dentroRaiz * -1)/denominador, 2);
                    x3 = (cuentaRealizada.ToString() +" + "+ raiz.ToString()+ "i");
                    x4 = (cuentaRealizada.ToString() +" - "+ raiz.ToString() + "i");
                    Console.ForegroundColor = ConsoleColor.Green;
                    Imprimir("El primer resultado es: " + x3);
                    Imprimir("El segundo resultado es: " + x4);
                }
            }
            else
            {
                string respuesta;
                float x;
                Console.ForegroundColor = ConsoleColor.White;
                Imprimir("No es una ecuación de segundo grado. ¿Quieres resolverla?.");
                Imprimir("Introduce 'si' para resolverla");
                respuesta = Console.ReadLine();
                if (respuesta.Equals("si"))
                {
                    x = (float)Math.Round(c / b,2);
                    Console.ForegroundColor = ConsoleColor.Green;
                    Imprimir("La solucion es: "+x);
                }
                else
                    Console.ForegroundColor = ConsoleColor.Green;
                    Imprimir("Fin del programa \n");
            }    
        }
        #endregion
        #region Imprimir
        public void Imprimir(String nombre)
        {
            Console.WriteLine(nombre);
        }
        #endregion
        #endregion
    }
}
