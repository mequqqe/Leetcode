public class Solution
{
    public int FindClosestNumber(int[] nums)
    {
        int closestNumber = nums[0];

        foreach (int num  in nums)
        {
            //Math.abs вернет число абсолютным,если -3 то 3,тут проверка на ближнее число к нулю и каждый раз он обновляет его,
            //Если какое-либо число ближе к нулю, чем текущее,то оно становится новым ближним числом к нулю
            if (Math.Abs(num) < Math.Abs(closestNumber) || (Math.Abs(num) == Math.Abs(closestNumber) && num > closestNumber))
            {
                closestNumber = num;
            }
        }
    }
}
