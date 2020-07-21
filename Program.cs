using System;
using System.Collections.Generic;
using System.Linq;

namespace studentExercises
{
    class Program
    {
        static void Main(string[] args)
        {
           Exercise dictionaries = new Exercise ("Dictionaries", "C#");
           Exercise lists = new Exercise ("Lists", "C#");
           Exercise classes = new Exercise ("Classes", "C#");
           Exercise urbanPlanner = new Exercise ("Urban Planner", "C#");
           Exercise conditionals = new Exercise ("conditionals", "C#");
           Exercise studex = new Exercise ("studex", "C#");
           Exercise nutshell = new Exercise ("nutshell", "JavaScript");

           Cohort one = new Cohort ("Cohort 1");
           Cohort two = new Cohort ("Cohort 2");
           Cohort three = new Cohort ("Cohort 3");

           Student Sarah = new Student ("Sarah", "Brooks", "@Sarah"){
               Cohort = three,
           };

           Student Barry = new Student ("Barry", "Griffith", "@Barry"){
               Cohort = three,
           };

           Student Tommy = new Student ("Tommy", "Spurlock", "@Tommy Spurlock"){
               Cohort = one,
           };

           Student Jacob = new Student ("Jacob", "Sperry", "@Jacob"){
               Cohort = two,
           };

            three.listOfStudents.Add(Sarah);
            three.listOfStudents.Add(Barry);
            one.listOfStudents.Add(Tommy);
            two.listOfStudents.Add(Jacob);

            Instructor Jordan = new Instructor ("Jordan", "Castelloe", "@Jordan Castelloe", "Muppets", one);
            Instructor TommyS = new Instructor ("Tommy", "Spurlock", "@Tommy Spurlock", "Mia", two);
            Instructor Jennifer = new Instructor ("Jennifer", "Johnson", "@Jennifer", "Coding", three);

            three.listOfInstructors.Add(Jordan);
            two.listOfInstructors.Add(TommyS);
            one.listOfInstructors.Add(Jennifer);

            Jordan.Assign(dictionaries, Sarah);
            Jordan.Assign(lists, Sarah);

            Jordan.Assign(dictionaries, Barry);
            Jordan.Assign(lists, Barry);


            TommyS.Assign(classes, Sarah);
            TommyS.Assign(urbanPlanner, Sarah);

            TommyS.Assign(classes, Barry);
            TommyS.Assign(urbanPlanner, Barry);


            Jennifer.Assign(conditionals, Sarah);
            Jennifer.Assign(studex, Sarah);

            // Jennifer.Assign(conditionals, Barry);
            // Jennifer.Assign(studex, Barry);

            dictionaries.assignedStudents.Add(Sarah);
            dictionaries.assignedStudents.Add(Barry);
            lists.assignedStudents.Add(Sarah);
            lists.assignedStudents.Add(Barry);


            // three.listOfInstructors.ForEach(instructor => Console.WriteLine(instructor.FirstName));
            // three.listOfStudents.ForEach(student => Console.WriteLine(student.FirstName));
            // Sarah.assignedExercises.ForEach(exercise => Console.WriteLine(exercise.Name));
            // Tommy.assignedExercises.ForEach(exercise => Console.WriteLine(exercise.Name));
            // Console.WriteLine("\n");
            // dictionaries.assignedStudents.ForEach(student => Console.WriteLine(student.FirstName));
            // Console.WriteLine("\n");
            // studex.assignedStudents.ForEach(student => Console.WriteLine(student.FirstName));

            // Student Exercises Pt.2: Using LINQ methods
            List<Exercise> allExercises = new List<Exercise>(){dictionaries, lists, classes, urbanPlanner, conditionals, studex, nutshell};

            List<Exercise> JSexercises = allExercises.Where(exercise => exercise.Language == "JavaScript").ToList();
                       
            List<Cohort> cohorts = new List<Cohort>(){one, two, three};

            List<Instructor> instructors = new List<Instructor>(){Jordan, TommyS, Jennifer};

            List<Instructor> instructorsInCohort3 = instructors.Where(instructor => instructor.Cohort.Name == "Cohort 3").ToList();

            List<Student> students = new List<Student>(){Sarah, Barry, Tommy, Jacob};

            List<Student> studentsInCohort3 = students.Where(student => student.Cohort.Name == "Cohort 3").ToList();

            List<Student> studentsOrderedByLastName = students.OrderBy(student => student.LastName).ToList();

            List<Student> studentsNotWorking = students.Where(student => student.assignedExercises.Count() == 0).ToList();
                foreach(Student student in studentsNotWorking){
                    Console.WriteLine($"{student.FirstName} is not working on any exercises.");
                }

            Student HardWorkingStudent = students.OrderByDescending(student => student.assignedExercises.Count()).First();

            var studentsInCohort = from student in students

                group student by student.Cohort.Name into cohortGroup

                select new Dictionary<string, int>() {
                    {cohortGroup.Key, cohortGroup.Count()}
                };

            foreach(Dictionary<string, int> cohortStudents in studentsInCohort){
                foreach(KeyValuePair<string, int> student in cohortStudents){
                    Console.WriteLine($"There are {student.Value} student(s) in {student.Key}");
                }
            }

            Console.WriteLine();

        }
    }
}
