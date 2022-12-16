using Exercise.ExerciseClass.DataBase;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OracleClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Forms;

namespace Exercise.ExerciseClass.Food
{
    internal class FoodManagement
    {
        //전체 음식 정보 가지고 오기
        public DataTable returnAllList()
        {
            DataBaseConnect dbconn = new DataBaseConnect("select FOOD_ID, NAME, CATEGORY, CALORIE from food_info");
            dbconn.getTableToDB();
            return dbconn.Table;
        }

        //입력받은 카테고리에 해당하는 정보 가지고 오기
        public DataTable returnSelectCategoryList(string category)
        {
            DataBaseConnect dbconn = new DataBaseConnect("select FOOD_ID, NAME, CATEGORY, CALORIE from food_info WHERE category='" + category + "'");
            dbconn.getTableToDB();
            return dbconn.Table;
        }

        //검색어를 포함하는 정보 가지고 오기
        public DataTable returnSearchList(string name)
        {
            DataBaseConnect dbconn = new DataBaseConnect("select FOOD_ID, NAME, CATEGORY, CALORIE from food_info WHERE name like'%" + name + "%'");
            dbconn.getTableToDB();
            return dbconn.Table;
        }

        //검색어를 포함하고 카테고리에 해당하는 정보 가지고 오기
        public DataTable returnSearchSelectList(string category, string name)
        {
            DataBaseConnect dbconn = new DataBaseConnect("select FOOD_ID, NAME, CATEGORY, CALORIE from food_info WHERE name like'%" + name + "%' AND category='" + category + "'");
            dbconn.getTableToDB();
            return dbconn.Table;
        }

        //정보 추가
        public void addEntity(String name, String category, OracleNumber gram)
        {
            DataBaseConnect dbconn = new DataBaseConnect("insert into food_info VALUES(SEQ_FOOD_ID.NEXTVAL, '" + name + "', " + gram + ", '" + category + "')");
            dbconn.updateDB();
        }
    }
}

