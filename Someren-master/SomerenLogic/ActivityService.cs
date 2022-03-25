using System;
using SomerenDAL;
using SomerenModel;
using System.Collections.Generic;

namespace SomerenLogic
{
    public class ActivityService
    {
        ActivityDao activitydb;

        public ActivityService()
        {
            activitydb = new ActivityDao();
        }

        public List<Activity> GetActivities()
        {
            List<Activity> activity = activitydb.GetAllActivities();
            return activity;
        }

        public void AddNewActivity(string newActivity)
        {
            activitydb.AddNewActivity(newActivity);
        }

        public void DeleteActivity(int id)
        {
            activitydb.DeleteActivity(id);
        }

        public void ChangeActivity(string newActivity, int id)
        {
            activitydb.ChangeActivity(newActivity, id);
        }
    }
}