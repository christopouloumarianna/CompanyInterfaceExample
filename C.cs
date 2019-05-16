using System;
using System.Collections.Generic;
using System.Text;

namespace CompanyInterfaceExample
{
    public interface IEmployee
    {
        double GetSalary();
        bool IsUpdated();

    }
    public interface IRemote
    {
        double GetTotalHours();
    }
    public interface ILocal
    {
        int GetAbsenceDays();
    }
    public class SalesPerson : IRemote, IEmployee
    {

        public int Id { get; set; }
        public string Name { get; set; }
        public double Salary { get; set; }
        public double GetSalary()
        {
            return Salary;
        }

        public double GetTotalHours()
        {
            return 80.0;
        }




        public SalesPerson(int id, string name, double salary)
        {
            Id = id;
            Name = name;
            Salary = salary;
        }

        public bool IsUpdated()
        {
            return true;
        }
    }
}