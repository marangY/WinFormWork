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
        public DataTable returnUserStatus()
        {
            DataBaseConnect dbconn = new DataBaseConnect("select HEIGHT, WEIGHT, BODY_FAT from user_status WHERE user_id = '"+Config.UserName+"'");
            dbconn.getTableToDB();
            return dbconn.Table;
        }

        public bool isNullTable(DataTable data)
        {
            if(data.Rows.Count == 0)
            {
                return true;
            }
            
            return false;
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
