using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab2
{
    public class Tank : Unit
    {
        public double Armor { get; set; }

        public override double RemainingHealthCalculation(double ExplosionPower) /// переопределяем метод для танка
        {
            if (DistanceToExplosion == 0) { DistanceToExplosion += 1; }
            double damage = ExplosionPower / DistanceToExplosion;
            damage -= (damage * Armor)/100;
            HealthLevel -= damage;
            if (HealthLevel < 0) { HealthLevel = 0; }
            Console.WriteLine($"Tank took: {damage} damage. Remaining health: {HealthLevel}");
            return HealthLevel;
        }
    }
}
