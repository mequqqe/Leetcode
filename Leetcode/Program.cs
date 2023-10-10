public class Solution
{
    public int[] SeparateDigits(int[] nums)
    {
        //foreach (int i in nums) {
        //    string numStr = nums.ToString();

        //    string[] subs = numStr.Split(',');

        //    Array.Sort(subs);
        //}


        int[] tt = nums.Select(char.GetNumericValue).ToArray();


        Array.Sort(tt);

        string result = string.Join(", ", tt);
        


    }
}