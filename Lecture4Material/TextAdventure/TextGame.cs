namespace Lecture4Material.TextAdventure;

public class TextGame
{
    private Room currentRoom;
    
    public void PlayGame()
    {
        currentRoom = new Room("Kitchen");
        currentRoom.roomDescription = "A room for cooking food";
        currentRoom.explorationDescription = "You find some moldy cheese";
        Console.WriteLine(currentRoom.ToString());
        
        Room bedRoom = new Room("Bedroom");
        bedRoom.roomDescription = "A room for sleeping";
        bedRoom.explorationDescription = "You find some moldy cheese";
    }
}