namespace Dice_Simulator
{
    class Program
    {
        static void Main(string[] args)
        {
            Random randomNumberGenerator;
            int randomNumber;
            randomNumberGenerator = new Random(500);

                string userInput;
                Console.WriteLine("Hello, you have 5 dice to choose from: D6, 2D6, 3D6, 4D6 and 5D6");
                userInput = Console.ReadLine();

            if (userInput == "D6")
            {
                randomNumber = randomNumberGenerator.Next(1, 7);
                Console.WriteLine("D6:" + randomNumber);
            }

            if (userInput == "2D6")
            {
                randomNumber = randomNumberGenerator.Next(1, 7) + randomNumberGenerator.Next(1, 7);
                Console.WriteLine("2D6: " + randomNumber);
            }

            if (userInput == "3D6")
            {
                randomNumber = randomNumberGenerator.Next(1, 10);
                Console.WriteLine("3D6: " + randomNumber);
            }

            if (userInput == "4D6")
            {
                randomNumber = randomNumberGenerator.Next(1, 5) + randomNumberGenerator.Next(1, 5);
                Console.WriteLine("4D6: " + randomNumber);
            }

            if (userInput == "5D6")
            {
                randomNumber = randomNumberGenerator.Next(1, 100);
                Console.WriteLine("5D6: " + randomNumber);
            }

            else
            {
                Console.WriteLine("You have entered an incorrect dice name. Please try again");
            }
            Console.ReadLine();
        }
    }
}