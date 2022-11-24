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
            String selectDate = DateTime.Now.ToString("yyyy-MM-dd");

            public FormRank()
            {
                InitializeComponent();
                rankDataGrid.DataSource = rs.retrunRankDate(selectDate);
        }
    }
}
