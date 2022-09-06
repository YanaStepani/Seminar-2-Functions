/* напишите программу, которая выводит случайное трехзначное число 
и удаляет вторую цифру этого числа, например 782 -> 72, 918 -> 98. 
*/

void FirstAndThirdDigits()
{
    // вводим переменные:
    int num = new Random().Next(100,1000);
    int num_1 = num / 100;
    int num_2 = (num - num_1*100) / 10;
    int num_3 = (num - (num_1 * 100 + num_2 * 10));

    System.Console.WriteLine($"Сгенерировано случайное число {num}");

    // вывод ответа  пользователю:
    System.Console.WriteLine($"{num_1}{num_3}");
}

FirstAndThirdDigits();
FirstAndThirdDigits();
FirstAndThirdDigits();
