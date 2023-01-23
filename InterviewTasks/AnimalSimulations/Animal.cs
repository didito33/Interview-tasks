using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalSimulations
{
    public abstract class Animal
    {
		private int maxEnergy;
        private int currEnergy;

        protected Animal(int maxEnergy)
		{
			this.currEnergy = maxEnergy;
			this.MaxEnergy = maxEnergy;
		}

		public int MaxEnergy
		{
			get { return maxEnergy; }
			private set 
			{ 
				maxEnergy = value; 
			}
		}

		public int CurrEnergy
		{
			get { return currEnergy; }
			protected set 
			{ 
				if(value > this.maxEnergy)
				{
					value = this.maxEnergy;
				}

				else if (IsDead())
				{
					value = 0;
				}
				currEnergy = value; 
			}
		}
		public bool IsDead() => this.CurrEnergy == 0;
        public abstract int DaysSurvived { get; }
        public abstract void Feed(Foods food);

	}
}
