using System;
using Helpers;

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


        public static void P11()
        {
            //Afisati in ordine inversa cifrele unui numar n. 

            string str = "", reverse = "";
            int Length = 0;
            Console.WriteLine("introduceti un numar pentru a-l citi invers : ");
            str = Console.ReadLine();

            Length = str.Length -1;

            while(Length >= 0)
            {
                reverse = reverse + str[Length];
                Length--;
            }

            Console.WriteLine("numarul citit invers este {0}", reverse);

        }

        public static void P12()
        {
            //Determinati cate numere intregi divizibile cu n se afla in intervalul [a, b]. 

            var count = 0;

            Console.WriteLine("introduceti valoarea lui n");
            var n = float.Parse(Console.ReadLine());
        
            Console.WriteLine("introduceti valoarea lui a");
            var a = float.Parse(Console.ReadLine());
            
            Console.WriteLine("introduceti valoarea lui b");
            var b = float.Parse(Console.ReadLine());

            if ( a > b)
            {
                (a, b) = (b, a);
            }

            for (var i = a; i <= b; i++)
           {
            if (i % n == 0)
            count ++;
           } 

            Console.WriteLine(count != 1
                ?$"in intervalul [{a}, {b}] exista {count} numere divizibile cu {n}"
                :$"in intervalul [{a}, {b}] exista doar {count} care este divizibil cu {n}");
        }






        public static void P13()
        {
            //Determianti cati ani bisecti sunt intre anii y1 si y2.

            // Console.WriteLine("introduceti un an pentru a vedea daca este bisect sau nu:");
            // float an;
            // an = float.Parse(Console.ReadLine());
            // if ((an % 4 == 0) && (an % 100 != 0) || (an % 400 == 0))
            // {
            //     Console.WriteLine($"anul {an} este un an bisect", an);
            // } else
            // {
            //     Console.WriteLine($"{an} nu este un an bisect");



            
            
            Console.WriteLine("introduceti valoarea lui y1:");
            var y1 = int.Parse(Console.ReadLine());
            
            Console.WriteLine("introduceti valoarea lui y2:");
            var y2 = int.Parse(Console.ReadLine());
            


            if ( y1 > y2)
            {
                y1 += y2;
                y2 = y1 -y2;
                y1 =- y2;
            }

            var count = 0;

            for (var i= y1; i <= y2; i++)
            {
                if (ProbHelper.isLeap(i)) count ++;
            }

            Console.WriteLine( count == 1
                ? $"in intervalul {y1} - {y2} exista {count} an bisect"
                : $"in intervalul {y1} - {y2} exista {count} ani bisecti"
                );



        }


        public static void P14()
        {
            //Determianti daca un numar n este palindrom. (un numar este palindrom daca citit invers obtinem un numar egal cu el, de ex. 121 sau 12321. 


            int n, r, sum = 0, t;

            Console.WriteLine("introduceti un numar pentru a vedea daca este palindrom");
            n=int.Parse(Console.ReadLine());
            t = n;

            while (n > 0)
            {
                r = n % 10;
                sum = (sum * 10) + r;
                n = n / 10;
            }

            if (t == sum)
            {
                Console.WriteLine("numarul ales este palindrom");
            }
            else 
            {
                Console.WriteLine("numarul ales nu este palindrom");
            }

        }


        public static void P15()
        {
            // Se dau 3 numere. Sa se afiseze in ordine crescatoare. 
            int a,b,c;

            Console.WriteLine("introduceti valoarea primului numar");
            a = int.Parse(Console.ReadLine());
            
            Console.WriteLine("introduceti valoarea celui de al doilea numar");
            b = int.Parse(Console.ReadLine());
            
            Console.WriteLine("introduceti valoarea celui de al treilea numar");
            c = int.Parse(Console.ReadLine());

            var n = Math.Min(a,b);
            b = Math.Max(a,b);
            a = n;

            n = Math.Min(b,c);
            c = Math.Max(b,c);
            b = n;

            Console.WriteLine($"ordinea crescatoare a numerelor este {a},{b},{c}");

        }


        public static void P16()
        {
            //Se dau 5 numere. Sa se afiseze in ordine crescatoare. (nu folositi tablouri)

            int a,b,c,d,e;

            Console.WriteLine("introduceti valoarea primului numar");
            a = int.Parse(Console.ReadLine());
            
            Console.WriteLine("introduceti valoarea celui de al doilea numar");
            b = int.Parse(Console.ReadLine());
            
            Console.WriteLine("introduceti valoarea celui de al treilea numar");
            c = int.Parse(Console.ReadLine());
            
            Console.WriteLine("introduceti valoarea celui de al patrulea numar");
            d = int.Parse(Console.ReadLine());
            
            Console.WriteLine("introduceti valoarea celui de al cincilea numar");
            e = int.Parse(Console.ReadLine());



            var n = Math.Min(a,b);
            b = Math.Max(a,b);
            a = n;

            n = Math.Min(b,c);
            c = Math.Max(b,c);
            b = n;
            
            n = Math.Min(c,d);
            d = Math.Max(c,d);
            c = n;
            
            n = Math.Min(d,e);
            e = Math.Max(d,e);
            d = n;

        }


        public static void P17()
        {
            // Determianti cel mai mare divizor comun si cel mai mic multiplu comun a doua numere. Folositi algoritmul lui Euclid. 

            int a,b;

            Console.WriteLine("introduceti valoarea lui a");
            a = int.Parse(Console.ReadLine());
            
            Console.WriteLine("introduceti valoarea lui b");
            b = int.Parse(Console.ReadLine());

            Console.WriteLine($"cel mai mare div comun dintre {a} si {b} este {ProbHelper.greatDivisor(a,b)}" + $"iar cel mai mic divizor comun dintre {a}si {b} este {ProbHelper.smallDivisor(a,b)}");





        }


        public static void P18()
        {
            //Afisati descompunerea in factori primi ai unui numar n.  De ex. pentru n = 1176 afisati 2^3 x 3^1 x 7^2. 



        }


        public static void P19()
        {
            //


        }


        public static void P20()
        {
            //


        }


        public static void P21()
        {
            //Ghiciti un numar intre 1 si 1024 prin intrebari de forma "numarul este mai mare sau egal decat x?". 


            Random random = new Random();
            bool playAgain = true;
            int guess, number, guesses;
            String response;

            while (playAgain == true)
            {
                guess = 0;
                guesses = 0;
                response = "";
                number = random.Next(1, 1024);

                while(guess != number)
                {
                    Console.WriteLine("ghiceste un numarul din intervalul 1, 1024");
                    guess = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("numarul ales este:" + guess);

                    if (guess > number)
                    {
                        Console.WriteLine(guess + "este prea mare");

                    }
                    else if(guess < number)
                    {
                        Console.WriteLine(guess + "este prea mic");
                    }

                    guesses++;
                }
                Console.WriteLine("numarul :" + number);
                Console.WriteLine("ai castigat :");
                Console.WriteLine("ghiciri:" + guesses);

                Console.WriteLine("ai mai vrea sa joci o runda? (apasa D pentru a juca o noua runda)");
                response = Console.ReadLine();
                response = response.ToUpper();

                if (response  == "D")
                {
                    playAgain = true;
                }
                else
                {
                    playAgain = false;
                }
            }

            Console.WriteLine("jocul s-a incheiat");



            Console.ReadKey();

        }

        
    }
}
