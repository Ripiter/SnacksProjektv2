using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WashingProjekt
{
    class Automat
    {
        public Program prog = new Program();
        public static double moneyErnedToday;
        public double valueOfSnac;
        bool isEnough = false;
        public bool cancel = false;
        public double moneyInput;


        public string AvaibleSnacks()
        {
            string snackInfo = "";
                foreach (Snack snack in Snack.Snac)
                {
                    snackInfo = snackInfo + "name of snack " + snack.NameOfSnack + ", price " + snack.PriceOfSnack + "\r\n";
                }
            return snackInfo;
        }

        //Checks if there is a snack that users wants
        //if the snack is found, it checks if user put enough money
        //if user did not put enough money return how much its missing

        /// <summary>
        /// Remove later
        public int i = 0;
        public int temp = -1;
        /// </summary>
        public string CheckASnack()
        {
            string checkSnack = "";
            try
            {
                Console.WriteLine("insert money");
                moneyInput = double.Parse(Console.ReadLine());
            }
            catch
            {
                checkSnack = "incorrect input";
                return checkSnack;
            }
            Console.WriteLine("name of snack that you want");
            prog.whatSnack = Console.ReadLine().ToLower();

            bool isFound = false;
            foreach (Snack snack in Snack.Snac)
            {
                if (prog.whatSnack == snack.NameOfSnack)
                {
                    isFound = true;
                    //We put the price of the snac that user wants into the valueofscan
                    valueOfSnac = snack.PriceOfSnack;
                    temp = i;
                }
                i++;
            }

            if (isFound == true)
            {
                //Checks if the user put enough money to autmat
                CheckIfItsEnough();
                //CancelOrder ask user if he is sure that he wants to proccede
                //with action, there is no other chance
                if (isEnough == true && cancel == false)
                {
                    CancelOrder();
                    ReturnRestOfMoney();
                    GiveUserSnack();
                }
                else
                {
                    checkSnack = "Not enough money or action canceled";
                    ReturnRestOfMoney();
                    return checkSnack;
                }
                return checkSnack;
            }
            else
            {
                checkSnack = "no snack with that name";
                return checkSnack;
            }
        }

        bool CheckIfItsEnough()
        {
            if (valueOfSnac <= moneyInput)
                isEnough = true;

            return isEnough;
        }

        //Asks user if he wants to proccede with the order
        //if not user gets his money back
        bool CancelOrder()
        {
            Console.WriteLine("Do you want to proccede? yes/no");
            string yesNo = Console.ReadLine().ToLower();

            //Check if user want to procced with order
            if (yesNo != "yes")
                cancel = true;

            return cancel;
        }
        void GiveUserSnack()
        {
            //remove snack from snack list
            Snack.Snac.RemoveAt(temp);
        }
        public string ReturnRestOfMoney()
        {
            string moneyReturnedToUser;
            //if user canceled the valueofsnac goes to 0
            if (cancel == true || isEnough == false)
                valueOfSnac = 0;

            double returnValue = moneyInput - valueOfSnac;

            moneyErnedToday = moneyErnedToday + valueOfSnac;

            moneyReturnedToUser = "rest of the money returned " + returnValue;
            return moneyReturnedToUser;
        }
        
    }
}
