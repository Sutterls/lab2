using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace lab2
{
    public abstract class Unit
    {
        public double HealthLevel { get; set; }
        public double DistanceToExplosion { get; set; }

        public virtual double RemainingHealthCalculation(double ExplosionPower) /// рассчитываем оставшееся здоровье
        {
            if (DistanceToExplosion == 0) { DistanceToExplosion += 1; } /// так как на ноль делить нельзя, заменяем ноль на единицу
            double damage = ExplosionPower / DistanceToExplosion;
            HealthLevel -= damage;
            if (HealthLevel < 0) { HealthLevel = 0; } /// если юнит получил такой урон, что здоровье ушло в минус, то определяем его как 0
            Console.WriteLine($"Unit took: {damage} damage. Remaining health: {HealthLevel}");
            return HealthLevel;
        }
    }
}