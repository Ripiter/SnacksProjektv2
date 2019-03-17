using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WashingProjekt
{
    class AdminMenu
    {
        public string nameOfSnack;
        public static  double priceOfSnack;
        public static double howManySnackAdd;
        bool overFlow = false;
        public void AddSnack()
        {
            //while(input.Length < 150)
            try
            {
                Console.Write("Write name of snack: \r\n");
                nameOfSnack = Console.ReadLine();
                Console.Write("Write price of snack: \r\n");
                priceOfSnack = double.Parse(Console.ReadLine());
                Console.Write("How many snacs of yours you want you add: \r\n");
                howManySnackAdd = double.Parse( Console.ReadLine() );
                CheckForOverFlow();
                if (overFlow == false)
                {
                    for (int i = 0; i < howManySnackAdd; i++)
                    {
                        Snack newSnack = new Snack(nameOfSnack, priceOfSnack);
                    }
                    Console.WriteLine("Done");
                }else
                    Console.WriteLine("Not enough space in automat");
                
            }
            catch 
            {
              //  Console.WriteLine(e.ToString());
                Console.WriteLine("Incorrect input");
            }
        }
        public void HardCodeSnacks()
        {
            Snack charmander = new Snack("charmander", 15);
            Snack pikachu = new Snack("pikachu", 20);
            Snack squirtle = new Snack("squirtle", 10);
            Snack bulbasaur = new Snack("bulbasaur", 5);
        }
        void CheckForOverFlow()
        {
            if (priceOfSnack > 999 || howManySnackAdd > 999)
            {
                overFlow = true;
            }

        }
    }
}
