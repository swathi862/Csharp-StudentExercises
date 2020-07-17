using System;

namespace studentExercises
{
    class Instructor
    {
        public string FirstName {get; set;}
        public string LastName {get; set;}
        public string SlackHandle {get; set;}
        public string Specialty {get; set;}
        public Cohort CohortId {get; set;}

        public Instructor (string first, string last, string slack, string specialty, Cohort id){
            FirstName = first;
            LastName = last;
            SlackHandle = slack;
            Specialty = specialty;
            CohortId = id;
        }

        public void Assign(Exercise assignExercise, Student studName){
            studName.assignedExercises.Add(assignExercise);
        }
    }
}