using console_sim_data.Models;
using System;

namespace console_sim
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var context = new ConsoleSimContext())
            {
                var person = new Person
                {
                    PersonId = 2,
                    Name = "Slam",
                    Age = 30
                   
                };
                context.Add(person);
                context.SaveChanges();
            }
        }
    }
}
