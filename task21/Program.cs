// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

Console.WriteLine("Введите координаты первой точки через пробел (x y z)");
int[] coord1 = Console.ReadLine().Split().Select(int.Parse).ToArray();
Console.WriteLine("Введите координаты второй точки через пробел (x y z)");
int[] coord2 = Console.ReadLine().Split().Select(int.Parse).ToArray();
if (coord1.Length != 3 & coord2.Length != 3) {
    Console.WriteLine("Неверные данные");
} else {
    double x = Math.Max(coord1[0], coord2[0]) - Math.Min(coord1[0], coord2[0]);
    double y = Math.Max(coord1[1], coord2[1]) - Math.Min(coord1[1], coord2[1]);
    double z = Math.Max(coord1[2], coord2[2]) - Math.Min(coord1[2], coord2[2]);
    double xyz = Math.Sqrt((x * x + y * y) + z * z);
    Console.WriteLine($"Расстояние: {xyz}");
}