/* Виноградов Данил ИТВД 2 курс
ДЗ 1.5 (3⭐) Ввести длины сторон двух треугольников и вывести 
текст «да», если треугольники подобны, и «нет», если не подобны.
*/
static bool Equal(double a, double b)
{
    if (Math.Abs(a-b) < 0.0001)
        return true;
    return false;
}
Console.Write("Введите первую сторону первого треугольника ");
double a = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите вторую сторону первого треугольника ");
double b = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите третью сторону первого треугольника ");
double c = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите первую сторону второго треугольника ");
double a1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите вторую сторону второго треугольника ");
double b1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите третью сторону второго треугольника ");
double c1 = Convert.ToDouble(Console.ReadLine());
if (Equal(a / a1, b / b1) && Equal(c / c1,a / a1))
    Console.WriteLine("трегульники подобны");
else if (Equal(a / a1, b / c1) && Equal(c / b1, a / a1))
    Console.WriteLine("трегульники подобны");
else if (Equal(a / b1, b / a1) && Equal(c / c1, a / b1))
    Console.WriteLine("трегульники подобны");
else if (Equal(a / b1, b / c1) && Equal(c / a1, a / b1))
    Console.WriteLine("трегульники подобны");
else if (Equal(a / c1, b / a1) && Equal(c / b1, a / c1))
    Console.WriteLine("трегульники подобны");
else if (Equal(a / c1, b / b1) && Equal(c / a1, a / c1))
    Console.WriteLine("трегульники подобны");
else 
    Console.WriteLine("трегульники не подобны");

