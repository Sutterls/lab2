namespace lab2
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Unit> units = new List<Unit>
            {
                new Infantryman { HealthLevel = 40, DistanceToExplosion = 0 },
                new Infantryman { HealthLevel = 100, DistanceToExplosion = 4 },
                new Tank { HealthLevel = 50, DistanceToExplosion = 1, Armor = 20 },
                new Tank { HealthLevel = 200, DistanceToExplosion = 20, Armor = 50 },
                new Infantryman { HealthLevel = 100, DistanceToExplosion = 2 }
            };
            ListOfUnits unitList = new ListOfUnits(units);
            unitList.Explosion(80);
        }
    }
}
