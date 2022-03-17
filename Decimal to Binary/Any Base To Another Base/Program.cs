using Any_Base_To_Another_Base;
using System.Text;

Console.WriteLine("Please Enter a value");
string? value=Console.ReadLine();
Console.WriteLine("Enter the input base value");
int inputbase=int.Parse(Console.ReadLine());
Console.WriteLine("Enter the destination base value");
int outputbase=int.Parse(Console.ReadLine());
Converter convert= new Converter(); 
if (inputbase == 10)
{
    var output=convert.ToAnyBase(int.Parse(value), outputbase);
    Console.WriteLine(output);
}
else
{
    var output = convert.ToDecimal(value, inputbase);
    var finaloutput = convert.ToAnyBase((int)output, outputbase);
    Console.WriteLine(finaloutput);
}