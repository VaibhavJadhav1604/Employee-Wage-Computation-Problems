const int isft = 1;
const int ispt = 0;
const int emprateperhr = 20;
const int dayinmonth = 20;
const int maxhrinmonth = 100;
int totalwage = 0;
int emphr = 0;
int totalemphr=0;
int workingdays = 0;

while (totalemphr<=maxhrinmonth && workingdays<dayinmonth)
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
    Console.WriteLine("Days:"+ workingdays +"  Emp Hours:"+ totalemphr);
}
totalwage = totalemphr * emprateperhr;
Console.WriteLine("Total Wage Is:"+ totalwage);