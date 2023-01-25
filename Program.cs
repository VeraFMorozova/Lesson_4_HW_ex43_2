// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, 
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.

// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

int getUserData(string message)
{
    Console.ForegroundColor = ConsoleColor.DarkCyan; 
    Console.WriteLine(message);
    Console.ResetColor();
    int UserData = int.Parse(Console.ReadLine()!);
    return UserData;
}
double getNumberX(double b1, double k1, double b2, double k2)
{
    double X = 0;
    X = (b2-b1)/(k1-k2);
    return X;
}
double getNumberY(double b1, double k1, double b2, double k2, double X)
{
    double Y = 0;
        Y = k1*X+b1;
    return Y;
}

int numberb1 = getUserData("Введите число b1");
int numberk1 = getUserData("Введите число k1");
int numberb2 = getUserData("Введите число b2");
int numberk2 = getUserData("Введите число k2");
double NumberX = getNumberX(numberb1, numberk1, numberb2, numberk2);
double NumberY = getNumberY(numberb1, numberk1, numberb2, numberk2, NumberX);
Console.Write($"Точка пересечения двух прямых ({NumberX};{NumberY})");