using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SomerenModel
{
    public class Teacher
    {
        public int RoomID { get; set; }
        public string Name { get; set; }
        public bool Supervisor { get; set; }
        public int Number { get; set; } // LecturerNumber, e.g. 47198

        public Teacher(int teacher_ID, bool supervisor, int room_ID, string name)
        {
            Number = teacher_ID;
            Supervisor = supervisor;
            RoomID = room_ID;
            Name = name;
        }
    }
}
