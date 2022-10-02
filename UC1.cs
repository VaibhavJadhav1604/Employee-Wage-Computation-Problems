int isft = 1;
Random ran = new Random();
int empcheck = ran.Next(0, 2);
if (empcheck == isft)
{
    Console.WriteLine("Employee Is Present");
}
else
{
    Console.WriteLine("Employee Is Absent");
}