// Задача 3. Задайте произвольный массив. Выведете его элементы, 
// начиная с конца. Использовать рекурсию, не использовать циклы.

Console.Clear();
int String(string text)
{
  Console.Write(text);
  int result = Convert.ToInt32(Console.ReadLine());
  return result;
}

int Number(int N, int M)
{
  if (N == M) return N;
  else Console.Write($"{Number(N, M + 1)}, ");
  return M;
}

int N = String("Введите число: ");
if (N < 1)
{
  Console.WriteLine("Ввдите положительное число!");
  return;
}
Console.WriteLine(Number(N, 1));