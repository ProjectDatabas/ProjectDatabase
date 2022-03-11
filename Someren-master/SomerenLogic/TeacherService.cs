using System;
using SomerenDAL;
using SomerenModel;
using System.Collections.Generic;

namespace SomerenLogic
{
    public class TeacherService
    {
        private TeacherDAO LecturerDAO = new TeacherDAO();
        public List<Teacher> GetAllTeachers()
        {
            return LecturerDAO.GetAll();
        }
    }
}
