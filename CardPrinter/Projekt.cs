using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace CardPrinter
{
    [XmlRoot("Projekt")]
    public class Projekt
    {
        string sciezka;
        private int wysokosc, szerokosc, odstepX, odstepY;

        public int OdstepX
        {
            get { return odstepX; }
            set { odstepX = value; }
        }

        public int Szerokosc
        {
            get { return szerokosc; }
            set { szerokosc = value; }
        }

        public int Wysokosc
        {
            get { return wysokosc; }
            set { wysokosc = value; }
        }
        private bool marks;

        public bool Marks
        {
            get { return marks; }
            set { marks = value; }
        }

        List<Karta> karty = new List<Karta>();

        [XmlArray("Karty")]
        [XmlArrayItem("Karta")]
        public List<Karta> Karty
        {
            get { return karty; }
            set {
                karty = value;
            }
        }

        public string Sciezka
        {
            get { return sciezka; }
            set { sciezka = value; }
        }

        public int OdstepY
        {
            get
            {
                return odstepY;
            }

            set
            {
                odstepY = value;
            }
        }

        public void dodajPare(string awers, string revers)
        {
            karty.Add(new Karta(awers, revers));
        }

        public string getFullName(string fileName)
        {
            return string.Format("{0}\\{1}", this.Sciezka, fileName);
        }
    }
}
