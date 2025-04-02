/* Виноградов Данил ИТВД 2 курс
ДЗ 1.3 (3⭐) Рассмотрим решение квадратного уравнения. Мы будем 
обозначать его коэффициенты буквами a, b и c, причем 
предполагается, что a не равен 0. В конце мы должны получить 
число решений (нет, 1 или 2), и сами решения (если они есть). 
*/
static double[] SquareEqSolver(double a, double b, double c)
{
    double[] result = {0,0};
    double discriminant = discriminant = b * b - 4 * a * c;
    if (discriminant >= 0)
    {
        result[0] = (-b + Math.Sqrt(discriminant)) / (2 * a);
        result[1] = (-b - Math.Sqrt(discriminant)) / (2 * a);
        return result;
    }
    return Array.Empty<double>();
}
static void ShowResult(double[] result)
{
    if (result.Length > 0)
    {
        for (int i = 0; i < result.Length; i++)
            Console.WriteLine($"x{i+1} = {result[i]}");
    }
    else
        Console.WriteLine("Решений нет");
}
Console.WriteLine("x^2 + 4x + 4");
ShowResult(SquareEqSolver(1, 4, 4));
Console.WriteLine();
Console.WriteLine("x^2 + 2x - 3");
ShowResult(SquareEqSolver(1, 2, -3));
Console.WriteLine();
Console.WriteLine("-15.25x^2 - 34.98x - 44.12");
ShowResult(SquareEqSolver(-15.25, -34.98, -44.12));
Console.WriteLine();
Console.WriteLine("x^2 - 1");
ShowResult(SquareEqSolver(1, 0, -1));
Console.WriteLine();
Console.WriteLine("x^2 + x");
ShowResult(SquareEqSolver(1, 1, 0));