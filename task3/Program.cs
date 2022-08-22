int count = ReadInt("Введите количество элементов в массиве: ");

int[] randomArray = new int[count];
for (int i = 0; i < randomArray.Length; i++)
{
    randomArray[i] = new Random().Next(1,100);
    Console.Write(randomArray[i] + " ");
}

int ReadInt(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}


