namespace ConsoleApp3;

public class Student : Person
{
    public int Id { get; set; }
    public List<Course> Courses { get; set; }
    public List<Register> Registers { get; set; }

    public double GPA
    {
        get
        {
            // int sum = 0;
            // int num = 0;
            // foreach (var course in Courses)
            // {
            //     Grade grade = Registers.GetEnumerator((r) =>
            //     {
            //         if (r.Student.Id == Id)
            //         {
            //             return r.Grade;
            //         }
            //     });
            //     sum += 
            //     num++;
            // }
            return 0.0;
        } 
        set{}
    }
}