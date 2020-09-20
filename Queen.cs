namespace BeeInterview
{
    class Queen : Bee
    {
        public override void Damage(float percentageToReduce)
        {
            TakeDamage(percentageToReduce);
            // Queen below 20%;
            if (Health < (MaxHealth * 0.2))
            {
                PronounceDead();
            }
        }
       
    }
}
