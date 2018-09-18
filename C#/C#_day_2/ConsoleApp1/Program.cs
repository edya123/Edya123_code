using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {



        static void Main(string[] args)
        {
            //Piemers();
            //Piemers2(3, 5);
            //Piemers2(2, 7);
            //int skaitlis = Piemers3();
            //Console.WriteLine(skaitlis);
            //Saskaitisana();
            int reizes = SkaitlaIevade();
            Zvaigzne(reizes);
            Console.ReadLine();
        }

        static void Piemers()
        {
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine(i);
            }
            for (int i = 4; i > -1; i--)
            {
                Console.WriteLine(i);
            }

            int j = 5;
            while (j < 5)
            {
                Console.WriteLine(j);
                j++;
            }

            do
            {

                while (j < 5)

                    Console.WriteLine(j);
                j++;
            } while (j < 5);

            //*
            //**
            //***
            //****

            String zvaigzne = "*";
            for (int i = 0; i < 4; i++)
            {
                Console.WriteLine(zvaigzne);
                zvaigzne = zvaigzne + "*";
            }
        }

        static void Piemers2(int a, int b)
        {
            Console.WriteLine(a + b);
        }

        static int Piemers3()
        {
            int rezultats = 6 + 8;

            return rezultats;
        }

        // uztaisīt funkciju, kas saskaita 2 lietotāja ievaditus skaitlus
        // jaizmanto parametri un return

        static void Saskaitisana(int skaitlis, int skaitlis2)
        {
            int a;
            int b;
            a = SkaitlaIevade();
            b = SkaitlaIevade();
            int summa = a + b;

            Console.WriteLine(summa);
        }

        static int SkaitlaIevade()
        {
            Console.WriteLine("Ievadiet skaitli!");
            String simboluVirkne = Console.ReadLine();
            int jaunaisSkaitlis = Convert.ToInt16(simboluVirkne);

            return jaunaisSkaitlis;
        }

        static void Zvaigzne(int robeza)
        {
            String zvaigzne = "*";
            for (int i = 0; i < robeza; i++)
            {
                Console.WriteLine(zvaigzne);
                zvaigzne = zvaigzne + "*";
            }
        }
    }
}


