using System;
using System.Collections.Generic;

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
        
           List<Exercise> allExercises = new List<Exercise>(){dictionaries, lists, classes, urbanPlanner, conditionals, studex};

           Cohort one = new Cohort ("Cohort 1");
           Cohort two = new Cohort ("Cohort 2");
           Cohort three = new Cohort ("Cohort 3");

           Student Sarah = new Student ("Sarah", "Brooks", "@Sarah"){
               cohort = three,
           };

           Student Barry = new Student ("Barry", "Griffith", "@Barry"){
               cohort = three,
           };

           Student Tommy = new Student ("Tommy", "Spurlock", "@Tommy Spurlock"){
               cohort = one,
           };

           Student Jacob = new Student ("Jacob", "Sperry", "@Jacob"){
               cohort = two,
           };
           
            List<Student> students = new List<Student>(){Sarah, Barry, Tommy, Jacob};


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

            Jennifer.Assign(conditionals, Barry);
            Jennifer.Assign(studex, Barry);

            dictionaries.assignedStudents.Add(Sarah);
            dictionaries.assignedStudents.Add(Barry);
            lists.assignedStudents.Add(Sarah);
            lists.assignedStudents.Add(Barry);


            three.listOfInstructors.ForEach(instructor => Console.WriteLine(instructor.FirstName));
            three.listOfStudents.ForEach(student => Console.WriteLine(student.FirstName));
            Sarah.assignedExercises.ForEach(exercise => Console.WriteLine(exercise.Name));
            Tommy.assignedExercises.ForEach(exercise => Console.WriteLine(exercise.Name));
            Console.WriteLine("\n");
            dictionaries.assignedStudents.ForEach(student => Console.WriteLine(student.FirstName));
            Console.WriteLine("\n");
            studex.assignedStudents.ForEach(student => Console.WriteLine(student.FirstName));




        }
    }
}
