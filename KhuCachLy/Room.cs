using System;
using System.Collections.Generic;
using System.Text;

namespace KhuCachLy
{
    public class Room
    {
        int numbered;
        int numberOfPerson;
        List<Person> listPerson;

        public Room()
        { }

        public Room(int numbered, int n)
        {
            this.Numbered = numbered;
            this.NumberOfPerson = n;
            this.ListPerson = new List<Person>(n);
        }

        public int NumberOfPerson { get => numberOfPerson; set => numberOfPerson = value; }
        public int Numbered { get => numbered; set => numbered = value; }
        public List<Person> ListPerson { get => listPerson; set => listPerson = value; }
    }
}
