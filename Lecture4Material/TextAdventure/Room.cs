namespace Lecture4Material.TextAdventure;

public class Room
{
    private string _roomName;
    public string roomDescription;
    public string explorationDescription;
    public Dictionary<string, Room> adjacentRooms = new Dictionary<string, Room>();
    // List of items within the room
    
    public Room(string roomName)
    {
        _roomName = roomName;
    }

    public override string ToString()
    {
        return $"Room Name: {_roomName} \n" +
               $"Room Description: {roomDescription} \n" +
               $"Room Exploration Description: {explorationDescription} ";
    }
}