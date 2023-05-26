Console.Clear();
Console.Write("Введите 1 число: ");
int a = int.Parse(Console.ReadLine()!);
Console.Write("Введите 2 число: ");
int b = int.Parse(Console.ReadLine()!);
Console.Write("Введите 3 число: ");
int c = int.Parse(Console.ReadLine()!);
if (a>b && a>c)
    Console.WriteLine($"max= {a} ");
else if (b>c)
    Console.WriteLine($"max = {b} ");
    else  
    Console.WriteLine($"max = {c} ");
