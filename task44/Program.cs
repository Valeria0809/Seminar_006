//Задача 44. Не используя рекурсию, выведите первые N чисел Фибоначчи
//Первые числа Фибоначчи: 0 и 1
//Если N 5 -> 0 1 1 2 3 
//Если N 3 -> 0 1 1 
//Если N 7 -> 0 1 1 2 3 5 8

int ReadInt(string text)
{
    System.Console.Write(text);
    return Convert.ToInt32(Console.ReadLine());

}

void PrintFibon(int amount)
{
    System.Console.Write("0 1 ");
    int bufer = 0;
    int bufer2 = 1;

    for(int i = 0; i < amount - 2; i ++)
    {
        int res = bufer + bufer2;
        System.Console.Write(res + " ");
        bufer = bufer2;
        bufer2 = res;
    }
}

int N = ReadInt("Введите елемент числа Фибоначчи: ");
PrintFibon(N);