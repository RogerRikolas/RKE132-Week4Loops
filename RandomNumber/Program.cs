Random rnd = new Random();

int myRandomNum;
int randomSum = 0;
for(int i = 0; i < 10; i++)
{
     myRandomNum = rnd.Next(0, 11); // kui soovin 10ni siis panen kuni 11
    randomSum = randomSum + myRandomNum;
    Console.WriteLine($"My random number is {myRandomNum}");

}
Console.WriteLine($"random sum total {randomSum}"); 