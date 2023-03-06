using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FitnessTracker
{
    public class User
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; private set; }
        private string Password;
        public Sex Sex { get; set; }
        public DateTime DateOfBirth { get; set; }
        public double Height { get; set; } //this will be in meters as default
        public double Weight { get; set; } //this will be in kilograms as default
        public ActivityLevel ActivityLevel { get; set; }
        public List<Workout> Workouts { get; private set; }
        public List<Food> Foods { get; private set; }
        public Dictionary<DateTime, double> Waters { get; private set; }

        public User(string firstName, string lastName, string email, string password, Sex sex, DateTime dateOfBirth, double height, double weight, ActivityLevel activityLevel)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Email = email;
            this.Password = password;
            this.Sex = sex;
            this.DateOfBirth = dateOfBirth;
            this.Height = height;
            this.Weight = weight;
            this.ActivityLevel = activityLevel;

            this.Workouts = new List<Workout>();
            this.Foods = new List<Food>();
            this.Waters = new Dictionary<DateTime, double>();
        }

        public void AddWorkout(Workout workout)
        {
            this.Workouts.Add(workout);
        }

        public List<Workout> GetWorkoutByDateRange(DateTime startDate, DateTime endDate)
        {
            return this.Workouts.Where(
                workout => startDate.Date <= workout.DateWorkoutMade.Date &&
                workout.DateWorkoutMade.Date <= endDate.Date).ToList();

        }

        public void RemoveWorkout(DateTime dateWorkoutMade)
        {
            this.Workouts.RemoveAll(workout => workout.DateWorkoutMade.Date.Equals(dateWorkoutMade.Date));
        }

        public void AddFood(Food food)
        {
            this.Foods.Add(food);
        }

        public List<Food> GetFoodByDateRange(DateTime startDate, DateTime endDate)
        {
            return this.Foods.Where(
                food => startDate.Date <= food.DateEaten.Date &&
                food.DateEaten.Date <= endDate.Date).ToList();
        }

        public void RemoveFood(DateTime dateEaten)
        {
            this.Foods.RemoveAll(food => food.DateEaten.Date.Equals(dateEaten.Date));
        }

        public void AddWater(DateTime dateDrank, double amount)
        {
            this.Waters.Add(dateDrank, amount);
        }

        public void RemoveWater(DateTime dateDrank)
        {
            this.Waters.Remove(dateDrank);
        }

        public bool CanLogIn(string Email, string Password)
        {
            return this.Email.Equals(Email) && this.Password.Equals(Password);
        }

        public bool CanChangePassword(string email, string oldPassword, string newPassword)
        {
            bool flag = false;
            if (this.CanLogIn(email, oldPassword))
            {
                this.Password = newPassword;
                flag = true;
            }
            return flag;
        }

    }
}
