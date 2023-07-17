//Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
//[3, 7, 23, 12] -> 19
//[-4, -6, 89, 6] -> 0

int [] ArrInput (int number)
{
    int [] arr = new int[number];
    for (int i = 0; i < number; i++)
    {
        int numberArr = new Random().Next(-100, 100);
        arr[i] = numberArr;
    }
    return arr;
}

int SumElement (int[] arr)
{
    int sum = 0;
    for (int i = 1; i < arr.Length; i = i + 2)
    {
        sum = sum + arr[i];
    }
    return sum;
}

int[] arr = ArrInput(8);
int number = SumElement(arr);
Console.WriteLine($"[{string.Join(", ", arr)}] -> {number}");
