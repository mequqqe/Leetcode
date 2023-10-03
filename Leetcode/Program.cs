using System;
using System.Diagnostics;
using System.Xml.Linq;

public class Solution
{
    //public string DiscountPrices(string sentence, int discount)
    //{
    //    string[] arr = sentence.Split(' ');
    //    string searchElement = "$";
    //    bool containsNumber = false;
    //    foreach (string str in arr)
    //    {
    //        if (str == searchElement || sentence is int)
    //        {
    //            containsNumber = true;

    //            break;  
    //        }
    //    }
    //}

    public string DiscountPrices(string sentence, int discount)
    {
        string[] arr = sentence.Split(' ');
        string searchElement = "$";
        for (int i = 0; i < arr.Length; i++)
        {
            string word = arr[i];
            if (word.StartsWith("$"))
            {
                string numberPart = word.Substring(1);
                //if (double.TryParse(numberPart, out double price)) не проходит последнюю проверку и за точек и нолей 
                if (numberPart.All(c => char.IsDigit(c) || c == '.') && double.TryParse(numberPart, out double price))
                {
                    double discountPrice = price * (100 - discount) / 100;
                    arr[i] = $"${discountPrice:F2}";
                }
            }
        }
        return string.Join(" ", arr);
    }
}