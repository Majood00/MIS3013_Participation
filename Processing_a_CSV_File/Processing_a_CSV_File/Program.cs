using System;
using System.IO;

namespace Processing_a_CSV_File
{
    class Program
    {
        static void Main(string[] args)
        {
            string file = "sales_data_sample.csv";

            string[] contents = File.ReadAllLines(file);

            double salesFor2003 = 0;
            double salesFor2004 = 0;
            double salesFor2005 = 0;

            string months = "January,February,March,April,May,June,July,August,September,October,November,December";

            string[] seperatedMonths = months.Split(',');

            double[] monthlySalesAcrossAllYears = new double[12];

            for (int i = 1; i < contents.Length; i++)
            {

                string line = contents[i];

                string[] pieces = line.Split(',');

                double sale = Convert.ToDouble(pieces[4]);

                double saleForMonth = Convert.ToDouble(pieces[4]);

                int year = Convert.ToInt32(pieces[9]);

                string status = pieces[6];

                int month = Convert.ToInt32(pieces[8]);

                if (status == "Shipped")
                {
                    monthlySalesAcrossAllYears[month - 1] += saleForMonth;
                    if (year == 2003)
                    {
                        salesFor2003 += sale;
                    }
                    else if (year == 2004)
                    {
                        salesFor2004 += sale;
                    }
                    else if (year == 2005)
                    {
                        salesFor2005 += sale;
                    }
                    else
                    {
                        Console.WriteLine($"ERROR: No year for {year}");
                    }

                }

            }

            Console.WriteLine($"The sales for 2003 were {salesFor2003.ToString("C")}");
            Console.WriteLine($"The sales for 2004 were {salesFor2004.ToString("C")}");
            Console.WriteLine($"The sales for 2005 were {salesFor2005.ToString("C")}");

            for (int i = 0; i < 12; i++)
            {
                Console.WriteLine($"The sales for {seperatedMonths[i]} were {monthlySalesAcrossAllYears[i].ToString("C")}");
            }

        }
    }
}
