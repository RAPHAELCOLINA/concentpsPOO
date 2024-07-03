// See https://aka.ms/new-console-template for more information
using concentpsPOO;

Console.WriteLine("HOLA PICHE DE MUNDO ");
Console.WriteLine("-------------------");
try
{
	Console.WriteLine(new Date(2024, 2, 29));
	Console.WriteLine(new Date(2024, 07, 21));
	Console.WriteLine(new Date(2024, 11, 31));
}
catch (Exception error)
{

	Console.WriteLine(error.Message);
}
