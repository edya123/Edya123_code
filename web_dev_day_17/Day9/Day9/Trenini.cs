using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day9
{
    class Trenini
    {
        public void Menu()
        {
            // switch-case ar while
            Restite3();
            //Faktorials();
            //ZvaigzniteVaiRestite();
            Console.ReadLine();

        }

        private void Restite()
        {
            // Cilveks ievada vertibu, kas ir skaitlis 
            // Bonuss, ja izmantojot try-catch parbaudit ievadu
            // izvadit tik restites, cik cilveks ir ievadijis skaitli



            int skaitlis = Ievade();

            for (int i = 0; i < skaitlis; i++)
            {
                Console.Write("#");
            }
        }

        private void Restite2()
        {
            try
            {
                int skaitlis = Ievade();
                String reste = "";
                for (int i = 0; i < skaitlis; i++)
                {
                    reste = reste + "#";
                }
                Console.WriteLine(reste);
            }
            catch
            {
                Console.WriteLine("Nepareiza darbiba");
            }
        }

        private void Restite3()
        {
            int skaitlis = Ievade();

            char[] restites = new char[skaitlis];

            for (int i = 0; i < skaitlis; i++)
            {
                restites[i] = '#';
                Console.Write(restites[i]);
            }
        }
        private void Restite4()
        {
            String[] reste = new string[5] { "#", "##", "###", "####", "#####" };
            for (int i = 4; i >= 0; i--)
            {
                Console.WriteLine(reste[i]);
            }

            // i++
            // i--
            // #####
            // ####
            // ###
            // ##
            // #

        }

        private void Faktorials()
        {
            int skaitlis = Ievade();
            int fak = 0;
            for (int i = 1; i <= skaitlis; i++)
            {
                fak = fak + i;
            }
            Console.WriteLine("Rezultats ir " + fak);

            //String teikums = "";
            //for (int i = 0; i < 5; i++)
            //{
            //    Console.WriteLine("Ievadiet vardu: ");
            //    String pasreizejais = Console.ReadLine();
            //    teikums = teikums + pasreizejais + " ";
            //}
            //Console.WriteLine(teikums);
        }

        private void ZvaigzniteVaiRestite()
        {
            // %
            // 4 % 2 = 0
            // 6 % 3 = 0
            // 5 % 4 = 1
            // parāda atlikumu

            // ja masiva indekss dalas bez atlikuma, ielikt *
            // ja ne, tad #
            //izvadit

            String[] vii = new String[8];

            for(int i = 0; i < vii.Length; i++)
            {
                if (i % 2 == 0)
                {
                    vii[i] = "*";
                }
                else
                {
                    vii[i] = "#";
                }
                Console.Write(vii[i] + " ");
            }
        }

        private int Ievade()
        {
            Console.WriteLine("Ievadiet skaitli");
            String simboli = Console.ReadLine();
            int result = Convert.ToInt16(simboli);

            return result;
        }
    }
}
