using System;
/// <summary>
/// Calulates problems related to tax returns
/// </summary>
public static class TaxReturn
{
    /// <summary>
    /// Tax rate returns
    /// </summary>
    /// <param name="income">Money made throughout the year</param>
    /// <returns>Tax Rate for income</returns>
    public static double GetRate(double income)
    {
        return GetRate(income, false);
    }
    /// <summary>
    /// Joint tax rate returns
    /// </summary>
    /// <param name="income">Money made throughout the year</param>
    /// <param name="joint">Is this filed jointly</param>
    /// <returns>Joint Tax Rate for income</returns>
    public static double GetRate(double income, bool joint)
	{
        if (joint)
        {
            if (income < 20550 && income >= 0)
            {
                return 10.00;
            }
            else if (income >= 20551 && income < 83550)
            {
                return 12.00;
            }
            else if (income >= 83551 && income < 178150)
            {
                return 22.00;
            }
            else if (income >= 178151 && income < 340100)
            {
                return 24.00;
            }
            else if (income >= 340101 && income < 431900)
            {
                return 32.00;
            }
            else if (income >= 431901 && income < 647850)
            {
                return 35.00;
            }
            else if (income >= 647850)
            {
                return 37.00;
            }
            else
            {
                throw new Exception("Impossible salary");
            }
        }
        else
        {
            if (income <= 10275 && income >= 0)
            {
                return 10.00;
            }
            else if (income <= 41775 && income >= 10276)
            {
                return 12.00;
            }
            else if (income <= 89075 && income <= 41776)
            {
                return 22.00;
            }
            else if (income <= 170050 && income >= 89076)
            {
                return 24.00;
            }
            else if (income <= 215950 && income >= 170051)
            {
                return 32.00;
            }
            else if (income <= 539900 && income >= 215951)
            {
                return 35.00;
            }
            else if (income >= 53901)
            {
                return 37.00;
            }
            else
            {
                return 0.00;
            }
        }
    }
    /// <summary>
    /// Calculates income after taxes applied
    /// </summary>
    /// <param name="income">Amount made before paying taxes</param>
    /// <returns>Net money made</returns>
    public static double NetIncome(double income)
    {
        return NetIncome(income, GetRate(income));
    }
    /// <summary>
    /// Calculates income after taxes applied
    /// </summary>
    /// <param name="income">Amount made before paying taxes</param>
    /// <param name="rate">Tax Rate</param>
    /// <returns></returns>
    public static double NetIncome(double income, Rates rate)
    {
        return NetIncome(income, (int)rate);
    }
    public static double NetIncome(double income, double rate)
    {
        return (income * (1 - (rate/100)));
    }
    /// <summary>
    /// Common rates used in taxes
    /// </summary>
    public enum Rates
    {
        None = 0,
        Rate10 = 10,
        Rate12 = 12,
        Rate22 = 22,
        Rate24 = 24,
        Rate32 = 32,
        Rate35 = 35,
        rate37 = 37
    }
}
