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

            Console.WriteLine(q.getHealth());
            q.Damage(30);
            Console.WriteLine(q.getHealth());
            q.Damage(10);
            Console.WriteLine(q.getHealth());
            q.Damage(40);
            Console.WriteLine(q.getHealth());
            q.Damage(60);
            Console.WriteLine(q.getHealth());
            q.Damage(60);
            Console.WriteLine(q.getHealth());


            Console.ReadLine();
        }
    }
}
