using Exercise.ExerciseClass.DataBase;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OracleClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise.ExerciseClass.Exercise
{
    internal class ExerciseManagement
    {
        public DataTable returnAllList()
        {
            DataBaseConnect dbconn = new DataBaseConnect("select NAME, CATEGORY, CALORIE from exercise_info");
            dbconn.getTableToDB();
            return dbconn.Table;
        }

        public DataTable returnSelectCategoryList(string category)
        {
            DataBaseConnect dbconn = new DataBaseConnect("select NAME, CATEGORY, CALORIE from exercise_info WHERE category='"+ category + "'");
            dbconn.getTableToDB();
            return dbconn.Table;
        }

        public DataTable returnSearchList(string name)
        {
            DataBaseConnect dbconn = new DataBaseConnect("select NAME, CATEGORY, CALORIE from exercise_info WHERE name like'%" + name + "%'");
            dbconn.getTableToDB();
            return dbconn.Table;
        }

        public DataTable returnSearchSelectList(string category, string name)
        {
            DataBaseConnect dbconn = new DataBaseConnect("select NAME, CATEGORY, CALORIE from exercise_info WHERE name like'%" + name + "%' AND category='" + category + "'");
            dbconn.getTableToDB();
            return dbconn.Table;
        }
       
        public void addEntity(String name, String category, OracleNumber time)
        {
            DataBaseConnect dbconn = new DataBaseConnect("insert into exercise_info VALUES(SEQ_EXERCISE_ID.NEXTVAL, '" + name + "', " + time + ", '" + category + "')");
            dbconn.updateDB();
        }
    }
}
