using System;
using System.Collections.Generic;

namespace StudentExercises
{
    public class Student
    {
        public string firstName{ get; set; }
        public string lastName{ get; set; }
        public string slack{ get; set; }
        public string cohort{ get; set; }

        //List of exercises that the student is currently working on
        public List <Exercise> ExerciseList = new List<Exercise>();

        //Constructor for student
        public Student(string fName, string lName, string sSlack, string sCohort)
        {
            firstName = fName;
            lastName = lName;
            slack = sSlack;
            cohort = sCohort;
        }

    }
}