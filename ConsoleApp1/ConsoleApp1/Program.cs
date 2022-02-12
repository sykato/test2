class programm
{
    static void Main()
    {
        int year;
        Console.Write("Введите год: ");
        year = Convert.ToInt32(Console.ReadLine());
        if (year % 400 == 0 || (year % 4 == 0 && year % 100 != 0))
            Console.WriteLine("год является високосным");
        else
            Console.WriteLine("год неявляется високосным");
    }
}