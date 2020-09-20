using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeeInterview
{
    class Program
    {
        static void Main(string[] args)
        {

            Queen q = new Queen();

            q.TakeDamage(10);
            Console.WriteLine(q.Health);
            q.TakeDamage(10);
            Console.WriteLine(q.Health);
            q.TakeDamage(10);
            Console.WriteLine(q.Health);
            q.TakeDamage(10);
            Console.WriteLine(q.Health);

            Console.ReadLine();
        }
    }
}
