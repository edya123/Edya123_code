using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day10
{
    class Karatavas
    {

        private char[] paraugs = new char[] { 'p', 'r', 'o', 'g', 'r', 'a', 'm', 'm', 'e', 's', 'a', 'n', 'a' };

        public void Menu()
        {
            Sakums();
            Salidzinasana();
            Console.ReadLine();
        }

        private void Sakums()
        {
            char[] vards = new char[13];

            for (int i = 0; i < 13; i++)
            {
                vards[i] = '_';
                Console.Write(vards[i] + " ");
            }
        }

        private void Salidzinasana()
        {
            Char[] paraugs = new Char[13];
            for (int i = 0; )
            {
                if (paraugs = Ievade())
                {
                    paraugs[i] = ;
                }
                else
                {
                    ;
                }

            }
        }

        //        String[] vii = new String[8];
        //            for(int i = 0; i<vii.Length; i++)
        //            {
        //                if (i % 2 == 0)
        //                {
        //                    vii[i] = "*";
        //                }
        //                else
        //                {
        //                    vii[i] = "#";
        //                }
        //Console.Write(vii[i] + " ");
        //            }

        private char Ievade()
        {
            Console.WriteLine("Ievadiet vardu");
            String simboli = Console.ReadLine();
            char result = Convert.ToChar(simboli);
            return result;
        }
    }
}
