using System;

namespace SomerenModel
{
    public class Teacher
    {
        public int RoomID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int ActivityID { get; }
        public bool IsSupervisor(int activityID) { return activityID == ActivityID; }
        public int Number { get; set; } // LecturerNumber, e.g. 47198
        public string FullName 
        {
            get
            {
                return $"{FirstName} {LastName}";
            }
        }


        public Teacher(int number , string firstName, string lastName, int roomID, int activityID)
        {
            Number = number;
            FirstName = firstName;
            LastName = lastName;
            RoomID = roomID;
            ActivityID = activityID;
        }
    }
}
