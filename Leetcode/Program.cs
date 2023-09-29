public class Solution
{
    public string CategorizeBox(int length, int width, int height, int mass)
    {

        long volume = (long)length * (long)width * (long)height;

        //int k = length * width * height; два кейса не проходит
        //оказывается он большие цифры не принимает и для этого нужен лонг

        int d = 10000;

        int j = 1000000000;

        bool isBulky = (length >= d || width >= d || height >= d || volume >= j);
        bool isHeavy = (mass >= 100);

        if (isBulky && isHeavy)
        {
            return "Both";
        }
        else if (isBulky)
        {
            return "Bulky";
        }
        else if (isHeavy)
        {
            return "Heavy";
        }
        else
        {
            return "Neither";
        }

        //    if (length >= d || width >= d || height  >= d || mass >= d ||  k >= j) 
        //    {
        //        return "Bulky";
        //    }
        //    else
        //    {
        //        return "Heavy";
        //    }

        //    if (mass >= 100) 
        //    {
        //        return "Bulky";
        //    }
        //    else
        //    {
        //        return "Heavy";
        //    }
        //}
    }
}
