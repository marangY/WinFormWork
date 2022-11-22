using Exercise.ExerciseClass.DataBase;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OracleClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise.ExerciseClass.User
{
    internal class UserStatusService
    {
        public bool isNullTable(DataTable data)
        {
            if(data.Rows.Count == 0)
            {
                return true;
            }
            
            return false;
        }

        public DataTable returnUserStatus()
        {
            DataBaseConnect dbconn = new DataBaseConnect("select HEIGHT, WEIGHT, BODY_FAT from user_status WHERE user_id = '"+Config.UserName+"'");
            dbconn.getTableToDB();
            return dbconn.Table;
        }

        public DataTable returnExerciseToday()
        {
            String date = DateTime.Now.ToString("yyyy-MM-dd");
            DataBaseConnect dbconn = new DataBaseConnect("select ue.TIME*e.CALORIE from exercise_info e, user_exercise ue where ue.user_id = '"+Config.UserName+"' And ue.datenow >= TO_DATE('"+date+"', 'YYYY-MM-DD') And ue.datenow < TO_DATE('"+date+"', 'YYYY-MM-DD') + 1 And ue.exercise = e.exercise_id");
            dbconn.getTableToDB();
            return dbconn.Table;
        }

        public DataTable returnFoodToday()
        {
            String date = DateTime.Now.ToString("yyyy-MM-dd");
            DataBaseConnect dbconn = new DataBaseConnect("select uf.weight*f.CALORIE from food_info f, user_food uf where uf.user_id = '" + Config.UserName + "' And uf.datenow >= TO_DATE('" + date + "', 'YYYY-MM-DD') And uf.datenow < TO_DATE('" + date + "', 'YYYY-MM-DD') + 1 And uf.food = f.food_id");
            dbconn.getTableToDB();
            return dbconn.Table;
        }

        public void addUserStatus(OracleNumber height, OracleNumber weight, OracleNumber bodyfat)
        {
            DataBaseConnect dbconn = new DataBaseConnect("insert into user_status VALUES('"+Config.UserName+"', "+ height  + ", "+ weight +", "+ bodyfat +")");
            dbconn.updateDB();
        }

        public void updateUserStatus(OracleNumber height, OracleNumber weight, OracleNumber bodyfat)
        {
            DataBaseConnect dbconn = new DataBaseConnect("update user_status set height = "+ height  +", weight = "+ weight +", body_fat = "+ bodyfat +" where user_id = '"+ Config.UserName +"'");
            dbconn.updateDB();
        }
    }
}
