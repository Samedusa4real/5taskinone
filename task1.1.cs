int num;
num = int.Parse(Console.ReadLine());

if (num % 2 == 0)
{
    num = num / 2;
    Console.WriteLine(num);
}
else
{
    num = num * 2;
    Console.WriteLine(num);
}

