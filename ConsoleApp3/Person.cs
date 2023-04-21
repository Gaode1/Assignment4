namespace ConsoleApp3;

public class Person
{
    public DateTime Birthdate { get; set; }
    public int Age
    {
        get { return DateTime.Now.Year - Birthdate.Year;}
        set { throw new NotImplementedException(); }
    }

    public string Name { get; set; }
    public List<string> Addresses { get; set; }
    protected double _salary;
    public double Salary
    {
        get { return _salary;}
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