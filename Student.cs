using System;
using System.Collections.Generic;

namespace studentExercises
{
    class Student
    {
        public string FirstName {get; set;}
        public string LastName {get; set;}
        public string SlackHandle {get; set;}


        // public int CohortId {get; set;}

        public Cohort Cohort {get; set;}

        public List<Exercise> assignedExercises {get; set;} = new List<Exercise>();


        public Student (string firstName, string lastName, string slack){
            FirstName = firstName;
            LastName = lastName;
            SlackHandle = slack;
        }
    }
}