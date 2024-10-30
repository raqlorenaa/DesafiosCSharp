using System;
using System.Linq;

public static class Armstrong
{
    public static bool IsArmstrong(this int number)
    {
        var digits = number.ToString().Select(d => int.Parse(d.ToString())).ToArray();
        int numDigits = digits.Length;
        int sum = digits.Select(d => (int)Math.Pow(d, numDigits)).Sum();
        return sum == number;
    }
}
