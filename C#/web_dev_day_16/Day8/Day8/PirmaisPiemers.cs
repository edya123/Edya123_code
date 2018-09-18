using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day8
{
    class PirmaisPiemers
    {
        public void DarbibaArMasivu()
        {
            // ..
            // viendimensiju masivs
            // ta lai cilveks pats ievada vertibas
            // masiva garums - 4
            // vertibas cilvekam ir jaievada, kamer vins izvelas, ka to negrib
            // ievadam 1 vertibu un katras ievades beigas izvadas viss masivs
            // parrakstam vertibas

            //int mainigais = 4;
            //int[] jaunsMasivs = new int[mainigais];

            //for (int i = 0; i < jaunsMasivs.Length; i++)
            //{
            //    Console.WriteLine("Ievadiet masiva vertibas");
            //    String vertiba = Console.ReadLine();

            //    int masivaVertiba = Convert.ToInt16(vertiba);
            //    jaunsMasivs[i] = masivaVertiba;

            //    for (int j = 0; j < jaunsMasivs.Length; j++)
            //    {
            //        Console.Write(jaunsMasivs[j]);
            //    }
            //}

            String[] vienaDimensija = new string[4];
            String ievade = "";
            while (ievade != "iziet")
            {
                for (int i = 0; i < vienaDimensija.Length; i++)
                {
                    Console.WriteLine("Ievadiet vertibu vai iziet!");
                    ievade = Console.ReadLine();
                    if(ievade == "iziet")
                    {
                        break;
                    }
                    vienaDimensija[i] = ievade;
                    for (int j = 0; j < vienaDimensija.Length; j++)
                    {
                        Console.Write(vienaDimensija[j]);
                    }
                    Console.WriteLine();
                }
            }
        }
        public void Stripas()
        {
            String[] stripinas = new string[4];
            for(int i = 0; i < 4; i++)
            {
                stripinas[i] = "-";
                Console.Write(stripinas[i]);
            }

            for (int i = 0; i < 4; i++)
            {

            }
        }
    }
}