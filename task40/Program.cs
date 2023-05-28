//Задача 40. Напишите программу, которая принимает на вход три числа
//и проверяет, может ли существовать треугольник со сторонами такой длинны

//Теорема о неравенстве треугольника: каждая сторона треугольника
//меньше суммы двух других сторон

int ReadInt(string text)
{
    System.Console.Write(text);
    return Convert.ToInt32(Console.ReadLine());

}

bool Calculate(int num1, int num2, int num3)
{
    if(num1 < num2 + num3 && num2 < num1 + num3 && num3 < num1 + num2)
{
    return true;
}
else
{
    return false;
}
}

int num1 = ReadInt("Введите длину первой стороны: ");
int num2 = ReadInt("Введите длину второй стороны: ");
int num3 = ReadInt("Введите длину третьей стороны: ");

if (Calculate(num1, num2, num3))
{
    System.Console.WriteLine("Треугольник существует");
}
else
{
    System.Console.WriteLine("Тругольник не существует");
}