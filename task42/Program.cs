//Задача 42. Напишите программу, которая будет преобразовывать 
//десятичное число в двоичное 
//44 -> 101100
//3 -> 11
//2 -> 10

int ReadInt(string text)
{
    System.Console.Write(text);
    return Convert.ToInt32(Console.ReadLine());

}

void ConvertToBinary(int number)
{
if(number <= 0)
{
    return;
}
    ConvertToBinary(number/2);
    System.Console.Write(number % 2);
}


int number = ReadInt("Введите число: ");
ConvertToBinary(number);