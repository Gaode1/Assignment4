namespace ConsoleApp2;

public class Practice3
{
    public static void Main(string[] args)
    {
        int[] res = FindPrimeInRange(1, 9);
        Console.WriteLine(res[0]);
    }

    public static int[] FindPrimeInRange(int start, int end)
    {
        List<int> res = new List<int>();
        for (int i = start; i <= end; i++)
        {
            for (int j = 2; j < i; j++)
            {
                if (i % j == 0)
                {
                    res.Add(i);
                }
            }
        }
        int[] newres = res.ToArray();
        return newres;
    }
}