using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task05_Hotel
{
    class Program
    {
        static void Main(string[] args)
        {
            string month = Console.ReadLine();
            int nigths = int.Parse(Console.ReadLine());

            double studio = 0;
            double Double = 0;
            double suite = 0;

            switch (month)
            {
                case "May":
                    if (nigths > 7)
                    {
                        studio = (50 * nigths) * 0.95;
                    }
                    else
                    {
                        studio = 50 * nigths;
                    }
                    Double = 65 * nigths;
                    suite = 75 * nigths;
                    break;

                case "October":
                    if (nigths > 7)
                    {
                        studio = ((50 * (nigths - 1)) * 0.95);
                    }
                    else
                    {
                        studio = 50 * nigths;
                    }
                    Double = 65 * nigths;
                    suite = 75 * nigths;


                    break;
                case "June":
                case "September":
                    if (nigths > 7 && month == "September")
                    {
                        studio = (60 * (nigths - 1));
                    }
                    else
                    {
                        studio = 60 * nigths;
                    }
                    if (nigths > 14)
                    {
                        Double = (72 * nigths) * 0.90;
                    }
                    else
                    {
                        Double = 72 * nigths;
                    }
                    suite = 82 * nigths;
                    break;
                case "July":
                case "August":
                case "December":
                    studio = 68 * nigths;
                    Double = 77 * nigths;
                    if (nigths > 14)
                    {
                        suite = (89 * nigths) * 0.85;
                    }
                    else
                    {
                        suite = 89 * nigths;
                    }


                    break;
                default:
                    break;
            }
            Console.WriteLine("Studio: {0:F2} lv.", studio);
            Console.WriteLine("Double: {0:F2} lv.", Double);
            Console.WriteLine("Suite: {0:F2} lv.", suite);
        }
    }
}