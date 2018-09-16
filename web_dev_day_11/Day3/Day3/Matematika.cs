using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day3
{
    class Matematika
    {
        public void Saskaitit()
        {
            int a, b;
            a = Parveidosana();
            b = Parveidosana();

            int rezultats = a + b;
            Console.WriteLine(rezultats);
        }

        public void Atnemsana()
        {
            int a, b;
            a = Parveidosana();
            b = Parveidosana();

            int rezultats = a - b;
            Console.WriteLine(rezultats);
        }
        public void Apvienota()
        {
            int a, b;
            a = Parveidosana();
            b = Parveidosana();

            Console.WriteLine("Ievadiet 1, lai saskaititu vai 2, lai atnemtu");
            String izvele = Console.ReadLine();

            if (izvele == "1")
            {
                Console.WriteLine(a + b);
            }
            else if (izvele == "2")
            {
                Console.WriteLine(a - b);
            }
            else
            {
                Console.WriteLine("Ievade nav pareiza");
            }
        }

        private int Parveidosana()
        {
            Console.WriteLine("Ievadiet skaitli!");
            String virkne = Console.ReadLine();
            int result = Convert.ToInt16(virkne);
            return result;
        }
        // 5 reizes prasa ievadit vardu, beigas visu izvada
        //martins ir loti loti forss

        public void Teikums()
        {
            String teikums = "";
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("Ievadiet vardu: ");
                String pasreizejais = Console.ReadLine();
                teikums = teikums + pasreizejais + " ";
            }
            Console.WriteLine(teikums);
        }
        // ievada skaitli, ievadam pakapi, tiek paradits rezultats

        public void Kapinasana()
        {
            int skaitlis = Parveidosana();
            int pakape = Parveidosana();

            int rezultats = 1;
            for (int i = 0; i < pakape; i++)
            {
                rezultats = rezultats * skaitlis;
            }
            Console.WriteLine(rezultats);
        }
    }
}
