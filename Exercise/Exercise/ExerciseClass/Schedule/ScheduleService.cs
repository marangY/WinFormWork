using Exercise.ExerciseClass.DataBase;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OracleClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise.ExerciseClass.Schedule
{
    internal class ScheduleService
    {
        public void addScheduleEntity(OracleNumber id, OracleNumber time, string date){ 
        
            DataBaseConnect dbconn = new DataBaseConnect("insert into user_schedule VALUES(SEQ_SCHEDULE_ID.NEXTVAL, '" + Config.UserName + "', TO_DATE('" + date + "', 'YYYY-MM-DD-HH'), " + id + ", " + time + ")");
            dbconn.updateDB();
        }

        public DataTable returnUserSchedule()
        {
            DataBaseConnect dbconn = new DataBaseConnect("select e.name, us.time, TO_CHAR(us.datenow, 'YYYY-MM-DD') from user_schedule us, exercise_info e where us.user_id = '" + Config.UserName + "' And e.exercise_id = us.exercise_id");
            dbconn.getTableToDB();
            return dbconn.Table;
        }

        public DataTable returnTodaySchedule()
        {
            String date = DateTime.Now.ToString("yyyy-MM-dd");
            DataBaseConnect dbconn = new DataBaseConnect("select e.name, us.time from user_schedule us, exercise_info e where us.user_id = '" + Config.UserName + "' And e.exercise_id = us.exercise_id And us.datenow >= TO_DATE('" + date + "', 'YYYY-MM-DD') And us.datenow < TO_DATE('" + date + "', 'YYYY-MM-DD') + 1");
            dbconn.getTableToDB();
            return dbconn.Table;
        }
    }
}
