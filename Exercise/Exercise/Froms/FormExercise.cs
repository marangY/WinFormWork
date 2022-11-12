using Exercise.ExerciseClass.Exercise;
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
    public partial class FormExercise : Form
    {
        ExercisManagement em = new ExercisManagement();
        string search;
        string category;

        public FormExercise()
        {
            InitializeComponent();
            EFDataGridView.DataSource = em.ReturnAllList();
        }

        public void UpdateGridView()
        {
            if (category == null || category.Equals("전체"))
            {
                EFDataGridView.DataSource = em.ReturnSearchCategoryList(search);
            }
            else if (search == null || search.Equals(""))
            {
                EFDataGridView.DataSource = em.ReturnSelectCategoryList(category);
            }
            else
            {
                EFDataGridView.DataSource = em.ReturnSearchSelectCategoryList(category, search);
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
