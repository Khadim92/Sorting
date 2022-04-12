using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sorting
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> list = new List<int>() { 1,2,3,5,4};
            List<int> l2=list.OrderByDescending(x => x).ToList();
            foreach (int x in l2)
            {
                Console.WriteLine(x+" ");
            }
        }
    }
}
