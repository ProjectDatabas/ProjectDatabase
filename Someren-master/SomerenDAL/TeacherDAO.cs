using System;
using SomerenModel;
using System.Configuration;
using System.Data.SqlClient;
using System.Collections.Generic;
using System.Data;

namespace SomerenDAL
{
    public class TeacherDAO : BaseDao
    {   
        public List<Teacher> GetAll()
        {
            string query = "SELECT teacher_ID, room_ID, FirstName, LastName, ActivityID FROM Teachers AS T JOIN Supervisors AS S ON T.Teacher_ID = S.TeacherID";
            SqlParameter[] sqlParameters = new SqlParameter[0];
            return ReadTables(ExecuteSelectQuery(query, sqlParameters));
        }

        private List<Teacher> ReadTables(DataTable dataTable)
        {
            List<Teacher> teachers = new List<Teacher>();

            foreach (DataRow dr in dataTable.Rows)
            {
                int number = (int)dr["teacher_ID"];
                string firstName = (string)(dr["FirstName"].ToString());
                string lastName = (string)(dr["LastName"].ToString());
                int roomID = (int)(dr["Room_ID"]);
                int activityID = (int)(dr["ActivityID"]);
                Teacher teacher = new Teacher(number, firstName, lastName, roomID, activityID);
                teachers.Add(teacher);
            }
            return teachers;
        }
    }
}
