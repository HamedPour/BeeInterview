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

            q.Damage(30);
            Console.WriteLine(q.getHealth());
            Console.WriteLine(q.IsAlive);
            q.Damage(10);
            Console.WriteLine(q.IsAlive);

            Console.ReadLine();
        }
    }
}
