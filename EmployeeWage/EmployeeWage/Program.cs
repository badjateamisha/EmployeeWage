// See https://aka.ms/new-console-template for more information
using EmployeeWage;

Console.WriteLine("Welcome to Employee Wage computation program!");

Finalwage wage = new();
wage.finalwage();

Multicompanies comp = new();

comp.EmpWage("Bridgelabs", 10, 10, 50);
comp.EmpWage("Capgemini", 20, 20, 100);
