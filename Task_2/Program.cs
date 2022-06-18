// Программа которая принимает на вход координаты двух точек и находит расстояние между ними 
// в 3D пространтстве.

void Distance (int x, int y, int z, int x1, int y1, int z1)
{
    int NamberD = ((x1 - x) * (x1 - x) + (y1 - y) * (y1 - y) + (z1 -z) * (z1 - z));
    double Dist = Math.Sqrt(NamberD);
    double Dist1 = Math.Round(Dist, 2);
    Console.WriteLine(Dist1);
}

Distance(3,6,8,2,1,-7);

Distance(4,5,2,4,6,1);