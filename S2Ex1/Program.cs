using System;

namespace S2Ex1
{
    class Program
    {
        static void Main(string[] args)
        {

            Employee Solman = new PartTimeEmployee("Solman", 37, 269);
            Employee Mikkel = new PartTimeEmployee("Mikkel", 14, 123);
            Employee BastMan = new FullTimeEmployee("BastMan", 400000.37);
            Employee MatMan = new FullTimeEmployee("matMan", 69694.20);

            Company activison = new Company();
            activison.HireNewEmployee(Solman);
            activison.HireNewEmployee(Mikkel);
            activison.HireNewEmployee(BastMan);
            activison.HireNewEmployee(MatMan);

            Console.WriteLine(activison.GetMonthlySalaryTotal());


        }
    }
}