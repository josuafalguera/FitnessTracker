using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FitnessTracker
{
    public class Workout
    {
        public string Name { get; set; }
        public DateTime DateWorkoutMade { get; private set; }
        public List<Exercise> Exercises { get; private set; }

        public Workout(string name, DateTime dateWorkoutMade)
        {
            this.Name = name;
            this.DateWorkoutMade = dateWorkoutMade;
            this.Exercises = new List<Exercise>();
        }

        public void AddExercise(Exercise exercise)
        {
            this.Exercises.Add(exercise);
        }
    }
}