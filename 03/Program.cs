// Задача 3. Задайте произвольный массив. Выведете его элементы, 
// начиная с конца. Использовать рекурсию, не использовать циклы.

void MyNumber(int n)
{
    if (n == 0) return;
    {
        MyNumber(n - 1);
        Console.WriteLine(n);
    }
}

Console.Write("Введите число N: ");
int N = Convert.ToInt32(Console.ReadLine());
MyNumber(N);