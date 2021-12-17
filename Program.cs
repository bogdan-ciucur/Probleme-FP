using System;

namespace ProblemeFP_SET1
{
    public class Set1
    {
        public static void P1()
        {
            // Rezolvati ecuatia de gradul 1 cu o necunoscuta: ax+b = 0, unde a si b sunt date de intrare. 

            float a, b, x;
		Console.WriteLine("introduceti valoarea lui a: ");
		a = float.Parse(Console.ReadLine());
		Console.WriteLine("introduceti valoarea lui b: ");
		b = float.Parse(Console.ReadLine());

		if (a == 0)
        {
			if (b == 0) Console.WriteLine("solutii infinite!");
			else Console.WriteLine("nu exista solutii!");
        }
        else
        {
			x = (-b) / a;
			Console.WriteLine("solutia lui x este = {0}", x);
        }
        }


        public static void P2()
        {
            //Rezolvati ecuatia de gradul 2 cu o necunoscuta: ax^2 + bx + c = 0, unde a, b si c sunt date de intrare. Tratati toate cazurile posibile. 

            
            float a, b, c;
            Console.WriteLine("introduceti valoarea lui a");
            a = float.Parse(Console.ReadLine());

            Console.WriteLine("introduceti valoarea lui b");
            b = float.Parse(Console.ReadLine());

            Console.WriteLine("introduceti valoarea lui c");
            c = float.Parse(Console.ReadLine());

            var delta = b * b - 4 * a * c;

            if (delta > 0)
            {
                var x1 =(-b + Math.Sqrt(delta)) / (2 *a); 
                var x2 =(-b - Math.Sqrt(delta)) / (2 *a); 

                Console.WriteLine($"doua solutii posibile: {0}, {1}", x1, x2);

            } else if (delta < 0)
            {

                delta = -delta;
                var x = -b / (2 * a);
                var i = Math.Sqrt(delta) / (2 *a);

                Console.WriteLine($"doua solutii posibile: {0} + {1} *i , {2} + {3} * i", x, i, x, i);

            }else
            {
                var x = -b / (2 * a);
                Console.WriteLine($"o singura solutie : {0}", x);
            }
        }


        public static void P3()
        {
            //Determinati daca n se divide cu k, unde n si k sunt date de intrare. 

            float n, k;
            Console.WriteLine("introduceti valoarea lui n:");
            n = float.Parse(Console.ReadLine());

            Console.WriteLine("introduceti valoarea lui k:");
            k = float.Parse(Console.ReadLine());

            if (n % k == 0)
            {
                Console.WriteLine($"{n} il divide pe {k}", n, k);
            }else
            {
                Console.WriteLine("n nu il divide pe k");
            }

        }


        public static void P4()
        {
            //Detreminati daca un an y este an bisect. 

            Console.WriteLine("introduceti un an pentru a vedea daca este bisect sau nu:");
            float an;
            an = float.Parse(Console.ReadLine());
            if ((an % 4 == 0) && (an % 100 != 0) || (an % 400 == 0))
            {
                Console.WriteLine($"anul {an} este un an bisect", an);
            } else
            {
                Console.WriteLine($"{an} nu este un an bisect");
            }

        }

        public static void P5()
        {
            //Extrageti si afisati a k-a cifra de la sfarsitul unui numar. Cifrele se numara de la dreapta la stanga. 

            Console.WriteLine("introduceti valoarea lui n");
            float n, k;
            n = float.Parse(Console.ReadLine());

            Console.WriteLine("introduceti valoarea lui k");
            k = float.Parse(Console.ReadLine());
            
            if (k > n || k == n)
            {
                Console.WriteLine($"operatiunea nu a putut fi efectuata, deoarece numarul nu are {n} cifre disponibile", n);
            } else 
            {
                var x = (int) Math.Pow(10, k-1);
                var figure = n / x % 10;

                Console.WriteLine(k != 1
                    ? $"a {k} a cifra a numarului {n} este: {figure}"
                    : $"prima cifra a numarului {n} este {figure}");
            }
        }


        public static void P6()
        {
            //Detreminati daca trei numere pozitive a, b si c pot fi lungimile laturilor unui triunghi. 

            float a, b, c;

            Console.WriteLine("introduceti valoarea laturii a:");
            a = float.Parse(Console.ReadLine());

            Console.WriteLine("introduceti valoarea laturii b:");
            b = float.Parse(Console.ReadLine());
            
            Console.WriteLine("introduceti valoarea laturii c:");
            c = float.Parse(Console.ReadLine());

            if (a <= 0 || b <= 0 || c <= 0)
            {
                Console.WriteLine("latura triunghiului nu poate fi mai maica sau egala cu 0");
            } else
            {
                Console.WriteLine($"numerele {a}, {b}, {c} formeaza un triunghi", a, b, c);
            }
        }

        public static void P7()
        {
            //(Swap) Se dau doua variabile numerice a si b ale carori valori sunt date de intrare. Se cere sa se inverseze valorile lor. 

            float a, b, x;

            Console.WriteLine("introduceti valoarea lui a:");
            a = float.Parse(Console.ReadLine());

            Console.WriteLine("introduceti valoarea lui b:");
            b = float.Parse(Console.ReadLine());

            x = a;
            a = b;
            b = x;

            Console.WriteLine($"valoarea lui a dupa swap este {a} si valoarea lui b dupa swap este {b}");

        }

        public static void P8()
        {
            //(Swap restrictionat) Se dau doua variabile numerice a si b ale carori valori sunt date de intrare. Se cere sa se inverseze valorile lor fara a folosi alte variabile suplimentare.  

            float a, b;

            Console.WriteLine("introduceti valoarea lui a:");
            a = float.Parse(Console.ReadLine());

            Console.WriteLine("introduceti valoarea lui b:");
            b = float.Parse(Console.ReadLine());

            (a, b) = (b, a);

            Console.WriteLine($"valoarea lui a dupa swap este {a}, iar valoarea lui b este {b}");


        }


        public static void P9()
        {
            //Afisati toti divizorii numarului n. 
            

            float num;
            Console.WriteLine("introduceti un numar pentru a-i afla divizorii");

            num = float.Parse(Console.ReadLine());

            Console.WriteLine($"divizorii numarului {num} sunt : ", num);

            for(int divisor = 1; divisor <= num; divisor++)
            {
                if ((num % divisor) == 0)
                {
                    Console.WriteLine($"{divisor}", divisor);
                }
            }
        }

        public static void P10()
        {
            //Test de primalitate: determinati daca un numar n este prim.

            float n;
            Console.WriteLine("introduceti un numar pentru a vedea daca este prim sau nu");

            n = float.Parse(Console.ReadLine());

            if (n <= 1)
            {
                Console.WriteLine("numarul ales nu e prim");
            };

            for (int i = 2; i < n; i++)
            {
                if (n % i == 0)
                {
                    Console.WriteLine("numarul ales este prim");
                    return;
                }
            }

            // Console.WriteLine(n + "este numar prim");

            
        }

    }
}
