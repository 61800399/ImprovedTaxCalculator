using System.Transactions;

namespace New_Tax_Calulator_CON_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<uint> ages = new List<uint>()
            {
                1, 2, 3, 4,
            };
            List<double> price = new List<double>()
            {
                2000, 3000, 1000, 2500
            };
            Console.WriteLine("Full time gross $15: $" + Salary.FullTimeGross(15));
            Console.WriteLine("part time gross $12: $" + Salary.PartTimeGross(12));
            Console.WriteLine("Taxed amount: $" + TaxReturn.TaxedAmount(Salary.PartTimeGross(12), TaxReturn.GetRate(Salary.PartTimeGross(12))));
            Console.WriteLine("Child Exempt: $" + Exempt.ChildCredit(Salary.PartTimeGross(12), 4, ages, price, TaxReturn.TaxedAmount(Salary.PartTimeGross(12), TaxReturn.GetRate(Salary.PartTimeGross(12)))));
            Console.WriteLine("Dependant exempt: $" + Exempt.Dependant(Salary.PartTimeGross(12), 4, false));
            Console.WriteLine("Net income after tax: $" + TaxReturn.NetIncome(Salary.PartTimeGross(12), TaxReturn.GetRate(Salary.PartTimeGross(12))));
        }
    }
}