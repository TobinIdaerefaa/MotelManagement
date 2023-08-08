using System;
using System.Collections.Generic;
using System.Linq;

namespace MotelManagement.Models
{
    public class Room : BaseEntity
    {
        public int Type { get; set; }
        public int BedCount { get; set; }
        public RoomSize Size { get; set; }
        public double Amount { get; set; }

        public class RoomSize
        {
            public int Width { get; set; }
            public int Lenght { get; set; }
            public int Height { get; set; }
        }
        public static List<Room> rooms = new List<Room>();
        public List<MotelManagement.Models.Room> GetAllRooms()
        {
            rooms.Clear();
            Room room1 = new Room
            {
                Id = 1,
                Type = 1,
                Amount = 10000,
                BedCount = 2,
                Size = new RoomSize
                {
                    Width = 12,
                    Height = 10,
                    Lenght = 12,
                }
            };

            Room room2 = new Room
            {
                Id = 2,
                Type = 2,
                Amount = 16000,
                BedCount = 3,
                Size = new RoomSize
                {
                    Width = 14,
                    Height = 12,
                    Lenght = 14,
                }
            };

            rooms.Add(room1);
            rooms.Add(room2);

            return rooms;
        }

        public Room Details(int id)
        {
            return rooms.Where(x => x.Id == id).FirstOrDefault();
        }

        public Room Update(Room room)
        {
            return null;
        }
        public Room UpdateStatus(int status)
        {
            return null;
        }

        public Room Ac(int status)
        {
            return null;
        }
    }
}
