using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WashingProjekt
{
    class Program
    {
        public double moneyInput = 100;
        public static string chooseMenu;
        //whatSnack is userinput for what kind of snack he wants
        public string whatSnack;
        
        static void Main(string[] args)
        {
            AdminMenu am = new AdminMenu();
            am.HardCodeSnacks();
            while (true)
            {
                Console.Clear();
                Console.WriteLine("1 to show all snack");
                Console.WriteLine("2 to test snack");
                Console.WriteLine("type admin go to special menu");
                chooseMenu = Console.ReadLine().ToLower();
                if(chooseMenu == "admin")
                    UserAdmin();
                else
                    Menu();

                Console.ReadLine();
            }
        }
        static void UserAdmin()
        {
            Console.Clear();
            AdminMenu admin = new AdminMenu();
            Console.WriteLine("what you want to do");
            Console.WriteLine("1 to add drinks");
            Console.WriteLine("2 clear all money");
            Console.WriteLine("3 to add a custom snack");
            string adminpas = Console.ReadLine();

            switch (adminpas)
            {
                case "1":
                    //Adds hardcoded snacks
                    admin.HardCodeSnacks();
                    break;
                case "2":
                    Console.WriteLine("clears money");
                    break;
                case "3":
                    //adds custom snuc
                    admin.AddSnack();
                    break;
                default:
                    Console.WriteLine("wrong input");
                    break;
            }
        }

        static void Menu()
        {
            Automat automat = new Automat();
            string a;
            switch (chooseMenu)
            {
                case "1":
                    Console.Clear();
                    Console.WriteLine("All snacks avable:");
                    //shows all avaible snacks
                     a = automat.AvaibleSnacks();
                    Console.WriteLine(a);
                    break;
                case "2":
                    //gets users input on what snac he wants
                    //checks if the user put enough money
                    //asks user if he wants to cancel it
                    automat.CheckASnack();
                    break;
                default:
                    Console.WriteLine("Wrong input");
                    break;
                    
            }
        }
    }
}
