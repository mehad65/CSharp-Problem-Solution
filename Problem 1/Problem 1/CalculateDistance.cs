using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_1
{
    internal class CalculateDistance
    {
        public double Calculate(int x1,int y1, int x2, int y2)
        {
            double distance=Math.Sqrt(Math.Pow((x2 - x1),2)+Math.Pow((y2-y1),2));
            return distance;
        }
    }
}
