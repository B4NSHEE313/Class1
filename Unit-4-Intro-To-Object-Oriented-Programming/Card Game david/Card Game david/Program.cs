namespace Card_Game_david;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");
        // Instantiate a PlayingCard object
        PlayingCard aCard = new PlayingCard("Spades", "Black", 1);
        
        
        Console.WriteLine(aCard);
    }
}