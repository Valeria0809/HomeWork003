// Задача 21
// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53

int ReadInt(string text)
{
    System.Console.WriteLine(text);
    return Convert.ToInt32(Console.ReadLine());
}
int[] coardsA = new int [3];

coardsA[0] = ReadInt("Введите координату X точки A ");
coardsA[1] = ReadInt("Введите координату Y точки A ");
coardsA[2] = ReadInt("Введите координату Z точки A ");

int[] coardsB = new int [3];

coardsB[0] = ReadInt("Введите координату X точки B ");
coardsB[1] = ReadInt("Введите координату Y точки B ");
coardsA[2] = ReadInt("Введите координату Z точки B ");

double distance = Math.Sqrt(Math.Pow(coardsA[0] - coardsB[0], 2) + Math.Pow(coardsA[1] - coardsB[1], 2) + Math.Pow(coardsA[2] - coardsB[2], 2));
System.Console.WriteLine(Math.Round(distance, 2));