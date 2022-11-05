int operand1 = 5, operand2 = 3;
Console.Write("Please enter sign -> ");
string sign = Console.ReadLine();

switch (sign)
{
    case "+":
        Console.WriteLine("operand1 + operand2 = " + (operand1+operand2));
        break;
    case "-":
        Console.WriteLine("operand1 - operand2 = " + (operand1 - operand2));
        break;
        case "*":
        Console.WriteLine("operand1 * operand2 = " + (operand1 * operand2));
        break;
        case "/":
        {
            if (operand2!=0)
                Console.WriteLine("operand1 + operand2 = " + (operand1 + operand2));
            else
                Console.WriteLine("Division on 0!");
            break;
        }
        case "%":
        {
            if (operand2 != 0)
                Console.WriteLine("operand1 + operand2 = " + (operand1 + operand2));
            else
                Console.WriteLine("Division on 0!");            
            break;
        }
    default:
        Console.WriteLine("Unknowm sign");
        break;
}