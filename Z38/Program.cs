//Задача 38: Задайте массив вещественных чисел. Найдите 
//разницу между максимальным и минимальным 
//элементов массива.

//[3 7 22 2 78] -> 76

//Числа с плавающей точкой (или действительные числа) представлены типами float и double.
//Используются для хранения значений с точностью до определенного знака после десятичной точки.
//double — это числа с двойной точностью, максимально приближённые к заданным или полученным
//в результате вычислений значениям. Используется в Java для любых математических вычислений
//(квадратный корень, синус, косинус.). float — менее точный тип с плавающей точкой.
// различия в объёме памяти float (32 бита), double (64 бита).

            // объявляем переменные и вводим данные
/*
double[] arrayay = new double[5]; // количество чисел в массиве
Console.WriteLine("Enter the arrayay elements:"); // заполняем массив с клавиатуры
for (int i = 0; i < arrayay.Length; i++)
{
    arrayay[i] = double.Parse(Console.ReadLine());
}
double max = arrayay[0];// переменная макс
double min = arrayay[0];// переменная минимум
for (int i = 1; i < arrayay.Length; i++) // проходимся в цикле по массиву
    { 
    if (arrayay[i] < min) // если нашли меньше элемент чем был, то запоминаем его
       min = arrayay[i];
    if (arrayay[i] > max) // если нашли больше элемент чем был, то запоминаем его
       max = arrayay[i];
    }
Console.WriteLine();
Console.WriteLine("Difference between max and min elements = " + (max - min)); // вывод результата
*/
//Привет Миша! Проблемы с решением этой задачи:
//1) Если здесь решение в цикле while? У меня есть сомнения, т.к. i = 0 и i = 1.
//Можно ли выйти из этого положения?

double[] array;
double max, min;
int N;
Random r = new Random();
Console.WriteLine("Enter the dimension of the array:");
N = int.Parse(Console.ReadLine().ToString());
array = new double[N];
for (int i = 0; i < array.Length; i++)
{
    array[i] = r.Next(0, 50);
    Console.Write(array[i] + " ");
}
            
    max = array[0];
    min = array[0];
            
for (int i = 1; i < array.Length; i++)
    {
    if (array[i] > max)
        max = array[i];
    if (array[i] < min)
        min = array[i];
    }
Console.WriteLine($"\nMax = {max}\nMin = {min}\nDifference = {max - min}");
