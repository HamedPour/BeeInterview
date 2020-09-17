using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeeInterview
{
    abstract class Bee
    {
        private float Health { get; set; }
        public bool IsAlive { get; set; }
        public virtual float DamageLimit { get; set; }
        public Bee()
        {
            Health = 100;
            IsAlive = true;
        }

        public void Damage(float amount)
        {
            if (!IsAlive) return;
            if (amount > 100 || amount < 0)
            {
                Console.WriteLine("Damage must be between 0 and 100.");
                return;
            }
            if (Health <= DamageLimit)
            {
                IsAlive = false;
                Console.WriteLine("The Bee is Dead!");
                return;
            }
            Health -= amount;
        }

        public float getHealth()
        {
            return Health;
        }

    }
}
