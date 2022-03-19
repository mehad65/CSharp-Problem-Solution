Console.WriteLine("Please Enter a Number");
long input=long.Parse(Console.ReadLine());
bool result=true;
for (int i = 2; i <= input/2; i++)
{
    if (input % i == 0)
    {
        result=false;
        break;
    }
}
Console.WriteLine(result);

