using Exercise.ExerciseClass.DataBase;
using Exercise.ExerciseClass.Food;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exercise.Froms
{
    public partial class FormFood : Form
    {
        public FormFood()
        {
            InitializeComponent();
            FoodManagement fm = new FoodManagement();

            EFDataGridView.DataSource = fm.ReturnAllList();
        }


    }
}
