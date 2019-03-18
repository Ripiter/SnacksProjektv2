using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WashingProjekt
{
    class Program
    {
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
                    admin.ResetMoneyErnedToday();
                    break;
                case "3":
                    //adds custom snuc

                    //Users writes x y z and it goes to the other method to the place where automat is 
                    //that way we dont have console.writeline in autoamt, so every time we need users input
                    //we just get it, thru the way before
                    try
                    {
                        Console.Write("Write name of snack: \r\n");
                        string nameOfSnack = Console.ReadLine();
                        Console.Write("Write price of snack: \r\n");
                        double priceOfSnack = double.Parse(Console.ReadLine());
                        Console.Write("How many snacs of yours you want you add: \r\n");
                        double howManySnackAdd = double.Parse(Console.ReadLine());
                        admin.AddSnack(nameOfSnack, priceOfSnack, howManySnackAdd);
                        admin.CheckForOverFlow(howManySnackAdd);
                    }catch (FormatException fe)
                    {
                        Console.WriteLine(fe.Message);
                    }
                    catch
                    {
                        Console.WriteLine("Expected error have occurred");
                    }
                    break;
                default:
                    Console.WriteLine("wrong input");
                    break;
            }
        }

        static void Menu()
        {
            Automat automat = new Automat();
            switch (chooseMenu)
            {
                case "1":
            string allSnacks;
                    Console.Clear();
                    Console.WriteLine("All snacks avable:");
                    //shows all avaible snacks
                    allSnacks = automat.AvaibleSnacks();
                    Console.WriteLine(allSnacks);
                    break;
                case "2":
         //   string outputs;
            string moneyReturning;
            string a;
                    //gets users input on what snac he wants
                    //checks if the user put enough money
                    //asks user if he wants to cancel it
                    //automat.checkasnack();
                    a = automat.CheckASnack();
                    //How much money user will get back
                    //User gets a snack

                    moneyReturning = automat.ManyErnedToday();
                    //Outputs all
                    Console.WriteLine(a);
                    Console.WriteLine(moneyReturning);
                    break;
                default:
                    Console.WriteLine("Wrong input");
                    break;
                    
            }
        }
    }
}
