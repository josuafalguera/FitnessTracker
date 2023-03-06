using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FitnessTracker
{
    public class Food
    {
        public string Name { get; set; }
        public DateTime DateEaten { get; set; }
        public int Serving { private get; set; }
        public double CaloriesPerServing { private get; set; }
        public double TotalCalorieIntake { get; private set; }

        public Food(string name, DateTime dateEaten, int serving, double caloriesPerServing)
        {
            this.Name = name;
            this.DateEaten = dateEaten;
            this.Serving = serving;
            this.CaloriesPerServing = caloriesPerServing;
            this.TotalCalorieIntake = (this.TotalCalorieIntake) * (this.CaloriesPerServing);
        }
    }
}
