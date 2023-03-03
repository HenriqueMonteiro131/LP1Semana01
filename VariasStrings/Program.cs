using System;

namespace VariasStrings
{
    class Program
    {
        static void Main(string[] args)
        {
            string x = "Bananas";
            double xx = 0.12345;
            int ii = 18;

            string message = "Primeiro trabalho de LP1";
            string s = @"Nao e um codigo Unicode \u1234, nao e nova linha \n";
            string sConc = "Eu"+"gosto"+"de"+"VideoJogos";
            string sConc2 = "Eu"+"gosto"+"de"+"Programas";
            string sInter = $"{2} mais {5} e igual a {2 + 5}";
            Console.WriteLine(@"Verbatim = {0}", x);
            /// <summary>
            /// The F2 and C2 define what type of number its gonna trasnform.
            /// </summary>
            /// <returns></returns>
            string sReal = String.Format("{1,-6:f2} e {0:p1}", xx, xx);
            string sHexCoin = String.Format("{1,-6:x2} e {0:c1}", ii, ii);

            
            Console.WriteLine(message);
            Console.WriteLine(s);
            Console.WriteLine(sConc);
            Console.WriteLine(sConc2);
            Console.WriteLine(sInter);
            Console.WriteLine(sReal);
            Console.WriteLine(sHexCoin);
           
            

                
        }
    }
}
