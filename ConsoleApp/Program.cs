using System;
using System.Collections.Generic;
using static System.Console;

namespace ConsoleApp
{
    static class Program
    {
        static void Main(string[] args)
        {
            IEnumerable<int> nums = new List<int> {1, 2, 3};
            nums.Map(x => x * 3)
                .Filter(x => x % 2 == 1)
                .Each(WriteLine);
        }


        private static IEnumerable<T> Map<T>(this IEnumerable<T> list, Func<T, T> mapper)
        {
            foreach (var iter in list)
            {
                WriteLine("Map : " + iter);
                yield return mapper(iter);
            }
        }

        private static IEnumerable<T> Filter<T>(this IEnumerable<T> list, Func<T, bool> predicate)
        {
            foreach (var iter in list)
            {
                WriteLine("Filter : " + iter);
                if (predicate(iter))
                {
                    yield return iter;
                }
            }
        }

        private static void Each<T>(this IEnumerable<T> list, Action<T> action)
        {
            foreach (var iter in list)
            {
                WriteLine("Each : " + iter);
                action(iter);
            }
        }
    }
}