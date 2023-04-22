// Задача 68: Напишите программу вычисления функции Аккермана с 
// помощью рекурсии. Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29

Console.Write("Введите число n: ");
int n = int.Parse(Console.ReadLine());
Console.Write("Введите число m: ");
int m = int.Parse(Console.ReadLine());

int Akkerman(int a, int b)
{
   if (a == 0)
   {
      return b + 1;
   }
   else if (b == 0 && a > 0)
   {
      return Akkerman(a - 1, 1);
   }
   else
   {
      return (Akkerman(a - 1, Akkerman(a, b - 1)));
   }
}

int result = Akkerman(n, m);
Console.Write($"n = {n}, m = {m} -> A(n, m) = {result}");



