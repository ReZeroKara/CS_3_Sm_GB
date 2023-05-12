//Программа, которая принимает на вход число N и выдаёт таблицу квадратов чисел от 1 до N.

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
    int number = ReadInt();
    int nul = 1;

    Console.Write("[");

    while (nul <= number)
    {
        double result = Math.Pow((nul), 2);
        Console.Write(result + ", ");
        nul++;
    }

    Console.Write("]");
    Console.WriteLine();
}

int ReadInt()
{
    Console.Write("Input positive number: ");
    int N;
    
    while (!int.TryParse(Console.ReadLine(), out N))
    {
        Console.WriteLine("It's not a number!");
    }
    return N;
}