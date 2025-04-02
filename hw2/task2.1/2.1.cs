/* Виноградов Данил ИТВД 2 курс
ДЗ 2.1 (1⭐) Заданы две строки: S и S1. 
Найдите количество вхождений S1 в S как подстроки.
*/
string s = Console.ReadLine();
string s1 = Console.ReadLine();
int ls = s.Length;
int ls1 = s1.Length;
int c = 0;
for (int i = 0; i < ls-ls1+1; i++)
{
   if (s[i..(i+ls1)] == s1)
        c++;
}
Console.WriteLine(c);