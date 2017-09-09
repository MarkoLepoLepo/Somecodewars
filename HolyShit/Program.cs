using System;
using System.Collections.Generic;

namespace HolyShit
{
    public class Program
    {
        public static string AddBinary(int a, int b)
        {
            // your code ...

            string c = Convert.ToString(a+b,2);
            return c;
        }
        static int GetDigit(int x, int digitNumber)
        {
            if (digitNumber < 0)
                throw new ArgumentOutOfRangeException("digitNumber");
 
            int digitCount = (int)Math.Log10(x) + 1;
            if (digitNumber > digitCount)
                return 0;
 
            var pow = (int)Math.Pow(10, digitCount - digitNumber);
            return (x / pow) % 10;
        }
        public static long DigPow(int n, int p) {
            // your code
            string numn = Convert.ToString(n);
            int counter = 0;
            double checksum = 0;
            foreach (char ch in numn)
            {
                int a = GetDigit(n, counter + 1);
                checksum += Convert.ToDouble(Math.Pow(a, p + counter));
                counter++;
            }
            string k = Convert.ToString(checksum/n);
            bool result = Int32.TryParse(k, out int res);
            if (result)
            {
                return res;
            }
            else
            {
                return -1;
            }
        
        }
        public static int NbYear(int p0, double percent, int aug, int p) {
            int years = 0;
            double pops=p0;
            do
            {
                pops+= pops*percent*0.01 + aug;
                years++;
                pops = Math.Floor(pops);
            }
            while(p>=pops);
            return years;
        }
        public static IEnumerable<int> GetIntegersFromList(List<object> listOfItems)
        {
          List<int> result = new List<int>();
          foreach (object ob in listOfItems)
          {
              if (ob is int)
              {
                  int res = Convert.ToInt32(ob);
                  result.Add(res);
              }
          }
            return result;
        }
        public static string Tickets(int[] peopleInLine)
        { 
            
        }
        public static void Main()
        {
        
            Console.Write(NbYear(1500000, 2.5, 10000, 2000000));
        }
    }
}