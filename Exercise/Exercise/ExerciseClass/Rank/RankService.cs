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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TaskbarClock;

namespace Exercise.ExerciseClass.Rank
{
    internal class RankService
    {
        public void updateCalorie()
        {
            String date = DateTime.Now.ToString("yyyy-MM-dd");

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

            DataBaseConnect dbconn = new DataBaseConnect("merge into total_calorie tc using dual on(tc.user_id = '"+Config.UserName+"' and tc.datenow = TO_DATE('"+date+"', 'YYYY-MM-DD-HH')) when matched then update set tc.FOOD_CALORIE = "+totalFood+", tc.EXERCISE_CALORIE = "+totalExercise+" when not matched then insert (tc.user_id, tc.datenow, tc.FOOD_CALORIE, tc.EXERCISE_CALORIE) VALUES('"+Config.UserName+"', TO_DATE('"+date+"', 'YYYY-MM-DD-HH'), "+totalFood+", "+totalExercise+")");
            dbconn.updateDB();
        }

        public DataTable retrunRankDate(string date)
        {
            DataBaseConnect dbconn = new DataBaseConnect("select USER_ID as name, FOOD_CALORIE-EXERCISE_CALORIE as kal from total_calorie where datenow >= TO_DATE('"+date+"', 'YYYY-MM-DD') And datenow < TO_DATE('" + date + "', 'YYYY-MM-DD') + 1 order by FOOD_CALORIE-EXERCISE_CALORIE");
            dbconn.getTableToDB();
            return dbconn.Table;
        }
    }
}
