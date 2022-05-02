// See https://aka.ms/new-console-template for more information
using EmployeeWage;


public class wageforeachcompany
{
    static void Main(string[] args)
    {

        Console.WriteLine("Welcome to employee wage program!");
        while (true)
        {
            Console.WriteLine("Choose the program to be executed:\n1)Wage for multiple companies\n2)total wage for each company\n3)Different Empwages for different companies");



            int option = Convert.ToInt32(Console.ReadLine());
            switch (option)
            {
                case 8:
                    WageCalculation wage = new WageCalculation();

                    wage.EmployeeWage("BridgeLabs", 20, 20, 100);
                    wage.EmployeeWage("Amazon", 30, 20, 120);

                    break;
                case 9:

                    wageCalculation Amazon = new wageCalculation("Amazon", 20, 5, 100);
                    Amazon.computewage();
                    wageCalculation BridgeLabs = new wageCalculation("Bridge Labs", 25, 5, 120);
                    BridgeLabs.computewage();
                    break;
                case 10:
                    EmpWageBuilder empWageBuilder = new EmpWageBuilder();
                    empWageBuilder.addCompanyEmpWage("Amazon", 20, 5, 100);
                    empWageBuilder.addCompanyEmpWage("Bridge Labs", 25, 5, 120);
                    empWageBuilder.ComputeEmpWage();
                    Console.Write("Total wage for company Amazon :");
                    empWageBuilder.getTotalWage("Amazon");
                    Console.WriteLine("\n");
                    break;


            }
        }
    }
}
