// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

Console.WriteLine("Введите число N");
int N = Convert.ToInt32(Console.ReadLine());
Console.Write($"{N} ->");
int i = 0;
while (i < N - 1) {
    i = i + 1;
    Console.Write($" {i * i * i},");
}
if (N >= 1) {
    Console.Write($" {(i + 1) * (i + 1) * (i + 1)}");
} else {
    Console.Write(" null");
}