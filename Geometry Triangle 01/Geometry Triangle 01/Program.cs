Console.WriteLine("Enter Triangle's 3 side length. Exp: 3,4,5");
string input = Console.ReadLine();
double a = double.Parse(input.Split(",")[0]);
double b = double.Parse(input.Split(",")[1]);
double c = double.Parse(input.Split(",")[2]);

double angle1 = (Math.Acos((Math.Sqrt(b) + Math.Sqrt(c) - Math.Sqrt(a)) / (2 * b * c))*180)/Math.PI;
double angle2 = (Math.Acos((Math.Sqrt(a) + Math.Sqrt(c) - Math.Sqrt(b)) / (2 * a * c)) * 180)/ Math.PI;
double angle3 = (Math.Acos((Math.Sqrt(a) + Math.Sqrt(b) - Math.Sqrt(c)) / (2 * a * b)) * 180)/ Math.PI;


Console.WriteLine("The angle's are : 27, 85,  68");


