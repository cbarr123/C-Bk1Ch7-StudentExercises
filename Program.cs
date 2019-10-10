using System;

namespace StudentExercises
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            //Create 4, or more, exercises
            Exercise E01 = new Exercise("Nutshell", "JavaScript");
            Exercise E02 = new Exercise("ChickenMonkey","HTML/CSS");
            Exercise E03 = new Exercise("FlexBox Friday", "JavaScript");
            Exercise E04 = new Exercise("Magic Ducks", "C#");
            
            //Create 3, or more, cohorts
            Cohort C01 = new Cohort("Cohort 1");
            Cohort C02 = new Cohort("Cohort 2");
            Cohort C03 = new Cohort("Cohort 3");
            Cohort C04 = new Cohort("Cohort 4");

            //Create 4, or more, students
            Student S01 = new Student("Thomas", "Smith", "@TSmith", "C01");
            Student S02 = new Student("Mabry", "Dove", "@MDove", "C03");
            Student S03 = new Student("Darryl", "Jones", "@DJOnes", "C04");
            Student S04 = new Student("Snicker", "Doodle", "@SDoodle", "C02");
            Student S05 = new Student("Montague", "Montana", "@MMontana", "C03");

            //Create 3, or more, instructors and assign them to one of the cohorts.
            Instructor I01 = new Instructor("Andy", "Collins", "@ACollins", "C02", "dancing");






        }
    }
}
