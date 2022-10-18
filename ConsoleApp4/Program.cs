using System.Globalization;

double[] array = new double[5];
for (int i = 0; i < 5; i++)
{
    array[i] = random();
}

double temp;
for (int i = 0; i < array.Length - 1; i++)
{
    for (int j = i + 1; j < array.Length; j++)
    {
        if (array[i] > array[j])
        {
            temp = array[i];
            array[i] = array[j];
            array[j] = temp;
        }
    }
}

Console.WriteLine("Минимальное число: ");
Console.WriteLine(Convert.ToString(array[0]));
Console.WriteLine("Максимальное число: ");
Console.WriteLine(Convert.ToString(array[array.Length - 1]));


static double random()
{
    Random rnd = new Random();
    double value = rnd.Next(-10000, 10000);
    return value / 100;
}