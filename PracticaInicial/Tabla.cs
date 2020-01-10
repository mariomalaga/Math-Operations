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
    class Tabla
    {
        #region Variables
        private int factor;
        private int numeroElementos;
        #endregion
        #region Constructor
        public Tabla(int factor, int numeroElementos)
        {
            this.factor = factor;
            this.numeroElementos = numeroElementos;
        }
        #endregion
        #region Metodos
        #region Calcular
        public void Calcular()
        {
            int paginar = 9;
            int multiplicacion;
            Imprimir("Presiona Enter para mostrar 10 resultados");
            for (int i = 0; i < numeroElementos; i++)
            {
                Console.ForegroundColor = ConsoleColor.White;
                multiplicacion = i * factor;
                Imprimir(i + " x " + factor + " = " + multiplicacion + "\n");
                if (paginar == i)
                {
                    Imprimir("-------------------------------------------------");
                    if (Console.ReadKey().Key == ConsoleKey.Enter)
                    {
                        paginar = paginar + 10;
                    }                   
                }
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
