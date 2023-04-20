namespace ConsoleApp2;

public class Practice2
{
    public static void Main(string[] args)
    {
        // Elements();
    }

    public static void Elements()
    {
        List<string> items = new List<string>();
        while (true)
        {
            Console.WriteLine("Enter command (+ item, - item, or -- to clear)):");
            string input = Console.ReadLine();
            if (input.StartsWith("+"))
            {
                items.Add(input.Substring(2));
            }
            else if(input.StartsWith("--"))
            {
                items.Clear();
            }
            else if (input.StartsWith("-"))
            {
                items.Remove(input.Substring(2));
            }
            else continue;

            Console.WriteLine("Current Items: ");
            foreach (string s in items)
            {
                Console.WriteLine(s);
            }
        }
    }
}