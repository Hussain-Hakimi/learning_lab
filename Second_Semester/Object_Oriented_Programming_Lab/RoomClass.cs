using System;

public class Room
{
    // Properties
    public int RoomNumber { get; private set; }
    public string Type { get; private set; }        // e.g., "Single", "Double", "Suite"
    public bool IsOccupied { get; private set; }

    // 1) Constructor: Room number only
    public Room(int roomNumber)
        : this(roomNumber, "Standard", false) // default type and occupancy
    {
    }

    // 2) Constructor: Room number + type
    public Room(int roomNumber, string type)
        : this(roomNumber, type, false) // default occupancy false
    {
    }

    // 3) Constructor: Room number + type + occupancy
    public Room(int roomNumber, string type, bool isOccupied)
    {
        RoomNumber = roomNumber;
        Type = string.IsNullOrWhiteSpace(type) ? "Standard" : type;
        IsOccupied = isOccupied;
    }

    // Optional: a method to display room info
    public override string ToString()
    {
        return $"Room {RoomNumber}: {Type} - {(IsOccupied ? "Occupied" : "Available")}";
    }
}

// Example usage
class Program
{
    static void Main()
    {
        var r1 = new Room(101);
        var r2 = new Room(102, "Double");
        var r3 = new Room(201, "Suite", true);

        Console.WriteLine(r1);
        Console.WriteLine(r2);
        Console.WriteLine(r3);
    }
}
