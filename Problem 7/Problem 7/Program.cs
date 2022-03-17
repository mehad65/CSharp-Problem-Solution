using System.Text;
Console.WriteLine("Please enter numbers with comma separator");
string input = Console.ReadLine();
string[] inputarray = input.Split(',');
for (int i = 0; i < inputarray.Length; i++)
{
    string store;
    for (int j = i+1; j < inputarray.Length; j++)
    {
        if (int.Parse(inputarray[i]) > int.Parse(inputarray[j]))
        {
            store = inputarray[i];
            inputarray[i] = inputarray[j];
            inputarray[j] = store;
        }
    }
}
StringBuilder sb = new StringBuilder();
foreach (var item in inputarray)
{
    sb.Append(item + ",");
}
sb.Remove(sb.Length - 1, 1);
Console.WriteLine(sb.ToString());
