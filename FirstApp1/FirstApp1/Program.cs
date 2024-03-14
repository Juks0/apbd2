// See https://aka.ms/new-console-template for more information

int x=0;
Console.WriteLine("grrr pow");
Console.WriteLine(x);

static double GetAvrage(int[] numbers)
{
    double result2 = 0.0;
    for (int i = 0; i < numbers.Length; i++)
    {
        result2 += numbers[i];
    }

    return result2 / numbers.Length;
}

int [] numbers = {1,2,3,4};
double avrage = GetAvrage(numbers);
Console.WriteLine(avrage);
