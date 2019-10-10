using System;

namespace StudentExercises
{
    public class Instructor 
    {
        public string firstName{ get; set; }
        public string lastName{ get; set; }
        public string slack{ get; set; }
        public string cohort{ get; set; }
        public string specialty{ get; set; }

        //method to assign an exercise to a student



        //Constructor for Instructor
        public Instructor (string fName, string lName, string iSlack, string iCohort, string iSpecialty)
        {
            firstName = fName; 
            lastName = lName;
            slack = iSlack;
            cohort = iCohort;
            specialty = iSpecialty;

        }


    }
}