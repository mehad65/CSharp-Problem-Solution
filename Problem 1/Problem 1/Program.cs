Console.WriteLine("Enter A points Location");
string A=Console.ReadLine(); 
Console.WriteLine("Enter B points location");
string B=Console.ReadLine(); 
string[] Apoint = A.Split(',');
string[] Bpoint = B.Split(",");
int x1=int.Parse(Apoint[0]);   
int y1=int.Parse(Apoint[1]);
int x2=int.Parse(Bpoint[0]);
int y2=int.Parse(Apoint[1]);
double distance= Math.Sqrt(Math.Pow((x2-x1),2)+Math.Pow((y2-y1),2));

Console.WriteLine("Distance = " + distance);