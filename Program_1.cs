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
int count = 0;

for (int i = 0; i < length; i++)
{
    numberArray[i] = rnd.Next(100, 1000);
    Console.Write(numberArray[i] + ", ");
    if (numberArray[i] % 2 == 0)
    {
        count++;
    } 
}

Console.WriteLine();
Console.WriteLine("Кол-во четных чисел в массиве: " + count);




