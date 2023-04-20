namespace ConsoleApp2;

public class Practice
{
    public static void Main(string[] args)
    {
        CopyingArray();
    }

    public static void CopyingArray()
    {
        int[] array = new Int32[10] { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };
        int[] array2 = new int[array.Length];
        for (int i = 0; i < array.Length; i++)
        {
            array2[i] = array[i];
        }

        for (int i = 0; i < array.Length; i++)
        {
            Console.Write(array[i]);
        }

        Console.WriteLine();
        foreach (int i in array2)
        {
            Console.Write(i);
        }
    }
}