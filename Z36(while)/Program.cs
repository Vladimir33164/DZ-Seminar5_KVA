//Задача 36: Задайте одномерный массив, заполненный 
//случайными числами. Найдите сумму элементов, стоящих 
//на нечётных позициях.

//[3, 7, 23, 12] -> 19
//[-4, -6, 89, 6] -> 0

int[] array = new int[5]; // создаем  массив из n элементов
Console.WriteLine("Randomly filled array:");
int i = 0; // начало цикла
int resultSum = 0; // сумма чисел на нечетных позициях
while (i < array.Length) // условие цикла
{               // случайно заполняем массив
    array[i] = new Random().Next(-100, 101); // в диапазоне от -100 до 100
    if (i % 2 != 0) // проверяем что индекс нечетный
        resultSum += array[i]; // увеличиваем сумму
        i++; // конец цикла (i = i + 1) 
}
Console.WriteLine($"Specified array: [{String.Join(", ", array)}]");
Console.WriteLine("Sum of elements in odd positions = " + resultSum); // вывод результата
