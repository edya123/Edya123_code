//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace day4
//{
//    class Matematika
//    {
//        private void Saskaitit()
//        {
//            int a, b;
//            a = Parveidosana();
//            b = Parveidosana();

//            int rezultats = a + b;
//            Console.WriteLine(rezultats);
//        }

//        private void Atnemsana()
//        {
//            int a, b;
//            a = Parveidosana();
//            b = Parveidosana();

//            int rezultats = a - b;
//            Console.WriteLine(rezultats);
//        }


//        private void Kapinasana()
//        {
//            int skaitlis = Parveidosana();
//            int pakape = Parveidosana();

//            int rezultats = 1;
//            for (int i = 0; i < pakape; i++)
//            {
//                rezultats = rezultats * skaitlis;
//            }
//            Console.WriteLine(rezultats);
//        }

//        private int Parveidosana()
//        {
//            Console.WriteLine("Ievadiet skaitli!");
//            String virkne = Console.ReadLine();
//            int result = Convert.ToInt16(virkne);
//            return result;
//        }
//        public void Darbibas()
//        {
//            String choice = "";
//            while (choice != "iziet")
//            // != ir pretejs ==
//            {
//                Console.WriteLine("Ievadiet simbolus - +; -; ^ vai iziet");
//                choice = Console.ReadLine();
//                switch (choice)
//                {
//                    case "+":
//                        Saskaitit();
//                        break;
//                    case "-":
//                        Atnemsana();
//                        break;
//                    case "^":
//                        Kapinasana();
//                        break;
//                    case "iziet":
//                        break;
//                    default:
//                        Console.WriteLine("Nepareiza ievade");
//                        break;
//                }
//            }
//        }
//    }
//}
 