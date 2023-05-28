//Задача 45. Напишите программу, которая будет создавать копию
//заданного массива с помощью поэлементного копирования

int ReadInt(string text)
{
    System.Console.Write(text);
    return Convert.ToInt32(Console.ReadLine());
}

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

int [] CopyArray (int[] arr)
{
    int [] copyarray = new int [arr.Length];

    for(int i = 0; i < arr.Length; i ++)
    {
        copyarray[i] = arr[i];
    }
    return copyarray;
} 

int [] array = GenerateArray(5, 0, 10);
PrintArray(array);

int [] copyArr = CopyArray(array);
PrintArray(copyArr);