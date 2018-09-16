using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day4
{
    class Uzdevums
    {
    //    private int a = 4;
    //    public int b = 6;

    //    public void Interfeiss()
    //    {
    //        a = 6;
    //        GarumaParbaude();
    //    }

    //    private void GarumaParbaude()
    //    {
    //        a = 11;
    //        Console.WriteLine("Ievadiet simbolus: ");
    //        String simboli = Console.ReadLine();

    //        if (simboli.Length > 1 && simboli.Length < 13)
    //        {
    //            Console.WriteLine("Viss ir ok");
    //        }
    //        else
    //        {
    //            Console.WriteLine("Nepareiza ievade");
    //        }
    //    }

    //    public void Izvelne()
    //    {
    //        String c = "11";

    //        switch (c)
    //        {
    //            case "0":
    //                Console.WriteLine("vii");
    //                break;
    //            case "1":
    //                Console.WriteLine("vii2");
    //                break;
    //            default:
    //                Console.WriteLine("Nepareiza ievade");
    //                break;
    //        }
    //    }

        //Cilveks ievada simbolu virkni
        //Virknes garumam ir jabut min- 1 simbolam, max 12 simboli
        //Ja neatbilst tad izvade- "Nepareiza ievade"
        //Ja atbilst- Izvade ir "Viss ir ok!"

        //paliek private- GarumaParbaude()

        //garums simbolu virknei-
        // StringaNosaukums.Length;

        //public void Menu()
        //{
        //    String choice = "";

        //    while (choice != "iziet")
        //    {

        //        Console.WriteLine("Ievadiet simbolus- 1, 2, 3 vai iziet");
        //        choice = Console.ReadLine();

        //        switch (choice)
        //        {
        //            case "1":
        //                Console.WriteLine("vii");
        //                Console.WriteLine("...");
        //                break;
        //            case "2":
        //                Console.WriteLine("vii2");
        //                break;
        //            case "3":
        //                Console.WriteLine("vii3");
        //                break;
        //            case "iziet":
        //                break;
        //            default:
        //                Console.WriteLine("Nepareiza ievade");
        //                break;
        //        }


        //    }

        //}

        public void Cikli()
        {
            //*
            //**
            //***
            //****
            int skaititajs = 0;
            String zvaigzne = "*";
            while (skaititajs < 4)
            {
                Console.WriteLine(zvaigzne);
                zvaigzne = zvaigzne + "*";
                skaititajs++;
            }
        }

    }

    //{
    //    // Ievadit simbolu virkni
    //    // Virknes garumam jabut min 1 simbolam, max 12 simboli;
    //    // ja neatbilst, tad izvade - "Nepareiza ievade"
    //    // Ja atbilst - izvade "Viss ir ok!"
    //    //paliek private void Garuma Parbaude()
    //    // StringaNosaukums.Length;



    //    public void Interfeiss()
    //    {
    //        GarumaParbaude();
    //    }
    //    private void GarumaParbaude()
    //    {
    //        Console.WriteLine("Ievadiet simbolus:");
    //        String simboli = Console.ReadLine();

    //        if (simboli.Length >= 1 && simboli.Length < 13)
    //        {
    //            Console.WriteLine("Viss ir ok");
    //        }
    //        else
    //        {
    //            Console.WriteLine("Nepareiza ievade");
    //        }
    //    }

    //    private void Izvelne()
    //    {
    //        int c = 11;

    //        switch (c)
    //        {
    //            case 0:
    //                Console.WriteLine("vii");
    //                break;
    //            case 1:
    //                Console.WriteLine("vii2");
    //                break;
    //            default:
    //                Console.WriteLine("nee");
    //                break;
    //        }
    //    }

    //    //while

    //    //Cilveks ievada simbolu virkni
    //    //Lai to vinam liek darit 
    //    //tik ilgi kamer vins nav ievadijis "iziet"

    //    public void Menu()
    //    {
    //        String choice = "";
    //        while (choice != "iziet")
    //        // != ir pretejs ==
    //        {
    //            Console.WriteLine("Ievadiet simbolus - 1; 2; 3 vai iziet");
    //            choice = Console.ReadLine();

    //            switch (choice)
    //            {
    //                case "1":
    //                    Console.WriteLine("vii");
    //                    Console.WriteLine("...");
    //                    break;
    //                case "2":
    //                    Console.WriteLine("vii2");
    //                    break;
    //                case "3":
    //                    Console.WriteLine("vii3");
    //                    break;
    //                case "iziet":
    //                    break;
    //                default:
    //                    Console.WriteLine("Nepareiza ievade");
    //                    break;
    //            }
    //        }
    //    }

        public void Cikli()
        {
            int skaititajs = 0;
            String zvaigzne = "*";
            while (skaititajs < 4)
            {
                Console.WriteLine(zvaigzne);
                skaititajs++;
            }
        }
    }
