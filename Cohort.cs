using System;
using System.Collections.Generic;

namespace studentExercises
{
    class Cohort
    {
        public string Name {get; set;}

        public List<Student> listOfStudents {get; set;} = new List<Student>();
        public List<Instructor> listOfInstructors {get; set;} = new List<Instructor>();

        public Cohort (string name){
            Name = name;
        }
    }
}