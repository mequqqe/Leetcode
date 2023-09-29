public class Solution
{
    public int LengthOfLastWord(string s)
    {
        if (s.Length == 0)
        {
            return 0;
        }
        string w = s.Trim();

        string[] k = w.Split(' ');

        if (k.Length == 0)
        {
            return 0;
        }

        string t = k[k.Length - 1];

        return t.Length;
    }
}
