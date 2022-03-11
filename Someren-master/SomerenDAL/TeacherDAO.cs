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
            string query = "SELECT teacher_ID, supervisor, room_ID, [name] FROM Teachers";
            SqlParameter[] sqlParameters = new SqlParameter[0];
            return ReadTables(ExecuteSelectQuery(query, sqlParameters));
        }

        private List<Teacher> ReadTables(DataTable dataTable)
        {
            List<Teacher> teachers = new List<Teacher>();

            foreach (DataRow dr in dataTable.Rows)
            {
                bool supervisor = (bool)dr["supervisor"];
                int number = (int)dr["teacher_ID"];
                string name = (string)(dr["name"].ToString());
                int roomID = (int)(dr["Room_ID"]);
                Teacher teacher = new Teacher(number, name, supervisor, roomID);
                teachers.Add(teacher);
            }
            return teachers;
        }
    }
}
