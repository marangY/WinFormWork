using Exercise.ExerciseClass.DataBase;
using Exercise.ExerciseClass.User;
using Exercise.Froms.SubForm;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OracleClient;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exercise.Froms
{
    public partial class FormHome : Form
    {
        double ht;
        double wt;

        UserStatusService us = new UserStatusService();
        DataTable ut = new DataTable();

        public FormHome()
        {
            InitializeComponent();

            updateToday();
            EDataGridView.MouseWheel += new MouseEventHandler(mousewheelExercise);
            FDataGridView.MouseWheel += new MouseEventHandler(mousewheelFood);

            FDataGridView.DataSource = us.returnTodayFoodTotal();
            EDataGridView.DataSource = us.returnTodayExerciseTotal();
        }

        private void FormHome_Load(object sender, EventArgs e)
        {
            user.Text = Config.UserName;
            ut = us.returnUserStatus();

            if (us.isNullTable(ut))
            {
                sendMessage("유저 신체 정보가 없습니다. 초기값을 입력해주세요.");
            }
            else
            {
                height.Text = ut.Rows[0].ItemArray[0].ToString();
                weight.Text = ut.Rows[0].ItemArray[1].ToString();
                bodyFat.Text = ut.Rows[0].ItemArray[2].ToString();

                ht = Double.Parse(ut.Rows[0].ItemArray[0].ToString());
                wt = Double.Parse(ut.Rows[0].ItemArray[1].ToString());

                bmi.Text = (Math.Round(wt / ((ht / 100) * (ht / 100))*100)/100.0).ToString();
            }
        }

        //메세지 박스
        public void sendMessage(string str)
        {
            MessageForm message = new MessageForm(str);
            message.StartPosition = FormStartPosition.CenterParent;
            SystemSounds.Beep.Play();
            message.ShowDialog();
        }

        private void statusUpdateButton_Click(object sender, EventArgs e)
        {

            OracleNumber ht;
            OracleNumber wt;
            OracleNumber bf;
            try
            {
                ht = OracleNumber.Parse(height.Text);
                wt = OracleNumber.Parse(weight.Text);
                bf = OracleNumber.Parse(bodyFat.Text);
            }
            catch (Exception ex)
            {
                sendMessage("유저 신체 정보에 올바른 값을 입력해주세요.");
                return;
            }

            if (us.isNullTable(ut))
            {
                us.addUserStatus(ht, wt, bf);
            }
            else
            {
                us.updateUserStatus(ht, wt, bf);
            }

            this.ht = Double.Parse(height.Text);
            this.wt = Double.Parse(weight.Text);

            sendMessage("유저 신체 정보가 갱신 되었습니다.");
            bmi.Text = (Math.Round(this.wt / ((this.ht / 100) * (this.ht / 100)) * 100) / 100.0).ToString();
        }

        private void mousewheelExercise(object sender, MouseEventArgs e)
        {
            if (e.Delta > 0 && EDataGridView.FirstDisplayedScrollingRowIndex > 0)
            {
                EDataGridView.FirstDisplayedScrollingRowIndex--;
            }
            else if (e.Delta < 0)
            {
                EDataGridView.FirstDisplayedScrollingRowIndex++;
            }
        }

        private void mousewheelFood(object sender, MouseEventArgs e)
        {
            if (e.Delta > 0 && FDataGridView.FirstDisplayedScrollingRowIndex > 0)
            {
                FDataGridView.FirstDisplayedScrollingRowIndex--;
            }
            else if (e.Delta < 0)
            {
                FDataGridView.FirstDisplayedScrollingRowIndex++;
            }
        }

        private void updateToday()
        {
            DataTable et = us.returnExerciseToday();
            DataTable ft = us.returnFoodToday();

            double eTotal = 0;
            double fTotal = 0;

            foreach (DataRow row in et.Rows)
            {
                eTotal += Double.Parse(row[0].ToString());
            }

            foreach (DataRow row in ft.Rows)
            {
                fTotal += Double.Parse(row[0].ToString());
            }

            foodKal.Text = fTotal.ToString() + " kal";
            exerciseKal.Text = eTotal.ToString() + " kal";
            totalKal.Text = (fTotal - eTotal).ToString() + " kal";
        }
    }
}
