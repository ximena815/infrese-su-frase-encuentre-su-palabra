using System;

namespace infrese_su_frase_encuentre_su_palabra
{
    class Program
    {
        static void Main(string[] args)
        {
            string fraseE = ""; //string[] perro = {"gato"};
            string PalabraU = "";
            Console.WriteLine("ingrese su frase y encuencuentre su palabra");
            
            Console.WriteLine("aconticuancion escriba su frase ;3");
            fraseE = Console.ReadLine().ToUpper();

            Console.WriteLine("aca vamos con esa bella palabra que desees encontrar <3");
            PalabraU = Console.ReadLine().ToUpper();//hola Hola

            string[] separapala = fraseE.Split(" ");//hola hola
            //hola [0]
            //hola
            int contador = 0;
            for (int g = 0; g < separapala.Length; g++)
            {
                if(separapala[g]==PalabraU)
                {
                    Console.WriteLine("la posicion de su palabra ;3 --->"+ g);
                    contador++;
                }
            }
            Console.WriteLine(":3 la palabra que buscabas salio tantas veces:" + contador);
            string pajarito =
                      "\n  ^ ^" +
                      "\n (O,O)" +
                      "\n (   )" +
                      "\n  T T";
            Console.WriteLine(pajarito);
        }
    }
}
