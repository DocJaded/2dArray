using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2dArray
{
    class Program
    {
        static void Main(string[] args)
        {

            string[,] arrayName = new string[5, 2]
            {
                { "Tits", "Boobs" },
                { "Legs", "Gams" }, 
                { "Assholes", "Sphincters" },
                { "Nipples", "Milk Glands" },
                { "Ass", "Butt" }
            };



            

            for (int i = 0; i < 6; i++)
            {
                
                for (int j = 0; j < 2; j++)
                {

                    Console.WriteLine(arrayName[i, j]);
                    
                    if (arrayName[i, j] == "Ass")
                    {

                        Console.WriteLine("Ass found at " +"["+i+"," +j+"]"); 
                        return;

                    }
                    else Console.WriteLine("Ass not found");
                }
            }


        }
    }
}
    