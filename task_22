//Задача 22: Найти расстояние между точками в пространстве 2D/3D
//AB = √(xb - xa)2 + (yb - ya)2
//AB = √(xb - xa)2 + (yb - ya)2 + (zb - za)2

Console.WriteLine("Если точки находятся в 2D пространстве, введите 2. Если в 3D - введите 3. ");
int dimension = int.Parse(Console.ReadLine());

if (dimension == 2)
{
    Console.WriteLine("Введите значение X для точки А: ");
    int xA = int.Parse(Console.ReadLine());
    Console.WriteLine("Введите значение Y для точки А: ");
    int yA = int.Parse(Console.ReadLine());
    Console.WriteLine("Введите значение X для точки B: ");
    int xB = int.Parse(Console.ReadLine());
    Console.WriteLine("Введите значение Y для точки B. ");
    int yB = int.Parse(Console.ReadLine());

    double result = Math.Sqrt(((xB - xA) * (xB - xA)) + ((yB - yA) * (yB - yA)));
    Console.WriteLine("Расстояние между точками A и B в 2D пространстве равно " + result + ".");
}
else if (dimension == 3)
{
    Console.WriteLine("Введите значение X для точки А: ");
    int xA = int.Parse(Console.ReadLine());
    Console.WriteLine("Введите значение Y для точки А: ");
    int yA = int.Parse(Console.ReadLine());
    Console.WriteLine("Введите значение Z для точки А: ");
    int zA = int.Parse(Console.ReadLine());
    Console.WriteLine("Введите значение X для точки B: ");
    int xB = int.Parse(Console.ReadLine());
    Console.WriteLine("Введите значение Y для точки B. ");
    int yB = int.Parse(Console.ReadLine());
    Console.WriteLine("Введите значение Z для точки B. ");
    int zB = int.Parse(Console.ReadLine());

    double result = Math.Sqrt(((xB - xA) * (xB - xA)) + ((yB - yA) * (yB - yA)) + ((zB - zA) * (zB - zA)));
    Console.WriteLine("Расстояние между точками A и B в 3D пространстве равно " + result + ".");
}
