
int Input(string text)
{
    Console.Write(text);
    return Convert.ToInt32(Console.ReadLine());
}

void Task10()
{
    // 10. ..., которая принимает на вход трёхзначное число и 
    // на выходе показывае вторую цифру этого числа.

    int number = Input("Введите трёхзначное число: ");

    int number_s = number / 10 % 10;

    Console.Write($"Вторая цифра этого числа: {number_s}");

}

void Task13()
{
    //13..., которая с помощью денения выводит третью цифру заданного
    //числа или сообщает что его нет

    int number = Input("Введите число: ");

    int number_s = 0;

    if ( number / 100 == 0 )
    {
         Console.Write($"Третeй цифры этого числа нет");
    }
    else (number % 1000 == number_s)
    {
        Console.Write($"Третья цифра этого числа: {number_s}");
    }


}


void Task15()
{
    //15..., которая принимает на вход цифру, обозначающую день недели,
    // и проверяет, является ли этот день выходным.

    int number = Input("Введите число дня недели: ");

    if (number == 6 || number == 7)
    {
         Console.Write($"Данный день недели выходной");
    }
    else
    {
         Console.Write($"Данный день недели НЕвыходной");
    }

    
}

Console.Clear();
Task15();