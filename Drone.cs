using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeeInterview
{
    class Drone: Bee
    {
        public override float DamageLimit { get; set; } = 50;
    }
}
