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
Console.WriteLine(employee1);

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
Console.WriteLine(employee2);