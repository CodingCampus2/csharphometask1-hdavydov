using System;
using CodingCampusCSharpHomework;

namespace HomeworkTemplate
{
    class Program
    {
        static void Main(string[] args)
        {
            Func<Task1, string> TaskSolver = task =>
            {
                // Your solution goes here
                // You can get all needed inputs from task.[Property]
                // Good luck!

                int total = Int32.Parse(task.City.Population);
                float sickPercentage = float.Parse(task.City.SickPercentage);
                float mortality = float.Parse(task.Virus.KillProbability);

                float sick = total * sickPercentage;
                float dead = sick * mortality;

                string virus = task.Virus.Name;
                string city = task.City.Name;

                return "There are " + Math.Truncate(sick) + " people sick with " + virus + " in the city of " + city + ", " 
                + Math.Truncate(dead) + " of which died";
            };

            Task1.CheckSolver(TaskSolver);
        }
    }
}
