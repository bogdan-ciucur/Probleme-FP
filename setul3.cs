using System;
using Helpers;
using System.Linq;
using SortHelper;
using System.Text; 


namespace ProblemeFP_SET3 
{
    public class Set3
    {
        public static void P1()
        {
            //Calculati suma elementelor unui vector de n numere citite de la tastatura. Rezultatul se va afisa pe ecran.


            int[] a= new int[100];

            int i, n, sum = 0;

            Console.WriteLine("introduceti numarul de elemente din array:");
            n = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("array-ul are {0} elemente", n);

            for (i = 0; i < n; i++)
            {
                Console.WriteLine("numarul {0} este 1:", i);
                a [i] = Convert.ToInt32(Console.ReadLine());
            }

            for (i=0; i<n; i++)
            {
                sum += a[i];
            }

            Console.WriteLine("suma este {0}", sum);

            

        }

        
        public static void P2()
        {
            //Se da un vector cu n elemente si o valoare k. Se cere sa se determine prima pozitie din vector pe care apare k. Daca k nu apare in vector rezultatul va fi -1. 

            int[] a= new int[100];

            int i, j= 0;

            Console.WriteLine("introduceti numarul de elemente din array:");
            j = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("array-ul are {0} elemente", j);

            for (i = 0; i < j; i++)
            {
                Console.WriteLine("numarul {0} este 1:", i);
                a [i] = Convert.ToInt32(Console.ReadLine());
            }

            int k;
            Console.WriteLine("introduceti valoarea lui n");
            k=int.Parse(Console.ReadLine());

            for (i = 0; i < j; i++) {
                if (a[i] == k) 
                {
                break;
                }
            }

            if (i == j) {
                Console.WriteLine("-1");
            } else 
            {
                Console.WriteLine("array ul contine numarul introdus");
            }



        }

        
        public static void P3()
        {
            //Sa se determine pozitiile dintr-un vector pe care apar cel mai mic si cel mai mare element al vectorului. Pentru extra-credit realizati programul efectuand 3n/2 comparatii (in cel mai rau caz). 


            int[] a= new int[100];

            int i, j;

            Console.WriteLine("introduceti numarul de elemente din array:");
            j = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("array-ul are {0} elemente", j);

            for (i = 0; i < j; i++)
            {
                Console.WriteLine("numarul {0} este 1:", i);
                a [i] = Convert.ToInt32(Console.ReadLine());
            }

            int max = a.Max();
            int min = a.Min();

            Console.WriteLine($"cea mai mica valoare este: {min}");
            Console.WriteLine($"cea mai mare valoare este: {max}");




        }

        
        public static void P4()
        {
            //Deteminati printr-o singura parcurgere, cea mai mica si cea mai mare valoare dintr-un vector si de cate ori apar acestea. 

            int[] a= new int[100];

            int i, j;

            Console.WriteLine("introduceti numarul de elemente din array:");
            j = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("array-ul are {0} elemente", j);

            for (i = 0; i < j; i++)
            {
                Console.WriteLine("numarul {0} este 1:", i);
                a [i] = Convert.ToInt32(Console.ReadLine());
            }

            int max = a.Max();
            int min = a.Min();

            
            Console.WriteLine($"cea mai mica valoare este: {min}");
            Console.WriteLine($"cea mai mare valoare este: {max}");



        }

        
        public static void P5()
        {
            //Se da un vector cu n elemente, o valoare e si o pozitie din vector k. Se cere sa se insereze valoarea e in vector pe pozitia k. Primul element al vectorului se considera pe pozitia zero. 

            int[] a= new int[100];

            int i, j;

            Console.WriteLine("introduceti numarul de elemente din array:");
            j = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("array-ul are {0} elemente", j);

            for (i = 0; i < j; i++)
            {
                Console.WriteLine("numarul {0} este 1:", i);
                a [i] = Convert.ToInt32(Console.ReadLine());
            }

            int e;
            Console.WriteLine("introduceti valoarea lui e;");
            e=int.Parse(Console.ReadLine());

            int k;
            Console.WriteLine("introduceti valoarea lui k;");
            k=int.Parse(Console.ReadLine());

            

        }

        
        public static void P6()
        {
            //Se da un vector cu n elemente si o pozitie din vector k. Se cere sa se stearga din vector elementul de pe pozitia k. Prin stergerea unui element, toate elementele din dreapta lui se muta cu o pozitie spre stanga. 



        }

        
        public static void P7()
        {
            //Reverse. Se da un vector nu n elemente. Se cere sa se inverseze ordinea elementelor din vector. Prin inversare se intelege ca primul element devine ultimul, al doilea devine penultimul etc.

            int[] a= new int[100];

           int i, j;

            Console.WriteLine("introduceti numarul de elemente din array:");
            j = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("array-ul are {0} elemente", j);

            for (i = 0; i < j; i++)
            {
                Console.WriteLine("numarul {0} este 1:", i);
                a [i] = Convert.ToInt32(Console.ReadLine());
            }

            Array.Reverse(a);


            Console.WriteLine($"ati inversat array ul cu success {a}");

        }

        
        public static void P8()
        {
            //Rotire. Se da un vector cu n elemente. Rotiti elementele vectorului cu o pozitie spre stanga. Prin rotire spre stanga primul element devine ultimul, al doilea devine primul etc. 



        }

        
        public static void P9()
        {
            //Rotire k. Se da un vector cu n elemente. Rotiti elementele vectorului cu k pozitii spre stanga. 



        }

        
        public static void P10()
        {
            //Cautare binara. Se da un vector cu n elemente sortat in ordine crescatoare. Se cere sa se determine pozitia unui element dat k. Daca elementul nu se gaseste in vector rezultatul va fi -1. 



        }

        
        public static void P11()
        {
            //Se da un numar natural n. Se cere sa se afiseze toate numerele prime mai mici sau egale cu n (ciurul lui Eratostene). 


            



        
        }

        

        
        public static void P12()
        {
            //Sortare selectie. Implementati algoritmul de sortare <Selection Sort>. 

            int[] a= new int[100];

            int o, p;

            Console.WriteLine("introduceti numarul de elemente din array:");
            p = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("array-ul are {0} elemente", p);

            for (o = 0; o < p; o++)
            {
                Console.WriteLine("numarul {0} este 1:", o);
                a [o] = Convert.ToInt32(Console.ReadLine());
            }




            Console.Write("array ul initial este: ");
            for (int i = 0; i < p; i++) 
            {
                Console.Write(a[i] + " ");
            }


            int temp, smallest;
            for (int i = 0; i < p - 1; i++) 
            {
                smallest = i;
                for (int j = i + 1; j < p; j++) 
                {
                        if (a[j] < a[smallest]) 
                    {
                        smallest = j;
                    }
                }
                temp = a[smallest];
                a[smallest] = a[i];
                a[i] = temp;
            }


            Console.WriteLine();
            Console.Write("array ul sortat este: ");
            for (int i = 0; i < p; i++) 
            {
                Console.Write(a[i] + " ");
            }


        }

        
        public static void P13()
        {
            //Sortare prin insertie. Implementati algoritmul de sortare <Insertion Sort>. 

            int[] a= new int[100];

            int o, p;

            Console.WriteLine("introduceti numarul de elemente din array:");
            p = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("array-ul are {0} elemente", p);

            for (o = 0; o < p; o++)
            {
                Console.WriteLine("numarul {0} este 1:", o);
                a [o] = Convert.ToInt32(Console.ReadLine());
            }



         int i, j, val, flag;
         Console.Write("Initial array is: ");
         for (i = 0; i < p; i++) 
         {
            Console.Write(a[i] + " ");
         }


         for (i = 1; i < p; i++) 
         {
            val = a[i];
            flag = 0;
            for (j = i - 1; j >= 0 && flag != 1; ) 
            {
               if (val < a[j]) 
                {
                  a[j + 1] = a[j];
                  j--;
                  a[j + 1] = val;
                }
               else flag = 1;
            }
         }
         Console.Write("\nSorted Array is: ");
         for (i = 0; i < p; i++) {
            Console.Write(a[i] + " ");
         }



        }

        
        public static void P14()
        {
            //Interschimbati elementele unui vector in asa fel incat la final toate valorile egale cu zero sa ajunga la sfarsit. (nu se vor folosi vectori suplimentari - operatia se va realiza inplace cu un algoritm eficient - se va face o singura parcugere a vectorului). 


            int[] a= new int[100];

            int o, p;

            Console.WriteLine("introduceti numarul de elemente din array:");
            p = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("array-ul are {0} elemente", p);

            for (o = 0; o < p; o++)
            {
                Console.WriteLine("numarul {0} este 1:", o);
                a [o] = Convert.ToInt32(Console.ReadLine());
            }



            if (p == 0)
            {

                for (int i=1; i>p; i++)
                {
                    Console.WriteLine("aveti {0} numere de 0",i);
                }

                Console.WriteLine("noul array este :{0}, {1}", a, p);

            }


        }

        
        public static void P15()
        {
            //Modificati un vector prin eliminarea elementelor care se repeta, fara a folosi un alt vector. 

            int[] a= new int[100];

            int o, p;

            Console.WriteLine("introduceti numarul de elemente din array:");
            p = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("array-ul are {0} elemente", p);

            for (o = 0; o < p; o++)
            {
                Console.WriteLine("numarul {0} este 1:", o);
                a [o] = Convert.ToInt32(Console.ReadLine());
            }

            
            var disArray = a.Distinct().ToArray();

            Console.WriteLine("noul array este: {0}",disArray);



        }

        
        public static void P16()
        {
            //Se da un vector de n numere naturale. Determinati cel mai mare divizor comun al elementelor vectorului.



            int[] a= new int[100];

            int o, p;

            Console.WriteLine("introduceti numarul de elemente din array:");
            p = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("array-ul are {0} elemente", p);

            for (o = 0; o < p; o++)
            {
                Console.WriteLine("numarul {0} este 1:", o);
                a [o] = Convert.ToInt32(Console.ReadLine());
            }



            int aa = 0, b = 0, gcd=0, t;
            for (int i = 0; i < a.Length - 1; i++)
            {
                aa = a[i];
                b = a[i + 1];

                while (b != 0)
                {
                    t = b;
                    b = aa % b;
                    aa = t;
                }

                gcd = aa;
                Console.Write("cel mai mare divizor este {0}",gcd);
            }
        }

            

        
        public static void P17()
        {
            //Se da un numar n in baza 10 si un numar b. 1 < b < 17. Sa se converteasca si sa se afiseze numarul n in baza b.   

            var number;
            int newBase;
            var copy = number;

            number = int.Parse(Console.ReadLine());
            newBase= int.Parse(Console.ReadLine());

            if (newBase < 2 || newBase < 16)
            {
                Console.WriteLine("baza trebuie sa fie intre 2 si 16");
                return;
            }


            StringBuilder builder = new StringBuilder();
            
            while (number > 0)
            {
                var remainder = number % newBase;
                number /= newBase;

                switch (remainder)
                {
                    case 10:
                        builder.Append("A");
                        break;
                    case 11:
                        builder.Append("B");
                        break;
                    case 12:
                        builder.Append("C");
                        break;
                    case 13:
                        builder.Append("D");
                        break;
                    case 14:
                        builder.Append("E");
                        break;
                    case 15:
                        builder.Append("F");
                        break;
                    default:
                        builder.Append(remainder);
                        break;
                }
            }

            Console.WriteLine($"{copy} (baza 10) in baza {newBase} is {string.Join("", builder.ToString().Reverse())}");

        }

        
        public static void P18()
        {
            //Se da un polinom de grad n ai carui coeficienti sunt stocati intr-un vector. Cel mai putin semnificativ coeficient este pe pozitia zero in vector. Se cere valoarea polinomului intr-un punct x. 



        }

        
        public static void P19()
        {
            //Se da un vector s (vectorul in care se cauta) si un vector p (vectorul care se cauta). Determinati de cate ori apare p in s. De ex. Daca s = [1,2,1,2,1,3,1,2,1] si p = [1,2,1] atunci p apare in s de 3 ori. (Problema este dificila doar daca o rezolvati cu un algoritm liniar). 

            int[] s= new int[100];

            int m, n;

            Console.WriteLine("introduceti numarul de elemente din primul array:");
            n = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("primul array are {0} elemente", n);

            for (m = 0; m < n; m++)
            {
                Console.WriteLine("numarul {0} este 1:", m);
                s [m] = Convert.ToInt32(Console.ReadLine());
            }


            

            int[] p= new int[100];

            int l, k;

            Console.WriteLine("introduceti numarul de elemente din al doilea array:");
            k = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("al dpilea array are {0} elemente", k);

            for (l = 0; l < k; l++)
            {
                Console.WriteLine("numarul {0} este 1:", l);
                p [l] = Convert.ToInt32(Console.ReadLine());
            }

            if (n > k)
            {
                Console.WriteLine("al doilea array nu poate fi mai mic");
            }

            if (n == k)
            {
                Console.WriteLine(s == p
                    ?"al doilea array apare o data"
                    :"al doilea array nu apare in primul");
                    return;
            }


            for (var i = 0; i < s.Length; i++)
            {
                if (i + p.Length > s.Length)
                {
                    break;
                }

                var seg = new ArraySegment<int>(s,i,i +p.Length);

                var rep = new ArraySegment<int>(s,i,i + p.Length).Count == p.Length;
            }

        }

        
        public static void P20()
        {
            //Se dau doua siraguri de margele formate din margele albe si negre, notate s1, respectiv s2. Determinati numarul de suprapuneri (margea cu margea) a unui sirag peste celalalt astfel incat margelele suprapuse au aceeasi culoare. Siragurile de margele se pot roti atunci cand le suprapunem. 



        }

        
        public static void P21()
        {
            //Se dau doi vectori. Se cere sa se determine ordinea lor lexicografica (care ar trebui sa apara primul in dictionar). 



        }

        
        public static void P22()
        {
            //Se dau doi vectori v1 si v2. Se cere sa determine intersectia, reuniunea, si diferentele v1-v2 si v2 -v1 (implementarea operatiilor cu multimi). Elementele care se repeta vor fi scrise o singura data in rezultat. 



        }

        
        public static void P23()
        {
            //Aceleasi cerinte ca si la problema anterioara dar de data asta elementele din v1 respectiv v2  sunt in ordine strict crescatoare. 



        }

        
        public static void P24()
        {
            //Aceleasi cerinte ca si la problema anterioara dar de data asta elementele sunt stocate ca vectori cu valori binare (v[i] este 1 daca i face parte din multime si este 0 in caz contrar).



        }

        
        public static void P25()
      {
            //(Interclasare) Se dau doi vector sortati crescator v1 si v2. Construiti un al treilea vector ordonat crescator format din toate elementele din  v1 si v2. Sunt permise elemente duplicate. 



        }

        
        public static void P26()
        {
            //Se dau doua numere naturale foarte mari (cifrele unui numar foarte mare sunt stocate intr-un vector - fiecare cifra pe cate o pozitie). Se cere sa se determine suma, diferenta si produsul a doua astfel de numere. 



        }

        
        public static void P27()
        {
            // Se da un vector si un index in vectorul respectiv. Se cere sa se determine valoarea din vector care va fi pe pozitia index dupa ce vectorul este sortat. 



        }

        
        public static void P28()
        {
            //Quicksort. Sortati un vector folosind metoda QuickSort. 

            int[] a= new int[100];

            int o, p;

            Console.WriteLine("introduceti numarul de elemente din array:");
            p = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("array-ul are {0} elemente", p);

            for (o = 0; o < p; o++)
            {
                Console.WriteLine("numarul {0} este 1:", o);
                a [o] = Convert.ToInt32(Console.ReadLine());
            }



         int i, j, val, flag;
         Console.Write("Initial array is: ");
         for (i = 0; i < p; i++) 
         {
            Console.Write(a[i] + " ");
         }


         for (i = 1; i < p; i++) 
         {
            val = a[i];
            flag = 0;
            for (j = i - 1; j >= 0 && flag != 1; ) 
            {
               if (val < a[j]) 
                {
                  a[j + 1] = a[j];
                  j--;
                  a[j + 1] = val;
                }
               else flag = 1;
            }
         }
         Console.Write("\nSorted Array is: ");
         for (i = 0; i < p; i++) {
            Console.Write(a[i] + " ");
         }

        }

        
        public static void P29()
        {
            //MergeSort. Sortati un vector folosind metoda MergeSort.



        }

        
        public static void P30()
        {
            //Sortare bicriteriala. Se dau doi vectori de numere intregi E si W, unde E[i] este un numar iar W[i] este un numar care reprezinta ponderea lui E[i]. Sortati vectorii astfel incat elementele lui E sa fie in in ordine crescatoare iar pentru doua valori egale din E, cea cu pondere mai mare va fi prima. 



        }

        
        public static void P31()
        {
            //(Element majoritate). Intr-un vector cu n elemente, un element m este element majoritate daca mai mult de n/2 din valorile vectorului sunt egale cu m (prin urmare, daca un vector are element majoritate acesta este unui singur).  Sa se determine elementul majoritate al unui vector (daca nu exista atunci se va afisa <nu exista>). (incercati sa gasiti o solutie liniara). 



        }

        
    }
}