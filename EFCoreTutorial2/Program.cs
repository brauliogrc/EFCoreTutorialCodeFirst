using EFCoreTutorial2.Models;
using System;

namespace EFCoreTutorial2
{
    class Program
    {
        static void Main(string[] args)
        {

            using (var ctx = new SchoolContext())
            {
                var stud = new Student() { Name = "BraulioGrc" };
                ctx.Students.Add(stud);
                ctx.SaveChanges();
            }
            Console.WriteLine("Studen saved successfuly!");
        }
    }
}
