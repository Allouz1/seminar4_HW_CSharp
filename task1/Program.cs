int number = ReadInt("Введите число: ");
int degree = ReadInt("Введите степень: ");
int result = 1;

for(int i = 0; i < degree; i++)
{
    result = result * number;
}
Console.WriteLine(result);



int ReadInt(string message)
{
    Console.WriteLine(message);
    return Convert.ToInt32(Console.ReadLine());
}
