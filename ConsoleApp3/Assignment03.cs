namespace ConsoleApp3;

public class Assignment03
{
    public static int[] GenerateNumbers(int n)
    {
        int[] nums = new int[n];
        for (int i = 0; i < n; i++)
        {
            nums[i] = i+1;
        }
        return nums;
    }

    public static void Reverse(int[] nums)
    {
        int len = nums.Length;
        for (int i = 0; i < len / 2; i++)
        {
            (nums[i], nums[len - i - 1]) = (nums[len - i - 1], nums[i]);
        }    
    }

    public static void PrintNumbers(int[] nums)
    {
        foreach (var num in nums)
        {
            Console.Write(num+" ");
        }
    }

    public static int Fibonacci(int index)
    {
        if (index == 1 || index == 2)
        {
            return 1;
        }

        return Fibonacci(index - 1) + Fibonacci(index - 2);
    }
}