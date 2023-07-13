// Задача 23
// Напишите программу, которая принимает на вход число (N)
// и выдаёт таблицу кубов чисел от 1 до N.
// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125

void ShowResponse(int N, int i)
{
    for(i = 1; i < N; i++)
    {
        Console.Write(i * i * i + ",");
    }
        Console.Write(N * N * N);
}

int GetInput(string text)
{
    Console.Write(text);
    return Convert.ToInt32(Console.ReadLine());
}
int N = GetInput("Введите число N: ");
int i = 0;
ShowResponse(N, i);
