using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalSimulations
{
    public class Deer : Animal
    {
        private Foods[] Diet = { Foods.Grass, Foods.Carrot };
        private int daysSurvived;
        public Deer(int maxEnergy) : base(maxEnergy)
        {
        }

        public override int DaysSurvived => daysSurvived;

        public override void Feed(Foods food)
        {
            if (!IsDead())
            {
                if (!Diet.Contains(food))
                {
                    this.CurrEnergy--;
                }
                else
                {
                    this.CurrEnergy++;
                }
                daysSurvived++;
            }
        }
    }
}
