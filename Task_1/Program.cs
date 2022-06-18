// Программа которая на вход принимает 5 значное число и проверяет, является ли это число палиндромом 
Console.WriteLine("Введите число ");
int Namber = Convert.ToInt32(Console.ReadLine());

void palindrom (int num)
{
    int num1 = num / 10000;
    int num2 = (num % 1000) / 1000;
    int num4 = (num % 100) / 10;
    int num5 = (num % 10);

    if (num1 == num5 || num2 == num4)
    {
        Console.WriteLine("Число является палиндромом");
    }
    else 
    {
        Console.WriteLine("Число НЕ является палиндромом");
    }
    
}
palindrom(Namber);