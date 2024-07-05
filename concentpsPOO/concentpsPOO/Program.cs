// See https://aka.ms/new-console-template for more information
using concentpsPOO;

Console.WriteLine("HOLA PICHE DE MUNDO ");
Console.WriteLine("-------------------");
Employee employee1 = new SalaryEmployee()
{
    Id = 1010,
    FirstName = "Rafael",
    LastName = "Colina",
    BirthDate = new Date(1987, 07, 30),
    HiringDate = new Date(2018, 04, 17),
    IsActive = true,
    Salary = 188888888.45555M
};
//Console.WriteLine(employee1);

Employee employee2 = new CommissionEmployee()
{
    Id = 1020,
    FirstName = "Rafael",
    LastName = "Aguilar",
    BirthDate = new Date(1987, 07, 30),
    HiringDate = new Date(2018, 04, 17),
    IsActive = true,
    Sales = 1888845555M,
    CommissionPercentaje = 0.03f
};
//Console.WriteLine(employee2);
Employee employee3 = new HourlyEmployee()
{
    Id = 1030,
    FirstName = "Pedro Alonzo",
    LastName = "Montero",
    BirthDate = new Date(1987, 07, 30),
    HiringDate = new Date(2018, 04, 17),
    IsActive = true,
    HoursValue = 18.88508M,
    Hours = 123.5f
};
//Console.WriteLine(employee3);

Employee employee4 = new BaseCommissionEmployee()
{
    Id = 1040,
    FirstName = "Camilo José",
    LastName = "Montero Gonzalez",
    BirthDate = new Date(1990, 07, 30),
    HiringDate = new Date(2012, 04, 17),
    IsActive = true,
    Base = 288850.8M,
    Sales = 5800666M,
    CommissionPercentaje = 0.015f
};
//Console.WriteLine(employee4);
//imprimir todos los empleados
ICollection<Employee> employees = new List<Employee>()
{
    employee1, employee2, employee3, employee4
//employees.Add(employee1);
//employees.Add(employee2);
//employees.Add(employee3);   
//employees.Add(employee4);
};

decimal payroll = 0;

foreach (Employee employee in employees)
{
    Console.WriteLine(employee);
    payroll += employee.GetValueToPay();


}
Console.WriteLine("                                 ================");
Console.WriteLine($"TOTAL                          {$"{payroll:C2}",18}");

Invoice invoice1 = new Invoice()
{
    Description = "Iphone 13",
    Id = 1,
    Price = 5300000M,
    Quantity = 6f
};
Invoice invoice2 = new Invoice()
{
    Description = "Posta Preum",
    Id = 2,
    Price = 5300000M,
    Quantity = 17.5f
};

Console.WriteLine(invoice1);
Console.WriteLine(invoice2);


