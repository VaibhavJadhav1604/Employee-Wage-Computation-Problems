using System.Linq.Expressions;

const int isft = 1;
const int ispt = 0;
int emphr = 0;
const int emprateperhr = 20;
int empwage = 0;

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

empwage = emphr * emprateperhr;
Console.WriteLine("Total Wage Is:"+empwage);