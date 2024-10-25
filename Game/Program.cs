namespace Game
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter the number bellow");
            Random random = new Random();
            int randomNumber = random.Next(1, 11);

            int firstObject = int.Parse(Console.ReadLine());
            if (firstObject == randomNumber)
                Console.WriteLine("You win");
             else Console.WriteLine("You lose");
            int secondObject = int.Parse(Console.ReadLine());
            if (secondObject == randomNumber)
                Console.WriteLine("You win");
            else Console.WriteLine("You lose");
            int thirdObject = int.Parse(Console.ReadLine());
            if (thirdObject == randomNumber)
                Console.WriteLine("You win");
            else Console.WriteLine("You lose");
        }
    }
}