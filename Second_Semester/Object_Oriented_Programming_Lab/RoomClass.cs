using System;
public class Room
{
    public int Number { get; set; }
    public string Type { get; set; }
    public string OccupancyStatus { get; set; }
    public Room(int number)
    {
        Number = number;
    }
    public Room(int number, string type)
    {
        Number = number;
        Type = type;
    }
    public Room(int number, string type, string occupancyStatus)
    {
        Number = number;
        Type = type;
        OccupancyStatus = occupancyStatus;
    }
}