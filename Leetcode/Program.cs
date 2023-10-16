using System.Collections.Generic;

public class Solution
{
    public int MajorityElement(int[] nums)
    {
        var dict = new Dictionary<int, int>();

        foreach (var num in nums)
        {
            if (dict.ContainsKey(num))
            {
                dict[num]++;
            }
            else
            {
                dict[num] = 1;
            }

            if (dict[num] > nums.Length / 2)
            {
                return num;
            }
        }

        return 0; 
    }
}