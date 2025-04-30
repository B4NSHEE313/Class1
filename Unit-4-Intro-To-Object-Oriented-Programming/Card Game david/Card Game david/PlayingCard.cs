namespace Card_Game_david;

public class PlayingCard
{
    // Data for the class - Instance Data
    
    
    //Instance data means every object of the class has its own copy of the data

    private string suit;
    private string color;
    //                  Ace                         Jack, Queen, King
    private int value; // 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13
    
    // Constructor for a PlayingCard - get all the values from the user
    public PlayingCard(string suitName, string theColor, int Thevalue)
    {
        suit = suit;
        color = color;
        value = value;
    }

    // ToString() so we can use a PlayingCard as string
        public override string ToString()
        
        {
            return $"{value} of {suit} ({color})";
        }
    }
