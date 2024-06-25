using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UcenjeCS
{
    internal class E02VarijableTipoviPodataka
    {





        public static void Izvedi()
        {


            //deklaracija varijable

            int i;

            //dodjeljivanje vrijednosti
            i = 7;

            //korištenje varijable
            Console.WriteLine(i);

            Console.Write("Molim upisati cijeli broj veći od nule: ");
            int broj = int.Parse(Console.ReadLine());

            Console.WriteLine(broj + 1);

            //za decimalne brojeve ćemo koristiti float

            Console.WriteLine("Unesi decimalni broj (, je oznaka za decimalni broj): ");

            Console.WriteLine(float.Parse(Console.ReadLine()) + 1);


            //logička vrijednost je bool

            bool uvjet = false;


            Console.WriteLine(uvjet);

            //operatori za rad s varijablama
            //= , +, -, * , /
            // == operator uspoređivanja, tipa bool
            //!= različito, tipa bool

            int j = 3;

            Console.WriteLine(j == 3);

            Console.WriteLine(j != 6);

            //increment i  decrement

            i = 0;
            i = i + 1;
            i += 1;
            i++; //prvo koristi pa uvećaj
            ++i; //prvo uvećaj pa koristi


            i = 1;

            Console.WriteLine(i++); //1
            Console.WriteLine(i); //2
            Console.WriteLine(++i); //3
            Console.WriteLine(i); //3

            //dekrement je ista stvar samo u minus
            i--;
            --i;

            //prekrasni zadaci
            int x = 0, y = 1;
            x = ++x - y; //x = 0, y = 1
            y = x-- + y; //x = -1 , y = 1
            Console.WriteLine(x + y); // 0


            // prvo na početku dvosatnog vježbanja si zadati zadatak
            // na kraju dvosatnig vježbanja rješiti ga


            // operator modulo (%)

            Console.WriteLine("9%2 = {0}", 9 % 2);
            Console.WriteLine("8%2 = {0}", 8 % 2);

            x = 5;
            y = 2;

            //int/int = int
            // mora se raditi cast

            Console.WriteLine(x/(float)y); // (float) cast u tip podatka float



        }










    }
}
