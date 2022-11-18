using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Exercise.ExerciseClass.DataBase;

namespace Exercise.ExerciseClass.User
{
    internal class LoginService
    {
        private string id;
        private string pw;
        public LoginService(string id, string pw)
        {
            this.id = id;
            this.pw = PasswordEncoder.EncryptionSHA256(pw);
        }

        public bool existenceId()
        {
            DataBaseConnect dbconn = new DataBaseConnect("select user_id from user_info where user_id = '"+id+"'");
            dbconn.getTableToDB();
            if (dbconn.Table.Rows.Count != 0)
            {
                return true;
            }
            return false;
        }

        public bool checkingpassword()
        {
            DataBaseConnect dbconn = new DataBaseConnect("select user_id from user_info where user_id = '" + id + "'and password ='"+pw+"'");
            dbconn.getTableToDB();
            if (dbconn.Table.Rows.Count == 0)
            {
                return false;
            }
            if (dbconn.Table.Rows[0].ItemArray[0].ToString().Equals(id))
            {
                return true;
            }
            return false;
        }

        public void authorization()
        {
            Config.UserName = id;
            Config.Login = true;
        }
    }
}
