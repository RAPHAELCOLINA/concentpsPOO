namespace concentpsPOO
{
    public class SalaryEmployee : Employee
    {
        public decimal Salary { get; set; }

        public override decimal GetValueToPay()
        {
            return Salary;
        }

        public override string ToString()

        {
            return $"{base.ToString()}"
                + $"\n\tValue To pay.........:{$"{GetValueToPay():C2}",19}";
        }
    }
}
