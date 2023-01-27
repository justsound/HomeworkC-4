int ReadInt(string message)
{
    Console.WriteLine(message);
    return int.Parse(Console.ReadLine()!);
}
int[] CreateArray(int size, int leftside, int rightside)
{
    int[] array = new int[size];
    for (int i = 0; i < array.Length; i ++)
        array[i] = new Random().Next(leftside, rightside);
    return array;
}
void PrintArray(int[] array)
{
    Console.WriteLine(string.Join(" ", array));
    Console.WriteLine();
}

// task1. Задать массив из 8 элементов, заполненных нулями и единицами вывести их на экран

/* int[] array = CreateArray(8, 0, 2);
PrintArray(array); */

// task2. Определить, присутствует ли в заданном массиве, некоторое число

/* int number = ReadInt("Введите искомое число");
int size = ReadInt("Введите размер массива");
int leftside = ReadInt("Введите начальную границу диапазона массива");
int rightside = ReadInt("Введите конечную границу диапазона массива");
int[] arr = CreateArray(size, leftside,rightside);
PrintArray(arr);
int count = 0;
for (int i = 0; i < arr.Length; i ++) 
{
    if (arr[i] == number) count ++;
}
if (count != 0) Console.WriteLine($"Искомое число встречается в массиве {count} раз(а).");
else Console.WriteLine("В массиве нет искомого числа");
Console.WriteLine(); */

//task3. Задать массив, заполнить случайными положительными трёхзначными числами. Показать количество нечетных\четных чисел

/* int size = ReadInt("Введите размер массива");
int[] arr = CreateArray(size, 100, 1000);
PrintArray(arr);
int even = 0;
int uneven = 0;
for (int i = 0; i < arr.Length; i ++) 
{
    if (arr[i] % 2 == 0) even ++;
    else uneven ++;
}
Console.WriteLine($"В заданном массиве {even} четных чисел и {uneven} нечетных чисел");
Console.WriteLine(); */

// task4. В одномерном массиве из 123 чисел найти количество элементов из отрезка [10,99]

/* int leftside = ReadInt("Введите начальную границу диапазона массива");
int rightside = ReadInt("Введите конечную границу диапазона массива");
int[] arr = CreateArray(123, leftside,rightside);
PrintArray(arr);
int count = 0;
for (int i = 0; i < arr.Length; i ++) 
{
    if ((arr[i] <= 99)&&(arr[i] >= 10)) count ++;
}
Console.WriteLine($"В заданном массиве {count} чисел из отрезка от 10 до 99 включительно");
Console.WriteLine(); */

// task5. Найти сумму чисел одномерного массива стоящих на нечетной позиции

/* int size = ReadInt("Введите размер массива");
int leftside = ReadInt("Введите начальную границу диапазона массива");
int rightside = ReadInt("Введите конечную границу диапазона массива");
int[] arr = CreateArray(size, leftside,rightside);
PrintArray(arr);
int sum = 0;
for (int i = 0; i < arr.Length; i +=2) sum += arr[i];
Console.WriteLine(sum);
Console.WriteLine(); */

// task6. Найти произведение пар чисел в одномерном массиве. Парой считаем первый и последний элемент, второй и предпоследний и т.д.

/* int size = ReadInt("Введите размер массива");
int leftside = ReadInt("Введите начальную границу диапазона массива");
int rightside = ReadInt("Введите конечную границу диапазона массива");
int[] arr = CreateArray(size, leftside,rightside);
PrintArray(arr);
for (int i = 0; i < (arr.Length+1)/2; i ++) Console.WriteLine(arr[i] * arr[arr.Length - 1 - i]);
Console.WriteLine(); */

// task7. В Указанном массиве вещественных чисел найдите разницу между максимальным и минимальным элементом

double[] CreatedoubleArray(int size, double leftside, double rightside)
{
    double[] array = new double[size];
    Random random = new Random();
    for (int i = 0; i < array.Length; i ++)
        array[i] =  random.NextDouble() * (rightside - leftside) + leftside;
    return array;
}
void PrintdoubleArray(double[] array)
{
    Console.WriteLine(string.Join(" ", array));
    Console.WriteLine();
}
double ReadDouble(string message)
{
    Console.WriteLine(message);
    return Convert.ToDouble(Console.ReadLine()!);
}
int size = ReadInt("Введите размер массива");
double leftside = ReadDouble("Введите начальную границу диапазона массива");
double rightside = ReadDouble("Введите конечную границу диапазона массива");
double[] arr = CreatedoubleArray(size, leftside, rightside);
PrintdoubleArray(arr);
double max = arr[0];
double min = arr[0];
for (int i = 1; i < arr.Length; i ++)
{
    if (arr[i] > max) max = arr[i];
    if (arr[i] < min) min = arr[i];
} 
Console.WriteLine(max - min);
Console.WriteLine(); 
