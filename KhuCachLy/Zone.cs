using System;
using System.Collections.Generic;
using System.Text;

namespace KhuCachLy
{
    public class Zone
    {
        string name;
        int numberOfRoom;
        List<Room> listRoom;

        public Zone()
        { }

        public Zone(string name,int n)
        {
            this.Name = name;
            this.NumberOfRoom = n;
            this.ListRoom = new List<Room>(n);
        }

        public int NumberOfRoom { get => numberOfRoom; set => numberOfRoom = value; }
        public List<Room> ListRoom { get => listRoom; set => listRoom = value; }
        public string Name { get => name; set => name = value; }
    }
}
