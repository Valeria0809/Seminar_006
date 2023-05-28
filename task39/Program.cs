//Задача 39. Напишите программу, которая перевернет одномерный массив
//(последний элемент будет на первом месте, а первый на последнем и т.д.)
//[1 2 3 4 5] -> [5 4 3 2 1]
//[6 7 3 6] -> [6 3 7 6]

int[]GenerateArray(int size, int leftRange, int rightRange)
{
    int[] tempArray = new int[size];
    Random rand = new Random();

    for(int i = 0; i < size; i ++)
    {
        tempArray[i] = rand.Next(leftRange, rightRange + 1);
    }

    return tempArray;
}

void PrintArray(int[]arr)
{
    System.Console.WriteLine(string.Join(" ", arr));
}

void ReverseArray(int[] arr)
{
    int temp = 0;
    for(int i = 0; i < arr.Length/2; i ++)
    {
        temp = arr[i];
        arr[i] = arr[arr.Length - 1 - i];
        arr[arr.Length - 1 - i] = temp;
    }
}

int ReadInt(string text)
{
    System.Console.Write(text);
    return Convert.ToInt32(Console.ReadLine());
}

int [] array = GenerateArray(ReadInt("Введите размер массива: "), ReadInt("Введите левую границу генерации: "), ReadInt("Введите правую границу генерации: "));
PrintArray(array);
ReverseArray(array);
PrintArray(array);