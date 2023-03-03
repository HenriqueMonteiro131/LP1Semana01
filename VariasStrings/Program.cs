using System;

namespace VariasStrings
{
    class Program
    {
        static void Main(string[] args)
        {

            string message = "Primeiro trabalho de LP1";
            string s = @"Nao e um codigo Unicode \u1234, nao e nova linha \n";
            string sConc = "Eu"+"gosto"+"de"+"VideoJogos";
            string sConc2 = "Eu"+"gosto"+"de"+"Programas";
            string sInter = $"{2} mais {5} e igual a {2 + 5}";

            

            {
        
                Console.WriteLine(message);
                Console.WriteLine(s);
                Console.WriteLine(sConc);
                Console.WriteLine(sConc2);
                Console.WriteLine(sInter);;

                
            }
        }
            
    }
}
