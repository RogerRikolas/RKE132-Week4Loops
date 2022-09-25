Random rnd = new Random();

int cpuRandom;

bool loopActive = true; //bool - true/false
while (loopActive)
{
    cpuRandom = rnd.Next(1, 4);
    Console.WriteLine($"cpu has generated {cpuRandom}");
    Console.WriteLine("Guess the number. Enter a number 1-3");
    int userNumber = Int32.Parse(Console.ReadLine());

    if(userNumber == cpuRandom)
    {
        Console.WriteLine("Congratiulations, you won");
        //loopActive = false;
        break;
    }
    else
    {
        Console.WriteLine("Try again!!");
    }
}
Console.WriteLine("Have a nice day!!!!!");