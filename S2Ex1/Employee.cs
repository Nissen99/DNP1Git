namespace S2Ex1
{
    public abstract class Employee
    {
        public string Name { get; set; }


        public Employee(string name)
        {
            this.Name = name;
        }
        public abstract double GetMonthlySalary();


    }
}