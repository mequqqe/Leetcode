public class Solution
{
    public bool IsPalindrome(int x)
    {
        //Иннициализиация сһчисла в стринг
        string str = x.ToString();
        //его "переварачиваешь"
        string reversedStr = new string(str.Reverse().ToArray());

        return str == reversedStr;
    }
}