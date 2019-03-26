using System;
using System.Collections.Generic;
using System.Text;

namespace Examen
{
    public class Program
    {
        public static string Mid(string param, int startIndex, int length)
        {
            string result = param.Substring(startIndex, length);
            return result;
        }

        static void Main(string[] args)
        {
            //hago el array "piñon fijo"
            Console.WriteLine("5 nombres(por ahora)");

            string[] aleatorios = new string[10] { "Jusfbbn", "pedjbbro", "Pjkhpe", "cabhhhvos", "CohhkHn", "hghbjfbj", "JkkJjoo", "Yjgjkkkkkkubb", "cncn", "YY" };
            
            //para hacer dos array
            string[] mayusculas, minusculas;
            int mitad = aleatorios.Length / 2;

            mayusculas = new string[mitad];
            minusculas = new string[aleatorios.Length - mitad];
            Array.Copy(aleatorios, 0, mayusculas, 0, mitad);
            Array.Copy(aleatorios, mitad, minusculas, 0, minusculas.Length);

            foreach (string i in aleatorios)
            {
                Console.WriteLine("{0} ", i);

            }
            Console.WriteLine(" ");
            Console.WriteLine("primera mitad");
            foreach (string i in mayusculas)
            {
                Console.WriteLine(i);

            }
            Console.WriteLine(" ");
            Console.WriteLine("segunda mitad");
            foreach (string i in minusculas)
            {
                Console.WriteLine(i);
            }

            //para invertir
            Console.WriteLine("Invertir...");
            string frase, invertida = "";
                int posicion = 0;
            frase = minusculas[0];

                posicion = frase.Length;
                while (posicion > 0)
                {
                    
                    invertida = invertida + Mid(frase, posicion - 1, 1);
                    posicion = posicion - 1;
                }

                Console.WriteLine("La frase invertida es: " + invertida);
            
        }
      
    }
}
