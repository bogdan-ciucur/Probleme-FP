using System;
using ProblemeFP_SET3;


namespace Helpers
{
    public static class ProbHelper
    {
        public static bool isLeap (int year)
        {
            return year % 400 == 0 || year % 4 == 0 && year % 100 != 0;
        }


        public static int greatDivisor(int first, int second)
        {


            if (first < second)
            {
                (first, second) = (second, first);
            }

            while (second != 0)
            {
                var r = first % second;
                first = second;
                second = r;
            }

            return first;
        }


        public static int smallDivisor(int first, int second)
        {
            var x = first;
            var y = second;
            
            while (x != y)
            {
                if (x < y)
                {
                    x += first;
                }

                if (x > y)
                {
                    y += second;
                }

            }
                return x;
        }

        
        public static int[] ArrHelp(int length)
        {
            var next = new int[length];

            outsideLoop: while (true)
            {
                var input = Console.ReadLine();

                if (input == null)
                {
                    Console.WriteLine("Te rugam sa te asiguri ca sirul contine valori de tip intreg separate printr-un spatiu!");
                    continue;
                }
                
                var split = input.Split(' ');
                if (split.Length != length)
                {
                    Console.WriteLine($"Sirul trebuie sa aiba {length} element(e)!");
                    continue;
                }

                for (var i = 0; i < split.Length; i++)
                {
                    var str = split[i];

                    if (!int.TryParse(str, out var number))
                    {
                        Console.WriteLine("Te rugam sa te asiguri ca sirul contine valori de tip intreg separate printr-un spatiu!");
                        goto outsideLoop;
                    }

                    next[i] = number;
                }

                break;
            }

            return next;
        }



    }
} 