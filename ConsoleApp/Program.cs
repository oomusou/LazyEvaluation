using System.Collections.Generic;
using System.Linq;
using static System.Console;

namespace ConsoleApp
{
    static class Program
    {
        static void Main(string[] args)
        {
            IEnumerable<int> nums = new List<int> {1, 2, 3};
            nums.Select(x => x * 3)
                .Where(x => x % 2 == 1)
                .ToList()
                .ForEach(WriteLine);
        }
    }
}