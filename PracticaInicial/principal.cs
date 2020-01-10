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
    class Principal
    {
        #region Main
        static void Main(string[] args)
        {
            string casos = "";
            while (casos != "3")
            {
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("Caso 1: Realizar ecucación de segundo grado");
                Console.WriteLine("Caso 2: Tabla de multiplicar");
                Console.WriteLine("Caso 3: Salir");
                casos = Console.ReadLine();
                switch (casos)
                {
                    case "1":
                        Console.Clear();
                        string a = "";
                        string b = "";
                        string c = "";
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.WriteLine("Programa para resolver ecuación de segundo grado como ax2 + bx + c = 0");
                        Console.ForegroundColor = ConsoleColor.White;
                        a = ControlarEntradaInt(a, "Introducir valor de a: ");
                        b = ControlarEntradaInt(b, "Introducir valor de b: ");
                        c = ControlarEntradaInt(c, "Introducir valor de c: ");
                        Ecuacion ecuacion = new Ecuacion(int.Parse(a), int.Parse(b), int.Parse(c));
                        ecuacion.Calcular();
                        break;
                    case "2":
                        Console.Clear();
                        string factor = "";
                        string numeroElementos = "";
                        bool comprobarFactor = false;
                        bool comprobarNumeroElementos = false;
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.WriteLine("Programa para imprimir la tabla de multiplicar del número indicado");
                        Console.ForegroundColor = ConsoleColor.White;
                        factor = ControlarEntradaInt(factor, "Introducir factor (número entero positivo): ");
                        do
                        {
                            if (int.Parse(factor) > 0)
                            {
                                comprobarFactor = !comprobarFactor;
                            }
                            else
                            {
                                Console.Clear();
                                Console.ForegroundColor = ConsoleColor.Red;
                                Console.WriteLine("Has introducido un valor erróneo.");
                                Console.ForegroundColor = ConsoleColor.White;
                                Console.WriteLine("Por favor introduce un valor entero positivo.");
                                factor = ControlarEntradaInt(factor, "Introducir factor (número entero positivo): ");
                            }
                        } while (!comprobarFactor);
                        numeroElementos = ControlarEntradaInt(numeroElementos, "Introducir número elementos (número entero positivo): ");
                        do
                        {
                            if (int.Parse(numeroElementos) > 0)
                            {
                                comprobarNumeroElementos = !comprobarNumeroElementos;
                            }
                            else
                            {
                                Console.Clear();
                                Console.ForegroundColor = ConsoleColor.Red;
                                Console.WriteLine("Has introducido un valor erróneo.");
                                Console.ForegroundColor = ConsoleColor.White;
                                Console.WriteLine("Por favor introduce un valor entero positivo.");
                                numeroElementos = ControlarEntradaInt(numeroElementos, "Introducir número elementos (número entero positivo): ");
                            }
                        } while (!comprobarNumeroElementos);
                        Console.ForegroundColor = ConsoleColor.White;
                        Tabla tabla = new Tabla(int.Parse(factor), int.Parse(numeroElementos));
                        tabla.Calcular();
                        break;
                    case "3":
                        Environment.Exit(0);
                        break;
                    default:
                        Console.Clear();
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Has introducido un valor distinto.");
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.WriteLine("Por favor introduce un valor en ese rango.");
                        break;
                }
            }
        }
        #endregion
        #region Metodos
        static string ControlarEntradaInt(string variable, string texto)
        {
            int valor;
            bool esNumero;
            do
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine(texto);
                Console.WriteLine(" ");
                variable = Console.ReadLine();
                /* Si es número correcto retornará true y saldrá
                    *  del Ciclo*/
                esNumero = int.TryParse(variable, out valor);
                Console.WriteLine(" ");
                if (!esNumero)
                {
                    Console.Clear();
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Error al introducir. Por favor vuelva a introducir");
                }
            }
            while (!esNumero);
            return variable;
        }
        #endregion
    }
}
