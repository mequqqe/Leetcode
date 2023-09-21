public class Solution
{
    public bool IsPalindrome(int x)
    {
        string str = x.ToString();
        string reversedStr = new string(str.Reverse().ToArray());
        return str == reversedStr;
    }
}