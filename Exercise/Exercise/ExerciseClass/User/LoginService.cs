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
            //패스워드 SHA256암호화
            this.pw = PasswordEncoder.EncryptionSHA256(pw);
        }

        //아이디 존재 여부 확인 검사
        public bool existenceId()
        {
            //DB에서 입력한 이이디 값과 일치하는 아이디를 가지고옴
            DataBaseConnect dbconn = new DataBaseConnect("select user_id from user_info where user_id = '"+id+"'");
            dbconn.getTableToDB();
            //존재 여부에 따라 리턴값 변경
            if (dbconn.Table.Rows.Count != 0)
            {
                return true;
            }
            return false;
        }

        //패스워드 일치 검사
        public bool checkingpassword()
        {
            //DB에서 해당하는 아이디의 비밀번호를 받아옴
            DataBaseConnect dbconn = new DataBaseConnect("select user_id from user_info where user_id = '" + id + "'and password ='"+pw+"'");
            dbconn.getTableToDB();
            //일치 여부에 따라 리턴값 변경
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

        //Config 파일에 로그인 상태와 유저 아이디를 전송 및 저장
        //해당 변수는 static
        public void authorization()
        {
            Config.UserName = id;
            Config.Login = true;
        }
    }
}
