namespace ConsoleApp3;

public class Department
{
    public int ID { get; set; }
    public string Name { get; set; }
    public List<Course> Courses { get; set; }
    public Instructor Head { get; set; }
    public double Budget { get; set; }
}