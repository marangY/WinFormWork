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
    public partial class FormCalculator : Form
    {
        public FormCalculator()
        {
            InitializeComponent();
        }

        private void FormCalculator_Load(object sender, EventArgs e)
        {
            selectCustomComboBox.SelectedIndex = 0;
        }

        private void selectCustomComboBox_OnSelectedIndexChanged(object sender, EventArgs e)
        {
            if (selectCustomComboBox.SelectedIndex == 0)
            {
                EFDataGridView.Columns[0].HeaderText = "운동종류";
                EFDataGridView.Columns[1].HeaderText = "카테고리";
                EFDataGridView.Columns[2].HeaderText = "분당 칼로리(kal)";
                inputLabel.Text = "Time (min)";
                kindTxt.Text = "Exercise";
            }
            else if (selectCustomComboBox.SelectedIndex == 1)
            {
                EFDataGridView.Columns[0].HeaderText = "음식종류";
                EFDataGridView.Columns[1].HeaderText = "카테고리";
                EFDataGridView.Columns[2].HeaderText = "그램당 칼로리(kal)";
                inputLabel.Text = "gram (g)";
                kindTxt.Text = "Food";
            }
        }
    }
}
