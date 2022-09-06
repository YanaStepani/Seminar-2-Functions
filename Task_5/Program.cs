// Напишите программу, которая принмиает на вход два числа и проверяет,
// является ли одно число квадратом другого. 5,25 -> да, -4,16 -> да, 25, 5 -> да, 8,9 -> нет.

// задание функиции
void SquereRootOf2Numbers()
{
    // получение данных от пользователя:
    System.Console.WriteLine("Введите число 1: ");
    int number_1 = Convert.ToInt32(Console.ReadLine());

    System.Console.WriteLine("Введите число 2: ");
    int number_2 = Convert.ToInt32(Console.ReadLine());

    // проверка условия
    if (number_1 == number_2 * number_2)
    {
        System.Console.WriteLine($"{number_1} является квадратом {number_2}.");
    }
    else if(number_2 == number_1 * number_1)
    {
         System.Console.WriteLine($"{number_2} является квадратом {number_1}.");
    }
    else
    {
        System.Console.WriteLine($"{number_1} и {number_2} не являются квадратами одного из двух.");
    }
}

// вызов функции
SquereRootOf2Numbers();
