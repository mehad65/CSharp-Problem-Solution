Console.WriteLine("Please enter numbers with comma separator");
string input=Console.ReadLine(); 
string[] numbers=input.Split(',');
int[] intnumbers=new int[numbers.Length];
string k;
for(int i=0; i<numbers.Length; i++)
{
    for (int j = 0; j < numbers.Length-1; j++)
    {
        if (int.Parse(numbers[i]) < int.Parse(numbers[j]))
        {
            k = numbers[i];
            numbers[i]=numbers[j];
            numbers[j]=k;
        }
    }
}
foreach (var item in numbers)
{
    string comma = item.Equals(numbers.LastOrDefault()) ? " " : ", ";
    Console.Write(item +comma);
}

