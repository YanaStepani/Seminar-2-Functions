/*напишиите программу, которая будет принимать на вход два числа и 
* выводить, является ли второе исло кратным первому. Если число 2 
* не кратно числу 1, то программа выводит остаток от деления:
*35,5 -> не кратно, остаток 4; 16,4 -> кратно.
*/

void CompareNumbersByMultiplicity ()
{
    // получение данных от пользователя:
    System.Console.WriteLine("Введите число 1: ");
    int number_1 = Convert.ToInt32(Console.ReadLine());

    System.Console.WriteLine("Введите число 2: ");
    int number_2 = Convert.ToInt32(Console.ReadLine());

    // проверка условия:
    if (number_1 % number_2 == 0)
    {
        System.Console.WriteLine($"Число {number_1} кратно числу {number_2}.");
    }
    else 
    {
        System.Console.WriteLine($"Числа {number_1} и {number_2} не кратные. Остаток = " + (number_1 % number_2));
    }
}
CompareNumbersByMultiplicity();
CompareNumbersByMultiplicity();
