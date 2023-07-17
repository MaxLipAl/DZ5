//Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество 
//чётных чисел в массиве.
//[345, 897, 568, 234] -> 2

int [] ArrInput (int number)
{
    int [] arr = new int[number];
    for (int i = 0; i < number; i++)
    {
        int numberArr = new Random().Next(100, 1000);
        arr[i] = numberArr;
    }
    return arr;
}
int Even (int [] arr)
{
    int quantity = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] % 2 == 0) quantity += 1;
    }
    return quantity;
}

int[] arr = ArrInput(4);
int quantity = Even(arr);
Console.WriteLine($"[{string.Join(", ", arr)}] - > {quantity}");