namespace New_Tax_Calulator_CON_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Salary.PartTimeGross(12, 22.5));
            Console.WriteLine(TaxReturn.NetIncome(Salary.PartTimeGross(12, 22.5), TaxReturn.Rates.Rate10));
        }
    }
}