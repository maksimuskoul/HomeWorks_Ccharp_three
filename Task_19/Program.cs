// Напишите программу, которая принимает на вход 
// пятизначное число и проверяет , я вляеться ли оно ПАЛИНДРОМОМ
// 14212 -> net
// 12821 -> da
// 23432 -> da





void Number1()
{
    
    Console.Write("Введите число: ");
    string number = Console.ReadLine();
    

    if (number[0] == number[4] || number[1] == number[3])
    {
        Console.WriteLine($"Ваше число: {number} - палиндром.");
    }
    else Console.WriteLine($"Ваше число: {number} - НЕ палиндром.");
}
Console.Clear();
Number1();


