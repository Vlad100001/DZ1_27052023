Console.Clear();
Console.Write("Введите число: ");
int a = int.Parse(Console.ReadLine()!);

if (a>1)
    {
    for (int i = 2; i <= a;  i = i+2)
    Console.Write($"{i} ");}  
else
    Console.WriteLine("ошибка");