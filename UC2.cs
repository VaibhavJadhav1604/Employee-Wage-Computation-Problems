int isft = 1;
int emphr = 0;
int emprateperhr = 20;
Random ran = new Random();
int empcheck = ran.Next(0, 2);
int empwage = 0;
if (empcheck == isft)
{
    emphr = 8;
}
else
{
    emphr = 0;
}

empwage = emphr * emprateperhr;
Console.WriteLine("Total Employee Wage Is:" + empwage);
