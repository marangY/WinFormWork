using Exercise.ExerciseClass.DataBase;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise.ExerciseClass.User
{
    internal class JoinService
    {
        private string id;
        private string pw;
        private string em;

        public JoinService(string id, string pw, string em)
        {
            this.id = id;
            this.pw = PasswordEncoder.EncryptionSHA256(pw);
            this.em = em;
        }

        public bool existenceId()
        {
            DataBaseConnect dbconn = new DataBaseConnect("select user_id from user_info where user_id = '" + id + "'");
            dbconn.getTableToDB();
            if (dbconn.Table.Rows.Count != 0)
            {
                return true;
            }
            return false;
        }

        public void authorization()
        {
            DataBaseConnect dbconn = new DataBaseConnect("select * from user_info");
            dbconn.getTableToDB();
            DataRow newRow = dbconn.Table.NewRow();
            newRow["user_id"] = id;
            newRow["password"] = pw;
            newRow["email"] = em;

            dbconn.Table.Rows.Add(newRow);
            dbconn.DBAdapter.Update(dbconn.DS);
        }

    }
}
