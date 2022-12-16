/*Задача 38: Задайте массив вещественных чисел. 
Найдите разницу между максимальным и минимальным элементов массива.
[3 7 22 2 78] -> 76 */

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

double[] InitArray(int dimention)
{
    double[] array = new double[dimention];
    Random rnd = new Random();
    for (int i = 0; i < dimention; i++)
    {
        array[i] = rnd.Next(-10, 10);
    } 
    return array;
}

int dimention = GetNumber("Enter the array size");
double[] array = InitArray(dimention);
Console.WriteLine(string.Join(" ", array));

double max = array[0];
double min = array[0];
for (int i = 0; i < array.Length; i++)
{
    if(array[i] > max) max = array[i];
    if(array[i] < min) min = array[i];    
}
double diff = max - min;
Console.WriteLine($"The difference between the max and min elements of the array is {diff}");
    
