//Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
//[3.22, 4.2, 1.15, 77.15, 65.2] => 77.15 - 1.15 = 76

double [] ArrInput (int number)
{
    double [] arr = new double[number];
    Random rand = new Random();
    for (int i = 0; i < number; i++)
    {
        arr[i] = Math.Round(rand.NextDouble(), 2);
    }
    return arr;
}

double MaxNumber (double[] array)
{
double maxNumber = array[0];
for (int i = 1; i < array.Length; i++)
{
    if (array[i] > maxNumber) maxNumber = array[i];
}
return maxNumber;
}

double MinNumber (double[] array)
{
double minNumber = array[0];
for (int i = 1; i < array.Length; i++)
{
    if (array[i] < minNumber) minNumber = array[i];
}
return minNumber;
}

double[] arr = ArrInput(5);
double maxNumber = MaxNumber(arr);
double minNumber = MinNumber(arr);
double numberDifference = maxNumber - minNumber;

Console.WriteLine($"[{string.Join(", ", arr)}] = > {maxNumber} - {minNumber} = {Math.Round(numberDifference, 2)}");
