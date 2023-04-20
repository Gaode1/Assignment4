using System.Text;

namespace ConsoleApp2;

public class Practice5
{
    public string ReverseStringOne(string s) 
    {
        if (s == null) {
            return string.Empty; }
        char[] chars = s.ToCharArray();
        for (int i = 0, j = chars.Length - 1; i < j; i++, j--) {
            char c = chars[i]; chars[i] = chars[j]; chars[j] = c;
        }
        string res = new string(chars); return res;
    }
    
    public string ReverseWords(string s) {
        if (s == null) {
            return string.Empty; }
        char[] separators = new char[] {'.', ',', ':', ';', '=', '(', ')', '&', '[', ']', '"', '\'', '/', '\\', '!', '?', ' '}; char[] chars = s.ToCharArray();
        int n = chars.Length;
        bool isWord = true;
        StringBuilder sb = new StringBuilder(); List<string> wordsList = new List<string>(); List<string> separatorList = new List<string>(); foreach (var c in chars)
        {
            if (isWord) {
                if (separators.Contains(c)) {
                    wordsList.Add(sb.ToString()); sb.Clear();
                    isWord = !isWord;
                } }
            else {
                if (!separators.Contains(c)) {
                    separatorList.Add(sb.ToString()); sb.Clear();
                    isWord = !isWord;
                } }
            sb.Append(c); }
        separatorList.Add(sb.ToString()); sb.Clear();
        int m = wordsList.Count();
        for (int i = 0; i < m; i++)
        {
            sb.Append(wordsList[m - 1 - i]); sb.Append(separatorList[i]);
        }
        return sb.ToString(); 
    }
    
    public string[] FindPalindrome(string s) {
        if (s == null) 
        {
            return null; 
        }
        HashSet<string> wordsSet = new HashSet<string>(); bool isWord = true;
        StringBuilder sb = new StringBuilder();
        char[] chars = s.ToCharArray();
        foreach (var c in chars) {
            if (isWord) {
                if (!char.IsLetter(c)) {
                    wordsSet.Add(sb.ToString()); sb.Clear();
                    isWord = !isWord;
                } else {
                    sb.Append(c); }
            } else {
                if (char.IsLetter(c)) {
                    sb.Append(c);
                    isWord = !isWord; }
            } }
        foreach (var word in wordsSet) {
            if (!IsPalindrome(word)) {
                wordsSet.Remove(word); }
        }
        return wordsSet.ToArray(); }
    private bool IsPalindrome(string s) {
        if (s.Length <= 1) {
            return true; }
        int i = 0, j = s.Length - 1; while (i < j)
        {
            if (s[i] != s[j]) {
                return false; } else
            {
                i++;
                j--; }
        }
        return true; 
    }
    
    public void ParseUrl(string url) {
        char[] seperator = new char[] { ':', '/', '/' }; int i = url.IndexOfAny(seperator);
        string protocal, secondHalf;
        if (i != -1)
        {
            protocal = url.Substring(0, i); secondHalf = url.Substring(i + 3);
        } else {
            protocal = " ";
            secondHalf = url; }
        string[] temp = secondHalf.Split('/'); string server = temp[0];
        string resource;
        if (temp.Length > 1)
        {
            resource = temp[1];
        } else {
            resource = " "; }
        Console.WriteLine($"[protocal] = {protocal}"); Console.WriteLine($"[server] = {server}"); Console.WriteLine($"[resource] = {resource}");
    }
}