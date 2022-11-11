﻿using Exercise.ExerciseClass.DataBase;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise.ExerciseClass.Exercise
{
    internal class ExercisManagement
    {
        string name;
        string category;
        string calorie;

        public DataTable ReturnAllList()
        {
            DataBaseConnect dbconn = new DataBaseConnect("select NAME, CATEGORY, CALORIE from exercise_info");
            return dbconn.Table;
        }

        public DataTable ReturnSelectCategoryList()
        {
            DataBaseConnect dbconn = new DataBaseConnect("select NAME, CATEGORY, CALORIE from food_info WHERE category='해산물'");
            return dbconn.Table;
        }
    }
}
