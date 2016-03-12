using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinaryCode
{
    class Program
    {
        static void Main(string[] args)
        {
           
            Console.WriteLine(BinaryDouble("10.625"));
        }

        public static string BinaryDouble(string input)
        {

            string output = "";
            
            if (input.Contains("."))
            {
                var tempOutput = input.Split('.');
                output += BinaryCode(tempOutput[0])+".";
                output += SegmentPart(tempOutput[1],10);

            }
            else
            {
                output += BinaryCode(input); 
            }

            return output;
        }
        public static string BinaryCode(string input)
        {
            int toBinary = Convert.ToInt32(input);
            var temp=0;
            string output ="";
            while (toBinary > 0)
            {
                temp = toBinary%2;
                output += temp.ToString();
                toBinary/=2;
            }
            return output;
        }

        public static string SegmentPart(string segment, int acc)
        {
            double seg = Convert.ToDouble("0," + segment);
            int i = 0;
            double temp = 0;
            string output = "";
            temp = seg;
            while (i < acc)
            {
                temp *= 2;
                if (temp >= 1.0)
                {

                    output += "1";
                    temp--;
                    continue;
                }
                if (temp == 0)
                {
                    output += "0";
                    return output;

                }
                else
                {
                    output += "0";
                }


                i++;
            }
            return output;
        }


    }
}
