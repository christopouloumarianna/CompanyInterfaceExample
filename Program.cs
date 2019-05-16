using System;

namespace CompanyInterfaceExample
{
    class Program
    {
        static void Main(string[] args)
        {
            var person1 = new SalesPerson(45, "Dimitris", 896.0);
            double salary = person1.GetSalary();

            Console.WriteLine(person1.GetTotalHours());
            Console.WriteLine(person1.GetSalary());
            if (person1.IsUpdated())
            {
                Console.WriteLine("Updated");
            }
            else
            {
                Console.WriteLine("Not upadated");
            }
        }
    }
}
