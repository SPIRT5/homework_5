Console.Clear();

int GetNumber (string message)
{
    int result = 0;
    string errorMessage = "Вы ввели не число или число меньше 1, введите любое положительное число: ";

    while (true)
    {
        Console.Write(message);

        if (int.TryParse(Console.ReadLine(), out result))
        {
            if(result > 0)
            {
                break;
            }
            else
            {
                Console.Clear();
                Console.WriteLine(errorMessage);
            }
        }
        else
        {
            Console.Clear();
            Console.WriteLine(errorMessage);
        }
    }
    return result;
}

int length = GetNumber("Введите длинну массива: ");
Random rnd = new Random();
decimal[] numberArray = new decimal[length];
decimal result = 0;

for (int i = 0; i < length; i++)
{
    numberArray[i] = rnd.Next(-99, 100) * Convert.ToDecimal(Math.Round (rnd.NextDouble(), 5));
//  numberArray[i] = rnd.Next(-99, 100)         -- генерация целого числа от -99 до 99
//  number = Math.Round (rnd.NextDouble(), 5);  -- генерация случайного десятичного числа с округлением до 5 знаков
//  number = Convert.ToDecimal(number);         -- преобразование типа данных из double для объединения 2х чисел
//  numberArray[i] = numberArray[i] * number;   -- объединение двух чисел в одно
    Console.Write(numberArray[i] + ", ");
}

decimal max = numberArray[0];
decimal min = numberArray[0];

for (int i = 1; i < length; i++)
{
    if (min > numberArray[i])
    {
        min = numberArray[i];
    }
    else if (max < numberArray[i])
    {
        max = numberArray[i];
    }
}


Console.WriteLine();
Console.WriteLine("Минимальное число: " + min + " Максимальное число: " + max);

if (max == min)
{
    Console.WriteLine("Все числа равны");
}
else
{
    result = max - min;
    Console.WriteLine("Разница между макс и мин равна: " + result);
}