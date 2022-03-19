// See httpConsole.WriteLine("Please Enter a number");
int input = int.Parse(Console.ReadLine());
for (int i = 1; i <= input * 2 - 1; i++)
{
    int space = i > input ? i - input : input - i;
    for (int j = 0; j < space; j++)
    {
        Console.Write(" ");
    }
    int col = i > input ? input * 2 - i : i;
    for (int k = 0; k < col; k++)
    {
        if(i==1|| i == input * 2 - 1 || k == 0 || k == col - 1)
        {
            Console.Write("* ");
        }
        else
        {
            Console.Write("  ");   //here you have to place double space.
        }
    }
    Console.WriteLine();
}


/*   *
    * *
   *   *
  *     *
 *       *
  *     *
   *   *
    * *
     *               */
