/* Виноградов Данил ИТВД 2 курс
ДЗ 1.2 (2⭐) Написать алгоритм нахождения неполного частного от 
деления a на b (целые числа), используя только операции сложения,
вычитания и умножения.
*/
int a = Convert.ToInt32(Console.ReadLine());
int b = Convert.ToInt32(Console.ReadLine());
int bc = b;
int i = 0;
while (Math.Abs(b) <= Math.Abs(a))
{
    if (b > a)
        b -= Math.Abs(bc);
    else if (b < a)
        b += bc;
    else if (b == a)
    {
        i++;
        break;
    }   
    if (a * bc > 0)
        i++;
    else
        i--;
}
i += ((b > 0) ? 0 : 1);
Console.WriteLine($"Неполное частное {i}, остаток {a - bc * i}");
