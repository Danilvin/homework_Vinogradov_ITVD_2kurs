/* Виноградов Данил ИТВД 2 курс
ДЗ 1.1 (1⭐) Написать программу, печатающую все простые числа, 
не превосходящие заданного числа;
*/
int n = Convert.ToInt32(Console.ReadLine());
int j;
for (int i=2; i<n; i++)
{
    for (j=2; j<=Math.Sqrt(i); j++)
    {
        if (i % j == 0)
            break;
    }
    if (j > Math.Sqrt(i))
        Console.WriteLine(i);
}