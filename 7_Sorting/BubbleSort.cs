﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7_Sorting
{
    /// <summary>
    /// 冒泡排序
    /// </summary>
    public class BubbleSort
    {
        /// <summary>
        /// 
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="input"></param>
        public void Sort<T>(IList<T> input) where T : IComparable
        {
            for (int i = 0; i < input.Count - 1; i++)
            {
                for (int j = 1; j < input.Count - i; j++)
                {
                    if (input[j - 1].CompareTo(input[j]) > 0)
                    {
                        T tmp = input[j - 1];
                        input[j - 1] = input[j];
                        input[j] = tmp;
                    }
                }
            }
        }
    }
}
