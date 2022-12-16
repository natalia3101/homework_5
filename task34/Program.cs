/*
Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
Напишите программу, которая покажет количество чётных чисел в массиве.
[345, 897, 568, 234] -> 2 */

int GetNumber(string message)
{
    int result;
    while(true)
    {
        Console.WriteLine(message);

        if(int.TryParse(Console.ReadLine(), out result) && result > 0)
        {
            break;
        }
        else
        {
            Console.WriteLine("Incorrect input. Please enter another number.");
        }
    }
    return result;
}

int[] InitArray(int dimention)
{
    int[] array = new int[dimention];
    Random rnd = new Random();
    for (int i = 0; i < dimention; i++)
    {
        array[i] = rnd.Next(100, 1000);
    } 
    return array;
}

int EvenNumbers(int[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if(array[i] % 2 == 0)
        {
            count = count + 1;
        } 
    }
    return count;
}

int dimention = GetNumber("Enter the array size");
int[] array = InitArray(dimention);
Console.WriteLine(string.Join(" ", array));
Console.WriteLine($"There is/are {EvenNumbers(array)} even numbers in the array.");