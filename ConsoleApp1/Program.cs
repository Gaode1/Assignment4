// See https://aka.ms/new-console-template for more information

internal class Program
{
    public static void Main(string[] args)
    {
        //program1();

        //program2();

        //convert(100);

        //int max = 500;
        //for (byte i = 0; i < max; i++)
        //{
        //    Console.WriteLine(i);
        //}
        //this will cauze infinity loop
        //add if(i == byte.maxValue), do somgthing
        
        // string a = Console.ReadLine();
        // Console.WriteLine(a);
        // double b = 10.2 / 0;
        // Console.WriteLine(b);
        // int c = 1231242131;
        // for (;true;)
        // {
        //     
        // }

        // Guess();
        // Pyramid(7);
        // ShowTime();
        loop();
    }

    public static void program1()
    {
        Console.WriteLine("What is your favorite color?");
        string color = Console.ReadLine();
        Console.WriteLine("What is your favorite food?");
        string food = Console.ReadLine();
        Console.WriteLine("What is your favorite number?");
        string num = Console.ReadLine();
        Console.WriteLine(color + food + num);
        Console.WriteLine("============");
    }
    public static void program2()
    {
        Console.WriteLine("The number of bytes for sbyte is 1");
        Console.WriteLine(sbyte.MaxValue);
        Console.WriteLine(sbyte.MinValue);
        Console.WriteLine("The number of bytes for byte is 1");
        Console.WriteLine(byte.MaxValue);
        Console.WriteLine(byte.MinValue);
        Console.WriteLine("The number of bytes for short is 2");
        Console.WriteLine(short.MaxValue);
        Console.WriteLine(short.MinValue);
        Console.WriteLine("The number of bytes for ushort is 2");
        Console.WriteLine(ushort.MaxValue);
        Console.WriteLine(ushort.MinValue);
        Console.WriteLine("The number of bytes for int is 4");
        Console.WriteLine(int.MaxValue);
        Console.WriteLine(int.MinValue);
        Console.WriteLine("The number of bytes for uint is 4");
        Console.WriteLine(uint.MaxValue);
        Console.WriteLine(uint.MinValue);
        Console.WriteLine("The number of bytes for long is 8");
        Console.WriteLine(long.MaxValue);
        Console.WriteLine(long.MinValue);
        Console.WriteLine("The number of bytes for ulong is 8");
        Console.WriteLine(ulong.MaxValue);
        Console.WriteLine(ulong.MinValue);
        Console.WriteLine("The number of bytes for float is 4");
        Console.WriteLine(float.MaxValue);
        Console.WriteLine(float.MinValue);
        Console.WriteLine("The number of bytes for double is 8");
        Console.WriteLine(double.MaxValue);
        Console.WriteLine(double.MinValue);
        Console.WriteLine("The number of bytes for decimal is 16");
        Console.WriteLine(decimal.MaxValue);
        Console.WriteLine(decimal.MinValue);
    }
    public static void convert(int centuries)
    {
        int years = centuries * 100;
        int days = (int) (years * 365.24);
        long hours = days * 24;
        long minutes = hours * 60;
        long seconds = minutes * 60;
        decimal miliseconds = seconds * 1000;
        decimal microseconds = miliseconds * 1000;
        decimal nanoseconds = microseconds * 1000;
        Console.WriteLine($"{centuries} centuries = {years} years = {days} days = {hours} hours = {minutes} minutes = {seconds} " +
            $"seconds = {miliseconds} miliseconds = {microseconds} microseconds = {nanoseconds} nanoseconds");
    }
    public static void Guess()
    {
        int correctNumber = new Random().Next(3) + 1;
        Console.WriteLine("enter your answer");
        int guess = int.Parse(Console.ReadLine());
        while (guess != correctNumber)
        {
            if (guess < 1 || guess > 3)
            {
                Console.WriteLine("out of range");
                Console.WriteLine("enter your answer");
                guess = int.Parse(Console.ReadLine());
            }
            else if (guess < correctNumber)
            {
                Console.WriteLine("too low");
                Console.WriteLine("enter your answer");
                guess = int.Parse(Console.ReadLine());
            }
            else
            {
                Console.WriteLine("too high");
                Console.WriteLine("enter your answer");
                guess = int.Parse(Console.ReadLine());
            }
        }

        Console.WriteLine("correct!");
    }

    public static void Pyramid(int lvl)
    {
        int max = 2 * lvl - 1;
        for (int i = 1; i <= lvl; i++)
        {
            for (int j = i; j <= max / 2; j++)
            {
                Console.Write(" ");
            }

            for (int k = 0; k < 2 * i - 1; k++)
            {
                Console.Write("*");
            }
            for (int j = i; j <= max / 2; j++)
            {
                Console.Write(" ");
            }
            Console.WriteLine();
        }
    }

    public static void ShowTime()
    {
        DateTime time = DateTime.Now;
        if (time.Hour > 5 && time.Hour <= 11)
        {
            Console.WriteLine("good morning");
        }
        if (time.Hour > 11 && time.Hour <= 18)
        {
            Console.WriteLine("good afternoon");
        }
        if (time.Hour > 18 && time.Hour <= 23)
        {
            Console.WriteLine("good evening");
        }
        if (time.Hour > 23 || time.Hour <= 5)
        {
            Console.WriteLine("good night");
        }
    }

    public static void loop()
    {
        for (int i = 1; i <= 4; i++)
        {
            for (int j = 0; j <= 24; j += i)
            {
                Console.Write(j+",");
            }
            Console.WriteLine();
        }
    }
}