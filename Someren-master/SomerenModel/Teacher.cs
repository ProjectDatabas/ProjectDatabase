using System;

namespace SomerenModel
{
    public class Teacher
    {
        public int RoomID { get; set; }
        public string Name { get; set; }
        public bool Supervisor { get; set; }
        public int Number { get; set; } // LecturerNumber, e.g. 47198

        public Teacher(int number , string name, bool supervisor, int roomID)
        {
            Number = number;
            Name = name;
            Supervisor = supervisor;
            RoomID = roomID;
        }
    }
}
