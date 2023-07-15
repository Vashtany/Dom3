int Input(string text)
{
    Console.Write(text);
    return Convert.ToInt32(Console.ReadLine());
}


void Task19()
{
    //...,которая принимает на вход число и проверяет 
    //является ли она палиндромом.

    int number = Input("Введите пятизначное число: ");

    if(number/10000 == number%10 
            && number/1000%10 == number/10%10)
    {
        Console.WriteLine($"Число {number} палиндром ");
    }
    else
    {
        Console.WriteLine($"Число {number}  НЕ палиндром ");
    }
    if (number > 100000 || number < 10000)
    {
        Console.WriteLine("Ввидите другое число - это не пятизначное ");
    }
}

void Task21()
{
    int x1 = Input("Введите первую координату x : ");
    int y1 = Input("Введите первую координату y : ");
    int z1 = Input("Введите первую координату z : ");
    int x2 = Input("Введите вторую координату x : ");
    int y2 = Input("Введите вторую координату y : ");
    int z2 = Input("Введите вторую координату z : ");

    double result = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(x2 - x1, 2) + 
                         Math.Pow(x2 - x1, 2));
    result = Math.Round(result, 3);
    Console.WriteLine(result);
}

void Task23()
{
    //..,котора принимает на вход число и 
    // выдает таблицу кубов чисел от 1 до N

    int number = Input("Введите число: ");

    int counter = 1;

    while (counter <= number)
    {
       counter++;
    }

    for (counter = 1; counter <= number; counter++)
    {
        Console.WriteLine($"{counter}^3 ={Math.Pow(counter, 3)}");
    }
}

Console.Clear();
Task21();