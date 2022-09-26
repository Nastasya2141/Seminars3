// Напишите программу, которая принимает на вход координаты двух точек 
//и находит расстояние между ними в 3D пространстве.
Console.WriteLine("Введите координаты точки А: ");
Console.WriteLine("Х: ");
int aX = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Y: ");
int aY = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Z: ");
int aZ = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите координаты точки B: ");
Console.WriteLine("Х: ");
int bX = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Y: ");
int bY = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Z: ");
int bZ = Convert.ToInt32(Console.ReadLine());

int k = aX-bX;
int t = aY-bY;
int m = aZ-bZ;

double lenght = Math.Sqrt( k*k + t*t + m*m );
Console.WriteLine (lenght);
lenght = Math.Round(lenght,2);
Console.WriteLine($"Расстояние :{lenght}");


