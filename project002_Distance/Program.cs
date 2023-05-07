//Программа, которая принимает на вход координаты двух точек и находит расстояние между ними в 2D пространстве.

Main();

void Main()
{
    bool isWorking = true;

    while(isWorking)
    {
        Console.Write("Input task: ");
        string task = Console.ReadLine();

        switch(task)
        {
            case "t1": Task1(); break;
            case "exit": isWorking = false; break;
            default:
            break;
        }
    }
}

void Task1()
{
    int x1 = ReadInt("x", "A");
    int y1 = ReadInt("y", "A");
    int x2 = ReadInt("x", "B");
    int y2 = ReadInt("y", "B");

    double result = Math.Sqrt(Math.Pow((x1 - x2), 2) + Math.Pow((y1 - y2), 2));

    Console.WriteLine(result);
}

int ReadInt(string axis, string point)
{
    Console.Write($"Input coordinate {axis} of point {point}: ");
    return Convert.ToInt16(Console.ReadLine());
}