using System;
using System.Collections.Generic;
using System.Linq;

namespace BeeInterview
{
    class Worker: Bee
    {
        public override void Damage(float percentageToReduce)
        {
            TakeDamage(percentageToReduce);
            // Worker below 70%;
            if (Health < (MaxHealth * 0.7))
            {
                PronounceDead();
            }
        }
    }
}
