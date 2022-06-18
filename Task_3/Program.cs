// Программа которая принимает на вход число N и выдает таблицу кубов от 1 до N

Console.WriteLine("Введите число ");
int Namber = Convert.ToInt32(Console.ReadLine());

void Cube (int N)
{
    for (int i = 1; i <= N; i++)
    {
        int Namber2 = i * i * i;
        Console.Write($"{Namber2},");
    }
}
Cube(Namber);
