using System;
using Upcasting.Models;

namespace Upcasting
{
    class Program
    {
        static void Main(string[] args)
        {


            byte m = 5;
            int n = m;

            Eagle eagle1 = new Eagle();
            Eagle eagle3 = new Eagle();
            Shark shark1 = new Shark();
            Animal shark2 = new Shark();
            Animal eagle2 = eagle1;

            Animal[] animals = {eagle1, eagle2, eagle3,shark1,shark2};
            foreach (var item in animals)
            {
                item.Eat();
            }
            

            



        }
    }
}
