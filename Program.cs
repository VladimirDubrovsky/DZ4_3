// Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.

// Console.WriteLine("Введи 8 чисел");
Console.Write("Введи количество эл-ов в массиве: ");
int count = Convert.ToInt32(Console.ReadLine());

int[] array = new int[count];

for (int i = 0; i < array.Length ; i++)
{
    Console.WriteLine($"Введи элемент массива под индексом {i}: ");
    array[i] = Convert.ToInt32(Console.ReadLine());
}


Console.WriteLine("Вывод массива: ");
for (int i = 0; i < array.Length; i++)
{
    Console.WriteLine(array[i]);
}

