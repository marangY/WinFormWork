using Exercise.ExerciseClass.Exercise;
using Exercise.ExerciseClass.Schedule;
using Exercise.Froms.SubForm;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OracleClient;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exercise.Froms
{
    public partial class FormSchedule : Form
    {
        ExerciseManagement em = new ExerciseManagement();
        ScheduleService ss = new ScheduleService();
        string search;
        string categorys = "전체";

        List<String> scheduleID;

        Regex regexnumber = new Regex(@"[0-9]");

        public FormSchedule()
        {
            InitializeComponent();
            EFDataGridView.DataSource = em.returnAllList();
            EFDataGridView.MouseWheel += new MouseEventHandler(mousewheel);
            scheduleCalendar.MaxSelectionCount = 1;
            scheduleCalendar.TodayDate = DateTime.Now;
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

        private void FormSchedule_Load(object sender, EventArgs e)
        {
            categoryCustomComboBox.SelectedIndex = 0;
            updateListView();
        }

        private void updateListView()
        {
            scheduleListView.Items.Clear();

            DataTable userScheduleTable = ss.returnUserSchedule();

            DataRowCollection rows = userScheduleTable.Rows;

            foreach (DataRow row in rows)
            {
                ListViewItem item = new ListViewItem(row[0].ToString());
                for(int i = 1; i < userScheduleTable.Columns.Count; i++)
                {
                    if(i == 4)
                    {
                        scheduleID.Add(row[i].ToString());
                    }
                    item.SubItems.Add(row[i].ToString());
                }
                scheduleListView.Items.Add(item);
            }
        }

        private void roundButton2_Click(object sender, EventArgs e)
        {
            if (exerciseLabel.Text.Equals("kind"))
            {
                sendMessage("운동을 선택해 주세요.");
                return;
            }

            if (!regexnumber.IsMatch(timeInput.Texts))
            {
                sendMessage("숫자를 입력해 주세요.");
                timeInput.Texts = string.Empty;
                timeInput.Focus();
                return;
            }

            DataGridViewRow row = EFDataGridView.SelectedRows[0];

            OracleNumber id = OracleNumber.Parse(row.Cells[0].Value.ToString());
            OracleNumber time = OracleNumber.Parse(timeInput.Texts);
            string date = scheduleCalendar.SelectionStart.ToString("yyyy-MM-dd");

            ss.addScheduleEntity(id, time, date);
            sendMessage("스케줄이 추가 되었습니다.");

            updateListView();
        }

        //메세지 박스
        public void sendMessage(string str)
        {
            MessageForm message = new MessageForm(str);
            message.StartPosition = FormStartPosition.CenterParent;
            SystemSounds.Beep.Play();
            message.ShowDialog();
        }

        private void EFDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = EFDataGridView.SelectedRows[0];

            exerciseLabel.Text = row.Cells[1].Value.ToString();
        }

        private void up_Click(object sender, EventArgs e)
        {
            
        }

        private void down_Click(object sender, EventArgs e)
        {

        }
    }
}
