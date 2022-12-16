/* Задача 36: Задайте одномерный массив, заполненный случайными числами. 
Найдите сумму элементов, стоящих на нечётных позициях.

[3, 7, 23, 12] -> 19
[-4, -6, 89, 6] -> 0 */

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
        array[i] = rnd.Next(-1000, 1000);
    } 
    return array;
}

int GetUnevenPosSum (int[] array)
{
    int sum = 0;
    for (int i = 1; i < array.Length; i = i + 2)
    {
        sum = sum + array[i];
    }
    return sum;
}

int dimention = GetNumber("Enter the array size");
int[] array = InitArray(dimention);
Console.WriteLine(string.Join(" ", array));
Console.WriteLine($"The sum of elements with uneven indexes is {GetUnevenPosSum(array)}");