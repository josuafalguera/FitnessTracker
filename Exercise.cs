using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FitnessTracker
{
    public class Exercise
    {
        public string Name { get; set; }
        public double CaloriesBurned { get; set; }

        public Exercise(string name, double caloriesBurned)
        {
            this.Name = name;
            this.CaloriesBurned = caloriesBurned;
        }
    }
}
