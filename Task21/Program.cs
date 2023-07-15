// напишите программу которая принимает на вход
// координаты 3 точек и находит растояние между ними в 3D пространстве

int Inpute(string text)
{
    Console.WriteLine(text);
    return Convert.ToInt32(Console.ReadLine());
}

int x1 = Inpute("введите Х");
int y1 = Inpute("введите У");
int z1 = Inpute("введите z1");
int x2 = Inpute("введите x2");
int y2 = Inpute("введите У2");
int z2 = Inpute("введите z2");

 double result = Math.Sqrt(Math.Pow((x1 - x2), 2) + Math.Pow((y2 - y1), 2)+ Math.Pow((z2 - z1), 2));                  // (Math.Pow-сумма квадратов разностей "возведение в квадрат"(),2)
            result = Math.Round(result, 2); //Math.Round округление 1 -что округляем , 2 -с каой точностью // Math.Sqrt возведение в квадрат корень
            Console.WriteLine($"растояние между точками = {result}");

