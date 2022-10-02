int isft = 1;
int ispt = 0;
int emphr = 0;
int emprateperhr = 20;
int empwage = 0;

Random ran=new Random();
int empcheck=ran.Next(0,3);

if(empcheck==isft)
{
    emphr= 8;
}
else if(empcheck==ispt)
{
    emphr = 4;
}
else
{
    emphr = 0;
}

empwage = emphr * emprateperhr;
Console.WriteLine("Total Employee Wage Is:"+ empwage);