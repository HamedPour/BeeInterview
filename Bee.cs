using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeeInterview
{
    abstract class Bee
    {
        private float Health { get; set; }
        public bool Dead { get; set; }
        public virtual float DamageLimit { get; set; }
        public Bee()
        {
            Health = 100;
            Dead = false;
        }

        public void Damage(float amount)
        {
            float percetage = amount / 100;
            // if the bee is dead don't bother with anything else and just return.
            if (Dead) return;
            // if the argument is not in range of 0 100, tell them and return.
            if (amount > 100 || amount < 0)
            {
                Console.WriteLine("Damage must be between 0 and 100.");
                return;
            }
            // if the bee has reached it's damage limit set Dead to true, return.
            if (Health <= DamageLimit)
            {
                Dead = true;
                Console.WriteLine("The Bee is Dead!");
                return;
            }
            // if you've gotten this fare apply the damage amount to bee's health.
            Health *= percetage;
        }

        public float getHealth()
        {
            return Health;
        }

    }
}
