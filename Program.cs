// Task
//Написать программу-калькулятор, вычисляющую выражения вида a + b, a - b, a / b, a * b, введенные из командной строки, и выводящую результат выполнения на экран.
if (args.Length == 3)
{
    double result;
    if (double.TryParse(args[0], out double valueOne) && (double.TryParse(args[2], out double valueTwo)))
    {
        if (args[1] == "+" || args[1] == "-" || args[1] == "/" || args[1] == "*")
        {
            if (args[1] == "+")
            {
                Console.WriteLine($"{valueOne} + {valueTwo} = {valueOne + valueTwo}");
            }
            if (args[1] == "-")
            {
                Console.WriteLine($"{valueOne} - {valueTwo} = {valueOne - valueTwo}");
            }
            if (args[1] == "/")
            {
                Console.WriteLine($"{valueOne} / {valueTwo} = {valueOne / valueTwo}");
            }
            if (args[1] == "*")
            {
                Console.WriteLine($"{valueOne} * {valueTwo} = {valueOne * valueTwo}");
            }
        }
        else
        {
            Console.WriteLine("Вы ввели неправильный оператор (+,-,/,*) или порядок аргументов (число_1 оператор число_2)");
        }
    }
    else
    {
        Console.WriteLine("Вы ввели неправильный оператор (+,-,/,*) или порядок аргументов (число_1 оператор число_2)");
    }
}
else
{
    Console.WriteLine("Вы ввели неправильный оператор (+,-,/,*) или порядок аргументов (число_1 оператор число_2)");
}

