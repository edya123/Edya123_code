using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day8
{
    class Program
    {
        static void Main(string[] args)
        {
            String izvele = "";

            while (izvele != "0")
            {
                Console.WriteLine("Nospiediet 1, lai ievaditu masiva vertibas");
                Console.WriteLine("Nospiediet 2, lai ...");
                Console.WriteLine("Nospiediet 0, lai izietu");
                izvele = Console.ReadLine();
                switch (izvele)
                {
                    case "1":
                        PirmaisPiemers pir = new PirmaisPiemers();
                        pir.DarbibaArMasivu();
                        break;
                    case "2":
                        PirmaisPiemers pie = new PirmaisPiemers();
                        pie.Stripas();
                        break;
                    case "0":
                        //
                        break;
                    default:
                        Console.WriteLine("Nepareiza ievade");
                        break;
                }
            }
        }
    }
}
