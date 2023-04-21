namespace ConsoleApp3;

public class Instructor : Person
{
    public Department dept { get; set; }
    private DateTime joinDate;
    private static double factor = 5;

    public double Bonus
    {
        get { return (DateTime.Now.Year - joinDate.Year) * factor;}
    }

    public double Salary
    {
        get { return _salary + Bonus;}
        set
        {
            if (value < 0)
            {
                throw new ArgumentOutOfRangeException("Salary can not be negative");
            }
            _salary = value;
        }
    }
}