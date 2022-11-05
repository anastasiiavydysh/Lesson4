Console.Write("Enter integer number -> ");
int number = Convert.ToInt32(Console.ReadLine());

if (number >= 0 && number < 15)
    Console.WriteLine("[0-14]");
else
    if (number >= 15 && number < 36)
        Console.WriteLine("[15-35]");
    else
        if (number >= 36 && number < 51)
            Console.WriteLine("[36-50]");
        else
            if (number >= 51 && number < 101)
                Console.WriteLine("[51-100]");
            else
                Console.WriteLine("This numder is not in the intervals.");