//Задача 38: Задайте массив вещественных чисел. Найдите 
//разницу между максимальным и минимальным 
//элементов массива.

//[3 7 22 2 78] -> 76

            // объявляем переменные и вводим данные

double[] array = new double[5]; // количество чисел в массиве
Console.WriteLine("Enter the array elements:"); // заполняем массив с клавиатуры
for (int i = 0; i < array.Length; i++)
    array[i] = double.Parse(Console.ReadLine());
double max = array[0];// переменная макс
double min = array[0];// переменная минимум
for (int i = 1; i < array.Length; i++) // проходимся в цикле по массиву
    { 
    if (array[i] < min) // если нашли меньше элемент чем был, то запоминаем его
       min = array[i];
    if (array[i] > max) // если нашли больше элемент чем был, то запоминаем его
       max = array[i];
    }
Console.WriteLine();
Console.WriteLine("Difference between max and min elements = " + (max - min)); // вывод результата


