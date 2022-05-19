  
Console.WriteLine("Введите число: ");
int n = Convert.ToInt32(Console.ReadLine());


int result = n/1000;
while (result != 0)
{
    result = n/10000;
    n = n/10;
}

int result2 = n/100;
if (result2 != 0)
{
    int n2 = n%10;
    Console.Write(n2);
}
else
{
    Console.Write("нет третьей цифры");
}


