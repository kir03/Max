// See https://aka.ms/new-console-template for more information
int[] numbers = new int[10];
for (int i = 0; i < numbers.Length; i++)
{
    int.TryParse(Console.ReadLine(), out numbers[i]);
}
int max = numbers[0];
for (int i = 0; i < numbers.Length; i++)
{
    if (numbers[i] > max)
        max = numbers[i];
}
Console.WriteLine($"Наибольшее число {max}");