using Count_LABAAAA;
using System;

public class Room : Rectangle
{
    private double height;
    public double Height { get { return height; } set { height = value; } }
    private Window window;
    private Door door;
    private Roll Roll { get; set; }

    public Door Door
    {
        get { return door; }
        set { door = value; }
    }
            
    public Window Window
    {
        get { return window; }
        set { window = value; }
    }


    public Room(double length, double width, double height)
    {
        Length = length;
        Width = width;
        Height = height;

    }

    public Room(double length, double width, double height, Window window)
    {
        Length = length;
        Width = width;
        Height = height;
        Window = window;

    }

    public Room(double length, double width, double height, Window window, Door door)
    {
        Length = length;
        Width = width;
        Height = height;
        Window = window;
        Door = door;

    }


    public double FullArea(Room room)
    {
        if (door != null && window != null)
        {
            return (2 * ((room.Width * room.Height) + (room.Length * room.Height))) - window.GetArea() - door.GetArea();
        }
        else if (window != null) 
        {
            return (2 * ((room.Width * room.Height) + (room.Length * room.Height))) - window.GetArea();
        }
        else
        {
            return (2 * ((room.Width * room.Height) + (room.Length * room.Height)));
        }
        
    }



    public int CountOfRolls(Roll roll, Room room)
    {
        int count = 1;
        bool isTrue = true;
        while (isTrue)
        {
            if (count*roll.GetArea() < FullArea(room))
            {
                count++;
            }
            else { isTrue = false; }
            
        }
        return count;

    }

    public double FullPrice(Roll roll, Room room)
    {
        return CountOfRolls(roll, room) * roll.PricePerRoll;
    }


}
