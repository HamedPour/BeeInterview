using System;

namespace BeeInterview
{
    /// <summary>
    /// First, many thanks to Bizz for helping me with this!
    /// </summary>
    abstract class Bee
    {
        public float MaxHealth { get; } = 100;
        public float Health { get; private set; }
        public bool Dead { get; private set; }
        protected Bee()
        {
            Health = MaxHealth;
            Dead = false;
        }

        /// <summary>
        /// Method takes single int param between 0 and 100.
        /// </summary>
        /// <param name="percentageToReduce"></param>
        public abstract void Damage(float percentageToReduce);

        /// <summary>
        /// "Method that preforms the resuable logic of damaging a bee" - Bizz 2020
        /// </summary>
        /// <param name="percentageToReduce"></param>
        public void TakeDamage(float percentageToReduce)
        {

            // if the bee is dead no further health deductions should occur. 
            if (Dead) return;

            // param should only be between 0 to 100
            if (percentageToReduce > 100 || percentageToReduce < 0)
            {
                Console.WriteLine("Damage must be between 0 and 100.");
                return;
            }

            /// Problem: The Health of the Beeis to be reduced by that percentage of ...
            /// ... their current health.
            /// I initially got this wrong and thanks to Bizz realised that it's all about ...
            /// ... the precision!
            Health -= (Health * (percentageToReduce / 100f));
        }

        public void PronounceDead()
        {
            Dead = true;
        }

    }
}
