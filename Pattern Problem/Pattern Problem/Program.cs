Console.WriteLine("Please Enter a number");
int input=int.Parse(Console.ReadLine());
for (int i = 0; i < input; i++)
{
    int space = input - i - 1;
    for (int k = 0; k < space; k++)
    {
        Console.Write(" ");
    }
    for (int j = 0; j <= i; j++)
    {
        Console.Write("* ");
    }
    Console.WriteLine();
}


/*     *
     * * *
    * * * *      */