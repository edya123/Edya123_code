using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day7
{
    class Uzdevumi
    {
        // int masivaGarums = 0;

        public void Izvelne()
        {
            // TODO Pievienot funkcijas
            Viendimensiju();
        }

        private void Viendimensiju()
        {
            // cilveks ievada masiva garumu
            // parbaudam ievadi, nedrikst but mazaks/vienads par 0
            // un lielaks par 9
            // ja cilveks nav ievadijis pareizi, liekam ievadit, kamer izdarits
            // tad uztaisam tada garuma masivu
            // Masivam jabut String tipa
            // Cilvekam jaievada masiva vertibas
            // ja ievadita String garums ir lielaks par 6, tad ierakstam
            // masiva nevis to vertibu, bet "!Error!"
            // talak masivu izvadam

            int garums = 0;

            while (garums < 1 || garums > 9)
            {
                garums = Ievade();
                if (garums < 1 || garums > 9)
                {
                    Console.WriteLine("Ievade nav pareiza");
                }
            }
            String[] daudzasVirknes = new string[garums];

            for (int i = 0; i < daudzasVirknes.Length; i++)
            {
                Console.WriteLine("Ievadiet masiva vertibu");
                daudzasVirknes[i] = Console.ReadLine();
                if (daudzasVirknes[i].Length > 6)
                {
                    daudzasVirknes[i] = "!Error!";
                }
            }

            for (int i = 0; i < daudzasVirknes.Length; i++)
            {
                Console.WriteLine(daudzasVirknes[i]);
            }
        }

        private int Ievade()
        {
            int result = 0;
            try
            {
                Console.WriteLine("Ievadiet masiva garumu!");
                String input = Console.ReadLine();
                result = Convert.ToInt16(input);
            }
            catch(Exception ex)
            {
                Console.WriteLine("Nepareiza ievadem masivam pieskirts garums 5");
                Console.WriteLine(ex.Message);
            }

            return result;
        }

        private void Divdimensiju()
        {

        }
    }
} 




