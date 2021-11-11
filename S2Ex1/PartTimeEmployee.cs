namespace S2Ex1
{
    public class PartTimeEmployee : Employee
    {
        public int HoursPerMonth { get; set; }
        public double HourWage { get; set; }

        public PartTimeEmployee(string name, int hoursPerMonth, double hourWage) : base(name)
        {
            this.HoursPerMonth = hoursPerMonth;
            this.HourWage = hourWage;
        }
        public override double GetMonthlySalary()
        {
            return HoursPerMonth * HourWage;
        }
    }
}