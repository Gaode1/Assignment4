namespace ConsoleApp2;

public class Practice4
{
    public int[] SumAfterRotation(int[] arr, int k) 
    {
        int times = k / arr.Length;
        int move = k % arr.Length;
        int sum = 0;
        int[] res = new int[arr.Length]; foreach (var item in arr)
        {
            sum = sum + item;
        }
        sum = sum * times;
        for (int i = 0; i < arr.Length; i++) {
            for (int j = 1; j <= move; j++) {
                if (i - j >= 0) {
                    res[i] = res[i] + arr[i - j]; }
                else {
                    res[i] = res[i] + arr[i - j + arr.Length]; }
            }
            res[i] = sum + res[i]; }
        return res; 
    }

    public void MostFrequentNumber(int[] arr)
    {
        Dictionary<int, int> freq = new Dictionary<int, int>();
        Dictionary<int, int> firstOccurrence = new Dictionary<int, int>();
        int leftmost = int.MaxValue;
        for (int i = 0; i < arr.Length; i++)
        {
            if (!freq.ContainsKey(arr[i]))
            {
                freq.Add(arr[i], 1);
                firstOccurrence.Add(arr[i], i);
            }
            else
            {
                freq[arr[i]]++;
            }
        }

        int mostFreq = freq.Values.Max();
        int num = -1;
        foreach (var key in freq.Keys)
        {
            if (freq[key] == mostFreq && firstOccurrence[key] < leftmost)
            {
                leftmost = firstOccurrence[key];
                num = arr[leftmost];
            }
        }

        Console.WriteLine($"The number {num} is the most frequent (occurs {mostFreq} times)");
    }
}