using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Collections.ObjectModel;
using SomerenModel;

namespace SomerenDAL
{
    public class ActivityDao : BaseDao
    {
        public List<Activity> GetAllActivities()
        {
            string query = "SELECT ActivityId, Activity FROM Activity";
            SqlParameter[] sqlParameters = new SqlParameter[0];
            return ReadTables(ExecuteSelectQuery(query, sqlParameters));
        }

        private List<Activity> ReadTables(DataTable dataTable)
        {
            List<Activity> activities = new List<Activity>();

            foreach (DataRow dr in dataTable.Rows)
            {
                Activity activity = new Activity()
                {
                    ActivityId = (int)dr["ActivityId"],
                    ActivityName = (string)(dr["Activity"])                    
                };
                activities.Add(activity);
            }
            return activities;
        }

        public void AddNewActivity(string newActivity)
        {
            string query = "INSERT INTO Activity(Activity) VALUES(@newActivity); ";

            SqlParameter[] sqlParameters = { new SqlParameter("@newActivity", SqlDbType.VarChar) { Value = newActivity } };
                                             

            ExecuteEditQuery(query, sqlParameters);
        }

        public void DeleteActivity(int id)
        {
            string updateQuery = $"Update Teachers SET ActivityID = NULL WHERE ActivityId = @id";

            SqlParameter[] updateSQLParameters = { new SqlParameter("@id", SqlDbType.Int) { Value = id } };

            ExecuteEditQuery(updateQuery, updateSQLParameters);

            string activityQuery = "DELETE FROM Activity WHERE ActivityId = @id";

            SqlParameter[] activitySQLParameters = { new SqlParameter("@id", SqlDbType.Int) { Value = id } };

            ExecuteEditQuery(activityQuery, activitySQLParameters);
        }

        public void ChangeActivity(string newActivity, int id)
        {
            string query = "UPDATE Activity SET Activity = @newActivity WHERE ActivityId = @id";

            SqlParameter[] sqlParameters = { new SqlParameter("@newActivity", SqlDbType.VarChar) { Value = newActivity }, new SqlParameter("@id", SqlDbType.Int) { Value = id } };

            ExecuteEditQuery(query, sqlParameters);
        }
    }
}
