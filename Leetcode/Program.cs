using System.Text;

public class Solution
{
    //public string LicenseKeyFormatting(string s, int k)
    //{
    //    s = s.Replace("-", "").ToUpper();
    //    int middle = s.Length % k;
    //    int length = s.Length;
    //    StringBuilder result = new StringBuilder();
    //    result.Append(s.Substring(0, firstGroupLength));

    //    for (int i = middle; i < length; i += k)
    //    {
    //        result.Append('-');
    //        result.Append(s.Substring(i, k));
    //    }

    //    return result.ToString();

    //}

    //первый кейс не проходит 

    public string LicenseKeyFormatting(string s, int k)
    {
        
        s = s.Replace("-", "").ToUpper();

       
        int length = s.Length;

        //проверка на дефисы

        if (length == 0)
        {
            return "";
        }


        int middle = length % k;
        if (middle == 0) middle = k;

        StringBuilder result = new StringBuilder();

        //проверка на не ноль
        if (middle > 0)
        {
            result.Append(s.Substring(0, middle));
        }

        result.Append(s.Substring(0, middle));
        for (int i = middle; i < length; i += k)
        {
            result.Append('-');
            result.Append(s.Substring(i, k));
        }

        return result.ToString();
    }
}