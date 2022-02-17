// Задача 20: Задать номер четверти, показать диапазоны для возможных координат

Console.WriteLine("Введите номер четверти: ");
int part = int.Parse(Console.ReadLine());

if (part == 1)
{
    Console.WriteLine("Диапазон возможных координат: x > 0, y > 0.");
}
else if (part == 2)
{
    Console.WriteLine("Диапазон возможных координат: x > 0, y < 0.");
}
else if (part == 3)
{
    Console.WriteLine("Диапазон возможных координат: x < 0, y < 0.");
}
else if (part == 4)
{
    Console.WriteLine("Диапазон возможных координат: x < 0, y > 0.");
}
