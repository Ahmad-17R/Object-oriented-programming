using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task3
{
    internal class Routine
    {
        private string Name;
        private List<Exercise> exercises = new List<Exercise>();

        public void Setname()
        {
            Console.WriteLine("Enter the name of the Routine: ");
            Name = Console.ReadLine();

        }

        public string Getname()
        {
            return Name;
        }

        public void Addexercise()
        {
            Exercise exercise = new Exercise();
            exercise.setname();
            Console.WriteLine("How many sets do u want to add?");
            int num=int.Parse(Console.ReadLine());
            for (int i = 0; i < num; i++)
            {
                exercise.Addset();
            }
            exercises.Add(exercise);
        }

        public void Removexercise(Exercise exercise)
        {
            exercises.Remove(exercise);
        }

        public void viewexercises()
        {
            foreach (Exercise exercise in exercises)
            {
                exercise.getname();
                exercise.viewlist();
            }
            Console.ReadKey();
        }
    }

}

