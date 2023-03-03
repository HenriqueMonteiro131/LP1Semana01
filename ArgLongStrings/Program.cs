using System;

namespace ArgLongStrings
{
    class Program
    {
        private const int V = 4;

        static void Main(string[] args)
        {

            // is empty?
            // if -> ir por todos os argumentos e verificar o tamanho
            for(int i =0; i<args.Length;i++ )
            {
                if(args[i].Length > 4)
                Console.WriteLine(args[i].ToUpper());
            }

        }
    }
}
