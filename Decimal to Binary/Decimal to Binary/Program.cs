using System.Text;

Console.WriteLine("Please Enter a Decimal number");
int inputnumber=int.Parse(Console.ReadLine());
Console.WriteLine("Enter the base");
int basevalue=int.Parse(Console.ReadLine()); 
StringBuilder sb = new StringBuilder();
string result;
if (inputnumber != 0)
{
    int i = 0;
    int rem;
    while (inputnumber != 0)
    {
        rem = inputnumber % basevalue;
        sb.Append(rem);
        inputnumber=inputnumber / basevalue;

    }
    result = StringHelper.ReverseString(sb.ToString());
}
else
{
    result = "0";
}

Console.WriteLine(result);
static class StringHelper
{
    public static string ReverseString(string str)
    {
        char[] array = str.ToCharArray();
        Array.Reverse(array);
        return new string(array);
    }
}