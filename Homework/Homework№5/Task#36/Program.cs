// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях(по индексу считаем).
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0
Console.Clear();
Console.WriteLine("Задача 36: \nЗадайте одномерный массив, заполненный случайными числами. \nНайдите сумму элементов, стоящих на нечётных позициях(по индексу считаем).");
int[] arr = new int[8]; // создали массив из восьми элементов

void Random(int[] array) //метод рандома
{
    for (int i = 0; i < arr.Length; i++) //цикл прохода по элементам массива 
    {
        Random rnd = new Random(); //Создание объекта для генерации чисел
        int value = rnd.Next(-100, 100);//Получить случайное число 
        arr[i] = value;
        Console.Write($"{arr[i]} ");
    }
}
Random(arr);

void Sum(int[] array) //метод Sum 
{
    int sum1 = 0; //счетчик 
    for (int i = 1; i < arr.Length; i = i + 2) //цикл прохода по элементам массива(но в конце +2) 
    {
        sum1 = sum1 + arr[i];
    }
    Console.WriteLine($"Сумма элементов с нечетным индексом равна: {sum1}");
}

Sum(arr);