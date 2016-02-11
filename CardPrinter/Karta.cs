using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CardPrinter
{
    public class Karta
    {

        private string awers, rewers;

        public Karta() { 
        }

        public string Rewers
        {
            get { return rewers; }
            set { rewers = value; }
        }

        public string Awers
        {
            get { return awers; }
            set { awers = value; }
        }


        public Karta(string awers, string rewers)
        {
            this.awers = awers;
            this.rewers = rewers;
        }

        public override string ToString()
        {
            return string.Format("A: {0}\r\nR: {1}",awers,rewers);
        }
    }
}
