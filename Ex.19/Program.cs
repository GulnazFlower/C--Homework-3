// Напишите программу, которая принимает на вход пятизначное число 
// и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да

void Palindrome(int n)
{
    int firstDigit = n / 10000;
    int secondDigit = (n / 1000) % 10;
    int forthDigit = (n % 100) / 10;
    int fifthDigit = n % 10;

    if (firstDigit == fifthDigit & secondDigit == forthDigit)
    {
        Console.WriteLine($"{n} -> да");
    }
    else
    {
        Console.WriteLine($"{n} -> нет");
    }
}

int GetInput(string text)
{
    Console.Write(text);
    return Convert.ToInt32(Console.ReadLine());
}

int n = GetInput("Введите пятизначное число: ");
Palindrome(n);