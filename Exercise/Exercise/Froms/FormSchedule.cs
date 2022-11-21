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
    public partial class FormSchedule : Form
    {
        ExerciseManagement em = new ExerciseManagement();
        string search;
        string categorys = "전체";

        public FormSchedule()
        {
            InitializeComponent();
            EFDataGridView.DataSource = em.returnAllList();
            EFDataGridView.MouseWheel += new MouseEventHandler(mousewheel);
        }

        private void mousewheel(object sender, MouseEventArgs e)
        {
            if (e.Delta > 0 && EFDataGridView.FirstDisplayedScrollingRowIndex > 0)
            {
                EFDataGridView.FirstDisplayedScrollingRowIndex--;
            }
            else if (e.Delta < 0)
            {
                EFDataGridView.FirstDisplayedScrollingRowIndex++;
            }
        }

        public void UpdateGridView()
        {
            if (search != null && categorys.Equals("전체"))
            {
                EFDataGridView.DataSource = em.returnSearchList(search);
            }
            else if (search == null && !categorys.Equals("전체"))
            {
                EFDataGridView.DataSource = em.returnSelectCategoryList(categorys);
            }
            else if (search == null || categorys.Equals("전체"))
            {
                EFDataGridView.DataSource = em.returnAllList();
            }
            else
            {
                EFDataGridView.DataSource = em.returnSearchSelectList(categorys, search);
            }
        }

        private void categoryCustomComboBox_OnSelectedIndexChanged(object sender, EventArgs e)
        {
            categorys = categoryCustomComboBox.SelectedItem.ToString();
            if (searchCustomTextBox.Texts == null || searchCustomTextBox.Texts.Equals(""))
            {
                search = null;
            }
            UpdateGridView();
        }

        private void searchRoundButton_Click(object sender, EventArgs e)
        {
            search = searchCustomTextBox.Texts.ToString();
            if (categoryCustomComboBox.SelectedIndex == -1)
            {
                categorys = "전체";
            }
            UpdateGridView();
        }
    }
}
