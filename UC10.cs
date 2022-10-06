using System;

public class empcal
{
    const int isft = 1;
    const int ispt = 0;
    String company;
    int emprateperhr;
    int noofworkingdays;
    int maxhrinmonth;

    public empcal(String company, int emprateperhr, int noofworkingdays, int maxhrinmonth)
    {
        this.company = company;
        this.emprateperhr = emprateperhr;
        this.noofworkingdays = noofworkingdays;
        this.maxhrinmonth = maxhrinmonth;
        int totalwage = 0;
        int emphr = 0;
        int totalemphr = 0;
        int workingdays = 0;

        while (totalemphr <= maxhrinmonth && workingdays < noofworkingdays)
        {
            workingdays++;
            Random ran = new Random();
            int empcheck = ran.Next(0, 3);
            switch (empcheck)
            {
                case isft:
                    emphr = 8;
                    break;
                case ispt:
                    emphr = 4;
                    break;
                default:
                    emphr = 0;
                    break;
            }
            totalemphr += emphr;
            Console.WriteLine("Days:" + workingdays + "  Emp Hours:" + totalemphr);
        }
        totalwage = totalemphr * emprateperhr;
        Console.WriteLine("Total Wage For Company:" + company + " is " + totalwage);
    }
}
namespace UC10
{
    internal class UC10
    {
        static void Main(string[] args)
        {
            empcal[] ob = new empcal[5];
            
            for(int i=0;i<1; i++)
            {
                ob[i] = new empcal("AAA", 230, 26, 208);
                ob[i+1] = new empcal("BBB", 220, 25, 200);
                ob[i+2] = new empcal("CCC", 210, 24, 192);
                ob[i+3] = new empcal("DDD", 230, 26, 208);
                ob[i+4] = new empcal("EEE", 220, 25, 20);
                ob[i+5] = new empcal("FFF", 220, 25, 20);
            }
        }
    }
}
