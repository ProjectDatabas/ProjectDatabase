using System;
using SomerenModel;
using System.Data.SqlClient;
using System.Collections.Generic;
using System.Configuration;

namespace SomerenDAL
{
    class LecturerDAO : BaseDao
    {
        private SqlConnection dbConnection;

        public LecturerDAO()
        {
            string connString = ConfigurationManager
                                     .ConnectionStrings["DBConnectionString"]
                                     .ConnectionString;
            dbConnection = new SqlConnection(connString);
        }


        public List<Teacher> GetAll()
        {
            dbConnection.Open();

            SqlCommand command = new SqlCommand("SELECT * FROM Customers", dbConnection);
            SqlDataReader reader = command.ExecuteReader();
            List<Teacher> teachers = new List<Teacher>();

            while (reader.Read())
            {
                Teacher teacher = ReadTeacher(reader);
                teachers.Add(teacher);
            }

            reader.Close();

            dbConnection.Close();

            return teachers;
        }
        private Teacher ReadTeacher(SqlDataReader reader)
        {
            // retrieve data from all fields
            int teacher_ID = (int)reader["Teacher_ID"];
            bool supervisor = (bool)reader["Supervisor"];
            int room_ID = (int)reader["Room_ID"];
            string name = (string)reader["name"];

            // return new Customer object
            Teacher teacher = new Teacher(teacher_ID, supervisor, room_ID, name);
            return teacher;
        }
    }
}
