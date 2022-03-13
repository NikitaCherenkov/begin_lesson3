// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

Console.WriteLine("Введите число");
String symb = Convert.ToString(Console.ReadLine());
int i = 0;
Boolean stop = false;
while (i < symb.Length / 2 & !stop) {
    if (symb[i] != symb[symb.Length - i - 1]) {
        stop = true;
    }
    i++;
}
if (symb.Length != 5) {
    Console.WriteLine("Введено не пятизначное число");
}
if (stop) {
    Console.WriteLine("Число не является палиндромом");
} else {
    Console.WriteLine("Введён палиндром");
}