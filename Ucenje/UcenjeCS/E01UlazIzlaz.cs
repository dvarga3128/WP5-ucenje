using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UcenjeCS
{
    internal class E01UlazIzlaz
    {

        public static void Izvedi()
        {

            Console.WriteLine("Hello");

            Console.Write("Upiši svoje ime: ");

            string ime = Console.ReadLine();

            Console.WriteLine("Unijeli ste " + ime);
            //formatirani način zapisa
            Console.WriteLine("Unijeli ste {0}", ime);


            //adresa i grad

            Console.Write("Unesi adresu: ");

            string adresa = Console.ReadLine();

            Console.Write("Unesi grad: ");

            string grad = Console.ReadLine();


            Console.WriteLine("Unijeli ste " + adresa);
            Console.WriteLine("Unijeli ste " + grad);






        }
    }
}
