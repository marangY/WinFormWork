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

        //이미 가입하려는 아디를 다른 사람이 사용하고 있는지 확인
        public bool existenceId()
        {
            //DB에서 입력한 아이디와 일치하는 아이디를 가지고옴
            DataBaseConnect dbconn = new DataBaseConnect("select user_id from user_info where user_id = '" + id + "'");
            dbconn.getTableToDB();
            //존재 여부에 따라 리턴값 결정
            if (dbconn.Table.Rows.Count != 0)
            {
                return true;
            }
            return false;
        }

        //회원가입 절차
        public void authorization()
        {
            //DB에 회원정보 추가
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
