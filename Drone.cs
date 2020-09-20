namespace BeeInterview
{
    class Drone: Bee
    {
        public override void Damage(float percentageToReduce)
        {
            TakeDamage(percentageToReduce);
            // Drone below 50%;
            if (Health < (MaxHealth * 0.5))
            {
                PronounceDead();
            }
        }
    }
}
