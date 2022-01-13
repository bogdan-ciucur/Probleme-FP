using System;
using Helpers;


namespace ProblemeFP_SET2 
{
    public class Set2
    {
        public static void P1()
        {
            //Se da o secventa de n numere. Sa se determine cate din ele sunt pare. 
            int n;
            Console.WriteLine("introduceti valoarea lui n");
            n=int.Parse(Console.ReadLine());

            var count = 0;

            Console.WriteLine("introduceti elementele secventei");

            for (var i = 0; i < n; i++)
            {
                int x;
                x = int.Parse(Console.ReadLine());

                if (x % 2 == 0) count ++;
            }

            Console.WriteLine(count != 1
                    ? $"{count} numerele din secventa sunt pare"
                    : $"{count} numarul din secventa este par");

        }

        public static void P2()
        {
            //Se da o secventa de n numere. Sa se determina cate sunt negative, cate sunt zero si cate sunt pozitive. 
            
            int n;
            Console.WriteLine("introduceti valoarea lui n");
            n = int.Parse(Console.ReadLine());

            var pozitiv  = 0;
            var negativ = 0;
            var zero = 0;



            Console.WriteLine("introduceti elementele secventei:");

            for (var i=0; i < n; i++)
            {
                int x;
                x = int.Parse(Console.ReadLine());
                if (x > 0)
                {
                    pozitiv++;
                }
                else if (x < 0)
                {
                    negativ++;
                }
                else
                {
                    zero++;
                }
            }



        }


        public static void P3()
        {
            //Calculati suma si produsul numerelor de la 1 la n. 

            int n;
            Console.WriteLine("introduceti valoarea lui n");
            n=int.Parse(Console.ReadLine());

            var sum = n * (n + 1) / 2;
            var prod = 1;

            for (var i = n; i > 0; i--)
            {
                prod *= i;
            }

            Console.WriteLine($"Suma numerelor de la 1 la {n} este {sum}, iar produsul este {prod}.");

        }


        public static void P4()
        {
            //Se da o secventa de n numere. Determinati pe ce pozitie se afla in secventa un numara a. Se considera ca primul element din secventa este pe pozitia zero. Daca numarul nu se afla in secventa raspunsul va fi -1. 

            int n,a;

            Console.WriteLine("introduceti valoarea lui n:");
            n=int.Parse(Console.ReadLine());            

            Console.WriteLine("introduceti valoarea lui a:");
            a=int.Parse(Console.ReadLine());            

            Console.WriteLine(" introduceti elementele secventei");

            for (var i = 0; i < n; i++)
            {
                int x;
                x=int.Parse(Console.ReadLine());
                if (x != a) continue;

                Console.WriteLine($"numarul {a} se afla pe locul {i}");
            }

            Console.WriteLine($"numarul {a} nu se gaseste");

        }


        public static void P5()
        {
            //Cate elemente dintr-o secventa de n numere sunt egale cu pozitia pe care apar in secventa. Se considera ca primul element din secventa este pe pozitia 0. 





        }


        public static void P6()
        {
            //Se da o secventa de n numere. Sa se determine daca numerele din secventa sunt in ordine crescatoare. 

            int n;
            Console.WriteLine("introduceti valoarea lui n");
            n=int.Parse(Console.ReadLine());

            var count = 0;

            int prev;
            prev = int.Parse(Console.ReadLine());

            bool first = true;

            Console.WriteLine("introduceti elementele secventei");

            for (var i= 1; i < n; i++)
            {
                int curr;
                curr = int.Parse(Console.ReadLine());

                if (curr == prev + 1)
               {
                   count += first ? 2 : 1;
                   first = false;
               } 
               else 
               {
                   first = true;
               }

                prev = curr;

            }

            Console.WriteLine($"in secventa data numerele sunt in ordine crescatoare ");

        }


