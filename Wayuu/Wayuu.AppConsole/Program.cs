using System;
using Wayuu.DAL;
using Wayuu.Entities;

namespace Wayuu.AppConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var Context = new WayuuContext())
            {
                Console.WriteLine("Nombre Escuela");
                var SchoolName = Console.ReadLine();
                var NewSchool = new School
                {
                    Name = SchoolName
                };

                Context.Schools.Add(NewSchool);
                var RowAfected = Context.SaveChanges();
                Console.WriteLine($"Escuelas Insertadas: {RowAfected}");
                Console.WriteLine("Escuelas");
                foreach (var School in Context.Schools)
                {
                    Console.WriteLine($"ID: {School.Id}, Name: {School.Name}");

                }
            }
        }
    }
}
