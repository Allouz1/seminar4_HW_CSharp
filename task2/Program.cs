// не понял как делать
int number = ReadInt("Введите число: ");
int sum = 0;
int index = 0;

while(number > 0)
{
    number /=10;
    index++;
}

for (int i = 0; i < number; i++)
{
    sum += number % 10;
    number /= 10;
}
Console.WriteLine(sum);





int ReadInt(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}

