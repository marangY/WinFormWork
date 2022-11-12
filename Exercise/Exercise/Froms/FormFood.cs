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
        FoodManagement fm = new FoodManagement();
        string search;
        string category;

        public FormFood()
        {
            InitializeComponent();
            EFDataGridView.DataSource = fm.ReturnAllList();
        }

        public void UpdateGridView()
        {
            if (category == null || category.Equals("전체"))
            {
                EFDataGridView.DataSource = fm.ReturnSearchCategoryList(search);
            }
            else if (search == null || search.Equals(""))
            {
                EFDataGridView.DataSource = fm.ReturnSelectCategoryList(category);
            }
            else
            {
                EFDataGridView.DataSource = fm.ReturnSearchSelectCategoryList(category, search);
            }
        }

        private void categoryCustomComboBox_OnSelectedIndexChanged(object sender, EventArgs e)
        {
            category = categoryCustomComboBox.SelectedItem.ToString();
            UpdateGridView();
        }

        private void searchRoundButton_Click(object sender, EventArgs e)
        {
            search = searchCustomTextBox.Texts.ToString();
            UpdateGridView();
        }
    }
}
