using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            string work;
            Console.WriteLine("Coefficient of variation and assimilation of the series");
            do
            {
                int count, x, r, xmax, xmin, sum;
                int d = 0, o = 0;
                double vr, vd, vo;
                Console.Write("Enter the size of the series: ");
                count = Int32.Parse(Console.ReadLine());
                int[] row = new int[count];
                Console.Write("Enter the 1-th element of the series: ");
                row[0] = Int32.Parse(Console.ReadLine());
                xmax = row[0];
                xmin = row[0];
                sum = row[0];
                for (int i = 1; i < count; i++)
                {
                    Console.Write("Enter the {0}-th element of the series: ", i+1);
                    row[i] = Int32.Parse(Console.ReadLine());
                    sum = sum + row[i];
                    if (xmax < row[i])
                    {
                        xmax = row[i];
                    }
                    if (xmin > row[i])
                    {
                        xmin = row[i];
                    }
                }
                x = sum / count;
                r = xmax - xmin;
                for (int i = 0; i < count; i++)
                {
                    d = d + Math.Abs(row[i] - x);
                    o = o + Math.Abs(row[i] - x) * Math.Abs(row[i] - x);
                }
                vr = ((double)r / x) * 100;
                Console.WriteLine("Oscillation coefficient = {0}%", vr);
                vd = ((double)d / (count * x)) * 100;
                Console.WriteLine("Linear coefficient of variation = {0}%", vd);
                vo = (Math.Sqrt((double)o / count) / x) * 100 ;
                Console.WriteLine("Variation coefficient = {0}%", vo);
                Console.WriteLine("Want to try again? y/n");
                work = Console.ReadLine();
            } while (work != "n");
        }
    }
}
