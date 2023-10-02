using System.Text;
public class Solution
{
    public int MaximumCount(int[] nums)
    {
        //Array.Sort(nums);
        //foreach (int number in nums)
        //{
        //    if (number < 0)
        //    {
        //        return "neg";
        //    }
        //    else if (number > 0)
        //    {
        //        return "pos";
        //    }
        //}
        //return "none";


        int pos = 0; 
        int neg= 0; 

        foreach (int number in nums)
        {
            if (number > 0)
            {
                pos++;
            }
            else if (number < 0)
            {
                neg++;
            }
        }

        return Math.Max(pos,neg);
    }
}
