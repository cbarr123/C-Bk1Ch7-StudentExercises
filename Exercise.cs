using System;

namespace StudentExercises
{
    public class Exercise{

        public string exerciseName{ get; set; }
        public string exerciseLanguage{ get; set; }

        public Exercise(string eName, string eLanguage)
        {
            exerciseName = eName;
            exerciseLanguage = eLanguage;
        }

    }
}