// See https://aka.ms/new-console-template for more information

using ConsoleApp3;
// //1.
// int[] nums = Assignment03.GenerateNumbers(10);
// Assignment03.Reverse(nums);
// Assignment03.PrintNumbers(nums);

//2.
// for (int i = 0; i < 10; i++)
// {
//     Console.WriteLine(Assignment03.Fibonacci(i+1));
// }

// Student student = new Student();
// student.Salary = 1000;
// Console.WriteLine(student.Salary);

Ball b1 = new Ball(1, new Color(221,21,213));
b1.Throw();
b1.Throw();
Console.WriteLine(b1.ThrowCount);
b1.Pop();
for (int i = 0; i < 10; i++)
{
    b1.Throw();
}
Console.WriteLine(b1.ThrowCount);
b1.Size = 5.1;
for (int i = 0; i < 10; i++)
{
    b1.Throw();
}
Console.WriteLine(b1.ThrowCount);
