Console.WriteLine("Please enter a string");
string input= Console.ReadLine();   
char[] inputchars= input.ToCharArray();
Array.Reverse(inputchars);
String Check=new string(inputchars);
if (input.ToLower().Equals(Check.ToLower()))
{
    Console.WriteLine("Palindrome");
}
else
{
    Console.WriteLine("Not Palindrome");
}