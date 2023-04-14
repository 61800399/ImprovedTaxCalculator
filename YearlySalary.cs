using System;
/// <summary>
/// Calulations related to salary's
/// </summary>
public static class Salary
{
    /// <summary>
    /// Calculates total income of part time work
    /// </summary>
    /// <param name="HourlyWage">Standard non overtime wage</param>
    /// <returns>Total income</returns>
    public static double PartTimeGross(double HourlyWage)
	{
		return PartTimeGross(HourlyWage, 24, 0);
	}
    /// <summary>
    /// Calculates total income of part time work
    /// </summary>
    /// <param name="HourlyWage">Standard non overtime wage</param>
    /// <param name="WeeklyHours">hours worked excluding breaks</param>
    /// <returns>Total income</returns>
    public static double PartTimeGross(double HourlyWage, double WeeklyHours)
	{
		return PartTimeGross(HourlyWage, WeeklyHours, 0);
	}
	/// <summary>
	/// Calculates total income of part time work
	/// </summary>
	/// <param name="HourlyWage">Standard non overtime wage</param>
	/// <param name="WeeklyHours">hours worked excluding breaks</param>
	/// <param name="OvertimeHours">hours of overtime recived per week</param>
	/// <returns>Total income</returns>
    public static double PartTimeGross(double HourlyWage, double WeeklyHours, double OvertimeHours)
	{
		double OverTimePay = (HourlyWage * 1.5) * OvertimeHours;
		double TotalWeekly = HourlyWage * WeeklyHours;
		return (TotalWeekly * 52) + OverTimePay;
	}
}