        public static void P7()
        {
            //Se da o secventa de n numere. Sa se determine cea mai mare si cea mai mica valoare din secventa. 

            int n;
            Console.WriteLine("iintroduceti valoarea lui n:");
            n=int.Parse(Console.ReadLine());

            Console.WriteLine("introduceti elementele secventei:");

            int min, max;

            min = int.Parse(Console.ReadLine());

            max = min;

            for (var i = 1; i < n; i++)
            {
                int x;
                x=int.Parse(Console.ReadLine());

                if(x > max) max = x;
                if(x < min) min =x;
            }

            Console.WriteLine($"cea mai mica valoare in interval este {min}, iar cea mai mare este {max}");

        }


        public static void P8()
        {
            //Determianti al n-lea numar din sirul lui Fibonacci. Sirul lui Fibonacci se construieste astfel: f1 = 0, f2 = 1, f_n = f_(n-1) + f(n-2). Exemplu: 0, 1, 1, 2, 3, 5, 8 ...

        }


        public static void P9()
        {
            //Sa se determine daca o secventa de n numere este monotona. Secventa monotona = secventa monoton crescatoare sau monoton descrescatoare. 

        }


        public static void P10()
        {
            //Se da o secventa de n numere. Care este numarul maxim de numere consecutive egale din secventa. 

        }


        public static void P11()
        {
            //Se da o secventa de n numere. Se cere sa se caculeze suma inverselor acestor numere. 

        }


        public static void P12()
        {
            //Cate grupuri de numere consecutive diferite de zero sunt intr-o secventa de n numere. Considerati fiecare astfel de grup ca fiind un cuvant, zero fiind delimitator de cuvinte. De ex. pentru secventa 1, 2, 0, 3, 4, 5, 0, 0, 6, 7, 0, 0 raspunsul este 3. 


            int n;
            Console.WriteLine("introdceti valoarea lui n");
            n = int.Parse(Console.ReadLine());

            Console.WriteLine("introduceti elementelee secventei");

            int prev;
            prev = int.Parse(Console.ReadLine());

            var count = 0;
            bool seq = false;

            for (var i = 1; i < n; i++)
            {
                int crt;
                crt = int.Parse(Console.ReadLine());

                if (prev == 0)
                {
                    prev = crt;
                    continue;
                }

                if (crt == 0)
                {
                    prev = crt;
                    seq = false;
                    continue;
                }

                if (crt ==prev +1)
                {
                    if (seq)
                    {
                        prev = crt;
                        continue;
                    }
                    count++;
                    seq = true;
                }
                else{
                    seq = false;
                }
                prev = crt;
            }

            Console.WriteLine($"nr grupelor de nr consecutive dif de 0 este {count}");
        }


        public static void P13()
        {
            //O <secventa crescatoare rotita> este o secventa de numere care este in ordine crescatoare sau poate fi transformata intr-o secventa in ordine crescatoare prin rotiri succesive (rotire cu o pozitie spre stanga = toate elementele se muta cu o pozitie spre stanga si primul element devine ultimul). Determinati daca o secventa de n numere este o secventa crescatoare rotita. 

        }


        public static void P14()
        {
            //O <secventa monotona rotita> este o secventa de numere monotona sau poate fi transformata intr-o secventa montona prin rotiri succesive. Determinati daca o secventa de n numere este o secventa monotona rotita. 

        }


        public static void P15()
        {
            //O secventa bitonica este o secventa de numere care incepe monoton crescator si continua monoton descrecator. De ex. 1,2,2,3,5,4,4,3 este o secventa bitonica. Se da o secventa de n numere. Sa se determine daca este bitonica. 

        }


        public static void P16()
        {
            //O <secventa bitonica rotita> este o secventa bitonica sau una ca poate fi transformata intr-o secventa bitonica prin rotiri succesive (rotire = primul element devine ultimul). Se da o secventa de n numere. Se cere sa se determine daca este o secventa bitonica rotita. 

        }


        public static void P17()
        {
            //Se da o secventa de 0 si 1, unde 0 inseamna paranteza deschisa si 1 inseamna paranteza inchisa. Determinati daca secventa reprezinta o secventa de paranteze corecta si,  daca este, determinati nivelul maxim de incuibare a parantezelor. De exemplu 0 1 0 0 1 0 1 1 este corecta si are nivelul maxim de incuibare 2 pe cand 0 0 1 1 1 0 este incorecta. 

        }
    }
}