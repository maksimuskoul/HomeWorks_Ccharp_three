// напишите программу которая , которая принимает на вход число (И) и выдает таблицу кубов чисел


int Inpute(string text)
{
    Console.Write(text);
    return Convert.ToInt32(Console.ReadLine());
}

int N = Inpute("число мне ! ");
int i = 1;

while (i <= N)
{
    Console.WriteLine($"хоба ! {i * i * i}");
    i++;
}