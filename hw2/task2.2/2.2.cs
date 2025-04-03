/* Виноградов Данил ИТВД 2 курс
ДЗ 2.2 (2⭐) Реализовать подсчет 
факториала/фибоначчи (рекурсивно и итеративно). 
Выяснить, с какого номера числа подсчета факториала/фибоначчи 
рекурсивный вариант заметно медленнее итеративного. .
*/
using System.Numerics;

static BigInteger FactorialIter(int n)
{
    BigInteger res = BigInteger.One;
    for (int i = 1; i <= n; i++)
        res *= i;
    return res;
}
static BigInteger FactorialRecur(int n)
{
    if (n == 1)
        return n;
    return n * FactorialRecur(n - 1);
}
static BigInteger FibonacciIter(int n)
{
    if ((n == 0) || (n == 1))
        return n;
    BigInteger res = BigInteger.Zero;
    BigInteger a = BigInteger.Zero;
    BigInteger b = BigInteger.One;
    for (int i = 2; i <= n; i++)
    {
        res = a+b;
        a = b;
        b = res;
    }
    return res;
}
static BigInteger FibonacciRecur(int n)
{
    if ((n == 0) || (n == 1))
        return n;
    return FibonacciRecur(n - 1) + FibonacciRecur(n - 2);
}

Console.Write("Введите n: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"{n}! = {FactorialIter(n)}");
Console.Write("Введите n: ");
n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"{n} элемент последовательности Фибоначчи" +
                                      $" = {FibonacciIter(n)}");

Console.WriteLine();

var watch = System.Diagnostics.Stopwatch.StartNew();
FactorialIter(7000);
watch.Stop();
var elapsedMs = watch.ElapsedMilliseconds;
Console.WriteLine($"FactorialIter(7000) - {elapsedMs} ms");
var watch1 = System.Diagnostics.Stopwatch.StartNew();
FactorialRecur(7000);
watch1.Stop();
var elapsedMs1 = watch1.ElapsedMilliseconds;
Console.WriteLine($"FactorialRecur(7000) - {elapsedMs1} ms");
var watch2 = System.Diagnostics.Stopwatch.StartNew();
FibonacciIter(30);
watch2.Stop();
var elapsedMs2 = watch2.ElapsedMilliseconds;
Console.WriteLine($"FibonacciIter(30) - {elapsedMs2} ms");
var watch3 = System.Diagnostics.Stopwatch.StartNew();
FibonacciRecur(30);
watch3.Stop();
var elapsedMs3 = watch3.ElapsedMilliseconds;
Console.WriteLine($"FibonacciRecur(30) - {elapsedMs3} ms");

