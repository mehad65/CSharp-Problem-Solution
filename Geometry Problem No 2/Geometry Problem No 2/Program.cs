Console.WriteLine("Please enter your first point's location");
string A = Console.ReadLine();
Console.WriteLine("Please enter your second point's location");
string B = Console.ReadLine();
Console.WriteLine("Please enter your third point's location");
string C = Console.ReadLine();
int x1 = int.Parse(A.Split(",")[0]);
int y1 = int.Parse(A.Split(",")[1]);
int x2 = int.Parse(B.Split(",")[0]);
int y2 = int.Parse(B.Split(",")[1]);
int x3 = int.Parse(C.Split(",")[0]);
int y3 = int.Parse(C.Split(",")[1]);
double area = (double)1/2*(x1 * (y2 - y3) - x2 * (y1 - y3) + x3 * (y1 - y2));
Console.WriteLine(area);




