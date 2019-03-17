using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WashingProjekt
{
    class Snack
    {
        static List<Snack> snac = new List<Snack>();
        string nameOfSnack;
        double priceOfSnack;

        public static List<Snack> Snac
        {
            get
            {
                return snac;
            }
            set
            {
                snac = value;
            }
        }

        public string NameOfSnack{
            get
            {
                return this.nameOfSnack;
            }
            set
            {
                this.nameOfSnack = value;
            }
        }

        public double PriceOfSnack
        {
            get
            {
                return this.priceOfSnack;
            }
            set
            {
                this.priceOfSnack = value;
            }
        }

        public Snack(string _nameOfsnack, double _priceOfSnack)
        {
            this.nameOfSnack = _nameOfsnack;
            this.priceOfSnack = _priceOfSnack;

            snac.Add(this);
        }

    }
}
