using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day5
{
    class Daudzsturi
    {
        private int a = 0;
        private int b = 0;


        public void Interfeiss()
        {
            Izvelne();
        }

        private void Izvelne()
        {
            String choice = "";
            while (choice != "iziet")
            {
                Console.WriteLine("Ievadiet malu skaitu (1), malu garumu (2), parādīt malu skaitu, garumu un figūru (3), izrēķināt perimetru(4) vai iziet");
                choice = Console.ReadLine();
                switch (choice)
                {
                    case "1":
                        Figuras();
                        a = 3;
                        break;
                    case "2":
                        MalasGarums();
                        break;
                   case "4":
                        Console.WriteLine(Perimetrs());
                        break;
                    case "iziet":
                        break;
                    default:
                        Console.WriteLine("Nepareiza ievade");
                        break;
                }
            }
        }
        private void Figuras()
        {
            String choice = "";
            while (choice != "iziet")
            {
                Console.WriteLine("Ievadiet malu skaitu vai iziet");
                choice = Console.ReadLine();
                switch (choice)
                {
                    case "3":
                        Console.WriteLine("Trijstūris");
                        a = 3;
                        break;
                    case "4":
                        Console.WriteLine("Četrstūris");
                        a = 4;
                        break;
                    case "5":
                        Console.WriteLine("Piecstūris");
                        a = 5;
                        break;
                    case "iziet":
                        break;
                    default:
                        Console.WriteLine("Nepareiza ievade");
                        break;
                }
            }
        }
        private int Parveidosana()
        {
            Console.WriteLine("Ievadiet malu skaitu vai iziet");
            String choice = Console.ReadLine();
            int result = Convert.ToInt16(choice);
            return result;
        }
        private int MalasGarums()
        {
            Console.WriteLine("Ievadiet malas garumu");
            String choice = Console.ReadLine();
            int result = Convert.ToInt16(choice);
            return result;
        }
        private int Perimetrs()
        {
            int c = a * b;
            return c;
          
        }
    }
}

