// Напишите программу, которая принимает на вход 
// координаты двух точек и находит расстояние между 
// ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53

int x1 = Cord("x", "A");
int y1 = Cord("y", "A");
int z1 = Cord("z", "A");
int x2 = Cord("x", "B");
int y2 = Cord("y", "B");
int z2 = Cord("z", "B");

int Cord(string cordName, string pointName)
{
    Console.Write($"Введите координату {cordName} точки {pointName}: ");
    return Convert.ToInt16(Console.ReadLine());
}

double Decision(double x1, double x2, 
                double y1, double y2, 
                double z1, double z2)
{
    return Math.Sqrt(Math.Pow(x2 - x1, 2) + 
                     Math.Pow(y2 - y1, 2) + 
                     Math.Pow(z2 - z1, 2));
}

double segmentLength = Math.Round (Decision(x1, x2, y1, y2, z1, z1), 2);
Console.WriteLine($"Длина отрезка {segmentLength}");