using System;

namespace SomerenModel
{
    public class Teacher
    {
        public int RoomID { get; set; }
        public string FirstName { get; set; }

        public string LastName { get; set; }
        public bool Supervisor { get; set; }
        public int Number { get; set; } // LecturerNumber, e.g. 47198

        public Teacher(int number , string firstName, string lastName, bool supervisor, int roomID)
        {
            Number = number;
            FirstName = firstName;
            LastName = lastName;
            Supervisor = supervisor;
            RoomID = roomID;
        }
    }
}
