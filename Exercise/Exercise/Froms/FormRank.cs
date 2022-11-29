using Exercise.ExerciseClass.Rank;
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
        public partial class FormRank : Form
        {
            RankService rs = new RankService();
            int rankcount = 1;

            public FormRank()
            {
                InitializeComponent();
                rankDataGrid.MouseWheel += new MouseEventHandler(mousewheel);
                DataTable dateTable = rs.retrunBoxValue();

                DataRowCollection rows = dateTable.Rows;

                foreach (DataRow row in rows)
                {
                    dateComboBox.Items.Add(row[0].ToString());
                }

                if (dateTable.Rows.Count != 0)
                {
                    dateComboBox.SelectedIndex = 0;
                    rankDataGrid.DataSource = rs.retrunRankDate(dateComboBox.SelectedItem.ToString());
                    label1.Text = dateComboBox.SelectedItem.ToString() + " RANK";
                }
            }

            private void dateComboBox_OnSelectedIndexChanged(object sender, EventArgs e)
            {
                rankDataGrid.DataSource = rs.retrunRankDate(dateComboBox.SelectedItem.ToString());
                label1.Text = dateComboBox.SelectedItem.ToString() + " RANK";
            }

            private void mousewheel(object sender, MouseEventArgs e)
            {
                if (e.Delta > 0 && rankDataGrid.FirstDisplayedScrollingRowIndex > 0)
                {
                    rankDataGrid.FirstDisplayedScrollingRowIndex--;
                }
                else if (e.Delta < 0)
                {
                    rankDataGrid.FirstDisplayedScrollingRowIndex++;
                }
            }
        }
}
