using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InicijalnoPonavljanje7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int broj = 1, j;
            for(int i = 3; i < 100; i++)
            {
            
                for(j = 2; j < i; j++)
                {
                    if (i % j ==  0)
                    {
                        goto dalje;
                    }
                    else
                    {
                        if(j == i-1)
                        {
                            //Console.WriteLine(i);
                            broj++;
                        }
                        
                    }
                }
            dalje:;
            }
            Console.WriteLine("Broj primarnih brojeva manjih od 100: " + broj);
            Console.ReadKey();
        }
    }
}
