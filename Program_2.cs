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
int[] numberArray = new int[length];
int sum = 0;

for (int i = 0; i < length; i++)
{
    numberArray[i] = rnd.Next(-100, 101);
    Console.Write(numberArray[i] + ", ");
    if ((i + 1) % 2 != 0)
    {
        sum = sum + numberArray[i];
    } 
}

Console.WriteLine();
Console.WriteLine("Сумма элементов нечётных поцизий равна: " + sum);