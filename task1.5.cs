int age;

age=int.Parse(Console.ReadLine());

if (age > 0) {
    if (age < 18)
    {
        Console.WriteLine("Suruculuk vesiqesi ala bilmersiniz");
    }
    else
    {
        Console.WriteLine("Suruculuk vesiqesi ala bilersiniz");
    }
}
else
{
    Console.WriteLine("Yasinizi duzgun daxil edin");
};