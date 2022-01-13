using System;
using ProblemeFP_SET3;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace SortHelper
{
    public static class Sorter
    {

        // public static IList<T> RotateLeft<T>(int positions, IList<T> list)
        // {
        //     while (positions > 0)
        //     {
        //         list = RotateLeft(list);
        //         positions--;
        //     }

        //     return list;
        // }




        public static IList<int> SelectionSort(IList<int> list)
        {
            for (var i = 0; i < list.Count; i++)
            {
                var smallest = i;
                for (var j = i + 1; j < list.Count; j++)
                {
                    if (list[j] < list[smallest])
                    {
                        smallest = j;
                    }
                }

                (list[smallest], list[i]) = (list[i], list[smallest]);
            }

            return list;
        }
    }
}