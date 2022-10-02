const int isft = 1;
const int ispt = 0;
int emphr = 0;
const int emprateperhr = 20;
int empwage = 0;
const int dayinmonth = 20;
int totalwage = 0;

for (int i = 1; i < dayinmonth; i++)
{
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
    totalwage += empwage;
    Console.WriteLine("Day:"+i+"   Wage:"+empwage);
}

Console.WriteLine("Total Wage Of Month Is:"+ totalwage);