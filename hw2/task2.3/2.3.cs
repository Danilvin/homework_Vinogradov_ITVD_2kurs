/* Виноградов Данил ИТВД 2 курс
Ввести вещественное число -1 <= x <= 1 и вычислить приближение к e^x, пользуясь формулой
e^x = 1 + x + (x^2/2!) + (x^3/3!) + ...
Закончить вычисления, когда очередное слагаемое станет меньше 10^-6
*/
using System.Numerics;

static double Factorial(int n)
{
    double res = 1;
    for (int i = 1; i <= n; i++)
        res *= i;
    return res;
}
static double Exp(double x)
{
    double res = 1 + x;
    int i = 2;
    while (Math.Pow(x, i)/Factorial(i) >= 0.000001)
    {
        res += Math.Pow(x, i) / Factorial(i);
        i++;
    }
    return res;
}

Console.Write("Введите x: ");
double x = Convert.ToDouble(Console.ReadLine());
Console.WriteLine($"e^{x} = {Exp(x)}");
