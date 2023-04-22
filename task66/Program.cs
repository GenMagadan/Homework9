// Задача 66: Задайте значения M и N. Напишите программу, которая 
// найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

Console.Write("Ввведите число N: ");
int N = int.Parse(Console.ReadLine());
Console.Write("Ввведите число M: ");
int M = int.Parse(Console.ReadLine());

int temp;
if (N > M)
{
   temp = M;
   M = N;
   N = temp;
}

int SumElementInNumber(int number1, int number2)
{
   int temp;
   if (number1 > number2)
   {
      return 0;
   }
   return number1 + SumElementInNumber(number1 + 1, number2);

}
SumElementInNumber(N, M);
Console.Write($"M = {M}; N = {N} -> ");
Console.Write(SumElementInNumber(N, M));

// M = 1; N = 15 -> 120
// M = 15; N = 1 -> 120
