using System;

public class Solution
{
    public bool StrongPasswordCheckerII(string password)
    {
        if (password.Length < 8)
        {
            return false;
        }

        var isLower = false;
        var isUpper = false;
        var isDigit = false;
        var isContains = false;

        foreach (char str in password)
        {
            if (Char.IsLower(str))
            {
                isLower = true;
            }
            if (Char.IsUpper(str))
            {
                isUpper = true;
            }
            if (Char.IsDigit(str))
            {
                isDigit = true;
            }
            if ("!@#$%^&*()-+".Contains(str))
            {
                isContains = true;
            }
        }

        int count = 1;
        for (int i = 0; i < password.Length - 1; i++)
        {
            if (password[i] == password[i + 1])
            {
                count++;
                if (count == 2)
                {
                    return false;
                }
            }
            else
            {
                count = 1;
            }
        }

        return (isLower && isDigit && isContains && isUpper);
    }
}