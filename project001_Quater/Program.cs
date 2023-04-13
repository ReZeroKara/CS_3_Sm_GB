//Программа, которая по задоному номеру четверти, показывает диапозон возможных координат точек (х, у) в этой четверти.

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
    int quaterNum = ReadInt();

    if (quaterNum == 1)
    {
        Console.WriteLine("x(0, +∞), x(0, +∞)");
    }
    else if(quaterNum == 2)
    {
        Console.WriteLine("x(0, +∞), x(0, -∞)");
    }
    else if(quaterNum == 3)
    {
        Console.WriteLine("x(0, -∞), x(0, -∞)");
    }
    else if(quaterNum == 4)
    {
        Console.WriteLine("x(0, -∞), x(0, +∞)");
    }
    else
    {
        Console.WriteLine("This quarter does not exist.");
    }
}

int ReadInt()
{
    Console.Write("Input number of quater: ");
    int quater;
    
    while (!int.TryParse(Console.ReadLine(), out quater))
    {
        Console.WriteLine("It's not a number!");
    }
    return quater;
}