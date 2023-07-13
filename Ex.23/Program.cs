// Напишите программу, которая принимает на вход число (N) 
// и выдаёт таблицу кубов чисел от 1 до N.
// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125

void Output(int n)
{
    Console.WriteLine($"Квадраты чисел в промежутке от 1 до {n}:", n);
    for (int i = 1; i < n; i++)
    {
        Console.Write(i*i*i+", ");
    }
    Console.WriteLine(n*n*n);
}

Console.Write("Введите число N: ");
int n = int.Parse(Console.ReadLine());
Output(n);