using System;
using SomerenDAL;
using SomerenModel;
using System.Collections.Generic;

namespace SomerenLogic
{
    public class TeacherService
    {
        private TeacherDAO teacherDao = new TeacherDAO();
        public List<Teacher> GetAllTeachers()
        {
            return teacherDao.GetAll();
        }
    }
}
