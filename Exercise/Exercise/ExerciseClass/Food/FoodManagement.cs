using Exercise.ExerciseClass.DataBase;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Forms;

namespace Exercise.ExerciseClass.Food
{
    internal class FoodManagement
    {
        string name;
        string category;
        string calorie;

        public DataTable ReturnAllList()
        {
            DataBaseConnect dbconn = new DataBaseConnect("select NAME, CATEGORY, CALORIE from food_info");
            return dbconn.Table;
        }

    }
}

