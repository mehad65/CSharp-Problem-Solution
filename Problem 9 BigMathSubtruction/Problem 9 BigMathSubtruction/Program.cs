using System;
using System.Text;
namespace ok;
public static class BigMathSubstruction{
    public static void Main(string[] args)
    {
        Console.WriteLine("Please Enter BigNum1");
        string str1 = Console.ReadLine();
        Console.WriteLine("Plseas Enter BigNum2");
        string str2 = Console.ReadLine();
        string reverStr1 = ReverseString(str1);
        string reverStr2=ReverseString(str2);
        if (!IsBigger(str1, str2))  //str1>str2
        {
            string holder = reverStr1;
            reverStr1 = reverStr2;
            reverStr2 = holder;
        }
        int rem=0;
        StringBuilder sb = new StringBuilder();
        for (int i = 0; i < reverStr2.Length; i++)
        {
            int num1 = (int)reverStr1[i] - '0';
            int num2 = (int)reverStr2[i] - '0';
            if (num1-num2 - rem >= 0 )
            {
                int result = num1 - num2-rem;
                sb.Append(result.ToString());
                rem = 0;
            }
            else
            {
                int result = num1 - num2 + 10-rem;
                rem = 1;
                sb.Append(result.ToString());
            };      
        }
        for (int i = reverStr2.Length; i < reverStr1.Length; i++)
        {
            int result = (int)reverStr1[i] - '0' - rem;
            if (result >= 0)
            {
                sb.Append(result.ToString());
                rem = 0;
            }
                
            else
            {
                sb.Append(result.ToString());
                rem = 1;
            }
        }
        if(!IsBigger(str1, str2))
        {
            sb.Append('-');
        }
        Console.WriteLine(ReverseString(sb.ToString()));
    }
    public static bool IsBigger(string str1, string str2)
    {
        if (str1.Length > str2.Length)
            return true;
        if (str1.Length < str2.Length)
            return false;
        bool result=false;
        for (int i = 0; i < str1.Length; i++)
        {
             if (str1[i] > str2[i])
           
                return true;
             if (str1[i] < str2[i])
                return false;
        }
        return result;
    }
    public static string ReverseString(string str)
    {
        char[] array = str.ToCharArray();
        Array.Reverse(array);
        return new string(array);
    }
}

