using System.Diagnostics;
using System.Reflection;

// 01234567
// XX00 XXX

// Topic 2 CLI & topic 3
Console.WriteLine("X = Letter | 0 = Number");

Console.WriteLine("Enter You Car Regitration Number:XX00 XXX");

string car_reg = Console.ReadLine();

if (args.Contains("-h"))
{
    Console.WriteLine("You will just need to input your car reg, X = Letter | 0 = Number");
}
else 
{
    Console.WriteLine("Processing...");
}

//had some help. Used stack overflow.
if (args.Contains("-v"))
{
    System.Reflection.Assembly executingAssembly = System.Reflection.Assembly.GetExecutingAssembly();
    var fieVersionInfo = FileVersionInfo.GetVersionInfo(executingAssembly.Location);
    var version = fieVersionInfo.FileVersion; 
}

//if the user types in x as a number 0r 0 as a letter the program warns and tells the user to retype the code. 
while (true)
{
    try
    {
        if (args = first_digit >= "a" && first_digit <= "z" || first_digit >= "A" && first_digit <= "Z")
        {
            Console.WriteLine("Incorrect format, try again");
        }
        else if (args = second_digit >= "a" && second_digit <= "z" || second_digit >= "A" && second_digit <= "Z")
    }
    catch (FormatException)
    {
        Console.WriteLine("Incorrect format, try again");
    }

    catch (Exception e)
    {
        Console.WriteLine("There is an error");
    }

    else
    {
        break;
    }
}

CalculateYear(car_reg);

//outputs

int year = CalculateYear(car_reg);

int old_car = CalculateYear(car_reg);

int not_found_in_system = CalculateYear(car_reg);


// The registartion has no value yet. the value is put in the calculateyear()<--

int CalculateYear(string registration) 
{
    int first_digit = registration[2] - '0';
    int second_digit = registration[3] - '0';

    if (first_digit >= 5)
    {
        int num_1 = (first_digit - 5);
        int year = 2000 + num_1 * 10 + second_digit;
        return year;
    }
    else if (first_digit < 5)
    {
        int old = (first_digit);
        int old_car = 2000 + old * 10  + second_digit;
        return old_car;
        Console.WriteLine("Sorry your car is too old, to be on the road");
    }
    else
    {
        int not_found_in_system = Console.WriteLine("20" + first_digit + second_digit);
        return not_found_in_system;
        Console.WriteLine("This car is not in the system! Please try again.");
    }
}

















