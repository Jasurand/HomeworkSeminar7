// Задача 1. Задайте значения M и N. Напишите программу, 
// которая найдёт сумму натуральных элементов в промежутке от M до N.

Console.Clear();
int String(string message)
{
  Console.Write(message);
  int result = Convert.ToInt32(Console.ReadLine());
  return result;
}

int Sum(int N, int M)
{
  if (N == M) return N;
  else return Sum(N + 1, M) + N;
}

int N = String("Введите первое число: ");
int M = String("Введите второе число: ");
Console.WriteLine($"Сумма между этими числами: {Sum(N, M)}");