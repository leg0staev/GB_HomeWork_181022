Console.WriteLine("===========> Задача 41 <============ ");
/* Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте,
сколько чисел больше 0 ввёл пользователь.

0, 7, 8, -2, -2 -> 2
1, -7, 567, 89, 223-> 4 */

Console.WriteLine("Введите нелько чисел и я скажу Вам сколько из них было больше нуля.");
Console.WriteLine("Количество чисел для анализа: ");
int arraySize = Convert.ToInt32(Console.ReadLine()); // Количество чисел М
int[] userArray = GetUserArray(arraySize);
Console.WriteLine($"Ваш массив чисел: [{String.Join(", ", userArray)}]");
int positiveNumbers = GetPositiveNumbers(userArray);
Console.WriteLine($"Количество чисел больше чем нуль в вашем массиве чисел => {positiveNumbers}");

/*=========== МЕТОДЫ к задаче 41 ============ */

// формирую массив пользователя
int[] GetUserArray(int size)
{
    int[] array = new int[size];
    for (int m = 0; m < array.Length; m++)
    {
        Console.WriteLine($"введите {m + 1} число: ");
        array[m] = Convert.ToInt32(Console.ReadLine());
    }
    return array;
}

// считаю положительные числа вмассиве пользователя
int GetPositiveNumbers(int[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > 0) count++;
    }
    return count;
}


Console.WriteLine("===========> Задача 43 <============ ");
/* Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых,
заданных уравнениями y = k1 * x + b1, y = k2 * x + b2;
значения b1, k1, b2 и k2 задаются пользователем.

b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5) */

Console.WriteLine("Введите аргументов функции y = k1 * x + b1 и y = k2 * x + b2, и я найду координату точки их пересечения");
Console.WriteLine("введите k1: ");
double k1 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("введите b1: ");
double b1 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("введите k2: ");
double k2 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("введите b2: ");
double b2 = Convert.ToDouble(Console.ReadLine());

double coordinateX = GetX(k1, k2, b1, b2);
double coordinateY = GetY(coordinateX, k1, b1);
Console.WriteLine($"точка пересечения двух функций => ({coordinateX}; {coordinateY})");


/*=========== МЕТОДЫ к задаче 43 ============ */

//рассчет х
double GetX(double k1, double k2, double b1, double b2)
{
    double x = (b2 - b1) / (k1 - k2);
    return x;
}

//рассчет у
double GetY(double x, double k1, double b1)
{
    double y = k1 * x + b1;
    return y;
}
Console.WriteLine("===========> Доп.Задача <============ ");
/* Доп.Задача (Если вдруг не можете решить 43, либо хотите решить для интереса)

Найти произведение всех элементов массива целых чисел, меньших заданного числа.
Размерность массива – 10. Заполнение массива осуществить случайными числами от 50 до 100. */

int size = 10;
int minVolue = 50;
int maxVolue = 100;

int[] MultiplyArray = GetArray(size, minVolue, maxVolue);
Console.WriteLine($"Сгенерированный массив согласно условию => [{String.Join(",", MultiplyArray)}]");
Console.WriteLine("введите число, и я найду произведение всех чисел сгенерированного массива, которые меньше заданного: ");
int limitValue = Convert.ToInt32(Console.ReadLine());
int multiplyResult = GetMultiplyResult(MultiplyArray, limitValue);
Console.WriteLine($"Произведение всех чисел в массиве, которые меньше {limitValue} => {multiplyResult}");

/*=========== МЕТОДЫ к Доп.Задаче ============ */

int GetMultiplyResult(int[] array, int limit)
{
    int result = 1;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] < limit) result *= array[i];
    }
    return result;
}

int[] GetArray(int size, int minValue, int maxValue){
    int[] result = new int[size];
    for (int i = 0; i < size; i++)
    {
     result[i] = new Random().Next(minValue, maxValue + 1);   
    }
    return result;
}