using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WashingProjekt
{
    class AdminMenu
    {
        bool overFlow = false;

        public void AddSnack(string nameOfSnack, double priceOfSnack, double _howManySnacksAdd)
        {
            try
            {
                CheckForOverFlow(_howManySnacksAdd); //This method is only here because of rasmus

                if (overFlow == false)
                {
                    for (int i = 0; i < _howManySnacksAdd; i++)
                    {
                        Snack newSnack = new Snack(nameOfSnack, priceOfSnack);
                    }
                    Console.WriteLine("Done"); //will be made to return at some point
                }
                else
                    Console.WriteLine("Not enough space in automat"); //will be made to return at some point

            }
            catch //(FormatException fe)
            {
                //  Console.WriteLine(fe.Message);
                //  Console.WriteLine(e.ToString());
                Console.WriteLine("Incorrect input");
            }
        }

        public void ResetMoneyErnedToday()
        {
            Console.WriteLine("money earned today: " + Automat.moneyErnedToday);
            Console.WriteLine("Do you want to reset todays earnings? yes/no");
            string a = Console.ReadLine().ToLower();
            if(a == "yes")
            Automat.moneyErnedToday = 0;
            else
                Console.WriteLine("Nothing happens");
        }

        public void HardCodeSnacks()
        {
            Snack charmander = new Snack("charmander", 15);
            Snack pikachu = new Snack("pikachu", 20);
            Snack squirtle = new Snack("squirtle", 10);
            Snack bulbasaur = new Snack("bulbasaur", 5);
        }



        public void CheckForOverFlow(double howManySnackAddOv)
        {
            if (howManySnackAddOv > 150)
            {
                overFlow = true;
            }
        }
    }
}
