using System;
using System.Collections.Generic;

const int isft = 1;
const int ispt = 0;

void calempwage(String company,int emprateperhr,int noofworkingdays,int maxhrinmonth)
{
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

calempwage("Wipro",230,26,208);
Console.WriteLine("----------------------------------------------------------------------------------");
calempwage("Infosys",240,25,200);