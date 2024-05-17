using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab2
{
    public class ListOfUnits
    {
        private List<Unit> units;

        public ListOfUnits(List<Unit> units)
        {
            this.units = units; /// ссылается на units
        }

        public void Explosion(int explosionPower)
        {
            var destroyedUnits = units.Where(unit => unit.RemainingHealthCalculation(explosionPower) <= 0).ToList(); /// преобразование результатов в список

            Console.WriteLine("Destroyed units:");
            foreach (var unit in destroyedUnits)
            {
                Console.WriteLine($"Unit {unit.GetType().Name} destroyed");
            }
        }
    }
}
