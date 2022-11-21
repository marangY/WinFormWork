using Exercise.ExerciseClass.DataBase;
using Exercise.Froms.SubForm;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OracleClient;
using System.Linq;
using System.Media;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exercise.ExerciseClass.Calculator
{
    internal class CalculatorService
    {
        public void addExerciseEntity(OracleNumber id, OracleNumber input)
        {
            String date = DateTime.Now.ToString("yyyy-MM-dd-HH:mm:ss");
            DataBaseConnect dbconn = new DataBaseConnect("insert into user_exercise VALUES('" + Config.UserName + "', SEQ_USER_EXERCISE_ID.NEXTVAL, " + id + ", " + input + ", TO_DATE('"+date+"', 'YYYY-MM-DD-HH24:MI:SS'))");
            dbconn.updateDB();
        }

        public void addFoodEntity(OracleNumber id, OracleNumber input)
        {
            String date = DateTime.Now.ToString("yyyy-MM-dd-HH:mm:ss");
            DataBaseConnect dbconn = new DataBaseConnect("insert into user_food VALUES('" + Config.UserName + "', SEQ_USER_FOOD_ID.NEXTVAL, " + id + ", " + input + ", TO_DATE('" + date + "', 'YYYY-MM-DD-HH24:MI:SS'))");
            dbconn.updateDB();
        }

    }
}
