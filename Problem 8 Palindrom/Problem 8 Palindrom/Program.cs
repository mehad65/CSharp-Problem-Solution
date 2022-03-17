Console.WriteLine("Please enter a word");
var input=Console.ReadLine();
char[] inputarr=input.ToCharArray();
inputarr.Reverse();
string output=new string(inputarr);
if (input.ToLower() == output.ToLower())
{
    Console.WriteLine("Your text is Palindrom");
}
else
{
    Console.WriteLine("Your text is not palindrom");
}