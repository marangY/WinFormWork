using Exercise.ExerciseClass.DataBase;
using Exercise.ExerciseClass.User;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OracleClient;
using System.Deployment.Application;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls.Primitives;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TaskbarClock;

namespace Exercise.ExerciseClass.Rank
{
    internal class RankService
    {
        //랭크 등록
        public void updateCalorie()
        {
            //오늘 일자 불러오기
            String date = DateTime.Now.ToString("yyyy-MM-dd");

            //운동, 음식 테이블에서 유저의 하루 소비 칼로리를 받아와서 총 칼로리 계산
            UserStatusService us = new UserStatusService();

            DataTable et = us.returnExerciseToday();
            DataTable ft = us.returnFoodToday();

            double totalex = 0;
            double totalfd = 0;

            foreach (DataRow row in et.Rows)
            {
                totalex += Double.Parse(row[0].ToString());
            }

            foreach (DataRow row in ft.Rows)
            {
                totalfd += Double.Parse(row[0].ToString());
            }

            OracleNumber totalExercise = OracleNumber.Parse(totalex.ToString());
            OracleNumber totalFood = OracleNumber.Parse(totalfd.ToString()); ;

            //merge 쿼리문을 통해 이미 데이터가 있다면 업데이트, 없다면 인서트로 데이터 추가
            DataBaseConnect dbconn = new DataBaseConnect("merge into total_calorie tc using dual on(tc.user_id = '"+Config.UserName+"' and tc.datenow = TO_DATE('"+date+"', 'YYYY-MM-DD-HH')) when matched then update set tc.FOOD_CALORIE = "+totalFood+", tc.EXERCISE_CALORIE = "+totalExercise+" when not matched then insert (tc.user_id, tc.datenow, tc.FOOD_CALORIE, tc.EXERCISE_CALORIE) VALUES('"+Config.UserName+"', TO_DATE('"+date+"', 'YYYY-MM-DD-HH'), "+totalFood+", "+totalExercise+")");
            dbconn.updateDB();
        }

        public DataTable retrunRankDate(string date)
        {
            DataBaseConnect dbconn = new DataBaseConnect("select ROWNUM as rank, USER_ID as name, kal from (select USER_ID , FOOD_CALORIE-EXERCISE_CALORIE as kal from total_calorie where datenow >= TO_DATE('"+date+"', 'YYYY-MM-DD') And datenow < TO_DATE('"+date+"', 'YYYY-MM-DD') + 1 order by FOOD_CALORIE-EXERCISE_CALORIE)");
            dbconn.getTableToDB();
            return dbconn.Table;
        }

        public DataTable retrunBoxValue()
        {
            DataBaseConnect dbconn = new DataBaseConnect("select DISTINCT to_char(datenow, 'YYYY-MM-DD') as selectdate from total_calorie order by selectdate DESC");
            dbconn.getTableToDB();
            return dbconn.Table;
        }
    }
}
