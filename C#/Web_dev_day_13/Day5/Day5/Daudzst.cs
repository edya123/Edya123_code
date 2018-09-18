using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day5
{
    class Daudzst
    {
        private int sturuSkaits = 0;
        private double malasGarums = 0;

        public void Interfeiss()
        {
            String izvele = "";
            while (izvele != "Iziet")
            {
                Console.WriteLine("1 - ievadiet sturu skaitu");
                Console.WriteLine("2 - Ievadiet malas garumu");
                Console.WriteLine("3 - Pateikt, kas par figuru");
                Console.WriteLine("4 - Perimetrs");
                Console.WriteLine("Rakstiet \"iziet\", lai izietu");
                izvele = Console.ReadLine();

                switch (izvele)
                {
                    case "1":
                        IevaditSturuSkaitu();
                        break;
                    case "2":
                        IevaditMalasGarumu();
                        break;
                    case "3":
                        KasParFiguru();
                        break;
                    case "4":
                        Perimetrs();
                        break;
                    case "iziet":
                        break;
                    default:
                        Console.WriteLine("Nepareiza ievade");
                        break;
                }
            }
        }

        private void IevaditSturuSkaitu()
        {
            Console.WriteLine("Ievadiet sturu skaitu!");
            String ievade = Console.ReadLine();
            sturuSkaits = Convert.ToInt16(ievade);

            KasParFiguru();
        }

        private void IevaditMalasGarumu()
        {
            Console.WriteLine("Ievadiet malas garumu!");
            String ievade = Console.ReadLine();
            malasGarums = Convert.ToDouble(ievade);
        }

        private void KasParFiguru()
        {
            switch (sturuSkaits)
            {
                case 3:
                    Console.WriteLine("Trijsturis");
                    break;
                case 4:
                    Console.WriteLine("Cetrsturis");
                    break;
                case 5:
                    Console.WriteLine("Piecsturis");
                    break;
            }
        }

        private void Perimetrs()
        {
            if (sturuSkaits < 3 || sturuSkaits > 5)
            {
                Console.WriteLine("Nav pareiz ievadits sturu skaits");
                IevaditSturuSkaitu();
            }
            else
            {
                if (malasGarums > 0)
                {
                    double perimetrs = sturuSkaits * malasGarums;
                    Console.WriteLine("Perimetrs ir " + perimetrs);
                }
                else
                {
                    Console.WriteLine("Malas garums nav ievadits pareizi");
                    IevaditMalasGarumu();
                }
            }
        }
    }
}

