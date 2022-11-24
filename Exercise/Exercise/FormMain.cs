using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Media.Media3D;
using Exercise.ExerciseClass.DataBase;
using Exercise.ExerciseClass.Schedule;
using Exercise.Froms;
using Exercise.Froms.SubForm;
using FontAwesome.Sharp;

namespace Exercise
{
    public partial class FormMain : Form
    {
        // 필드
        ScheduleService ss = new ScheduleService();

        private IconButton currentBtn;
        private Panel leftBorderBtn;
        private Form currentChildFrom;

        public String Request
        {
            get { return idTitleChildFrom.Text; }
            set { idTitleChildFrom.Text = value; }
        }

        public FormMain()
        {
            InitializeComponent();
            leftBorderBtn = new Panel();
            leftBorderBtn.Size = new Size(7, 60);
            panelMenu.Controls.Add(leftBorderBtn);

            //From 기본설정
            this.Text = String.Empty;
            this.ControlBox = false;
            this.DoubleBuffered = true;
            this.iconCurrentChildForm.IconChar = IconChar.None;
            this.MinimumSize = new System.Drawing.Size(this.Width, this.Height);
            this.MaximumSize = new System.Drawing.Size(this.Width, this.Height);

            OpenOwnerFrom(new FormLogin());

            //시계 설정
            timer1.Start();
        }

        //버튼 활성화시 해당 버튼 색 리턴
        private struct RGBColors
        {
            public static Color color1 = Color.FromArgb(172, 126, 241);
            public static Color color2 = Color.FromArgb(249, 118, 176);
            public static Color color3 = Color.FromArgb(253, 138, 114);
            public static Color color4 = Color.FromArgb(95, 77, 221);
            public static Color color5 = Color.FromArgb(24, 161, 251);
            public static Color color6 = Color.FromArgb(135, 224, 93);

        }

        //버튼 선택 활성화
        private void ActivateButton(object senderBtn, Color color)
        {
            if (leftBorderBtn != null)
            {
                DisableButton();

                currentBtn = (IconButton)senderBtn;
                currentBtn.BackColor = Color.FromArgb(37, 36, 81);
                currentBtn.ForeColor = color;
                currentBtn.TextAlign = ContentAlignment.MiddleCenter;
                currentBtn.IconColor = color;
                currentBtn.TextImageRelation = TextImageRelation.TextBeforeImage;
                currentBtn.ImageAlign = ContentAlignment.MiddleRight;

                leftBorderBtn.BackColor = color;
                leftBorderBtn.Location = new Point(0, currentBtn.Location.Y);
                leftBorderBtn.Visible = true;
                leftBorderBtn.BringToFront();
            }
        }

        //버튼 선택 비활성화
        private void DisableButton()
        {
            if (currentBtn != null)
            {
                currentBtn.BackColor = Color.FromArgb(31, 30, 68);
                currentBtn.ForeColor = Color.White;
                currentBtn.TextAlign = ContentAlignment.MiddleLeft;
                currentBtn.IconColor = Color.White;
                currentBtn.TextImageRelation = TextImageRelation.ImageBeforeText;
                currentBtn.ImageAlign = ContentAlignment.MiddleLeft;
            }
        }

        //패널 안에 다른 폼 열기
        private void OpenChildFrom(Form childForm)
        {
            if(currentChildFrom != null)
            {
                currentChildFrom.Close();
            }
            currentChildFrom = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panelDeskTop.Controls.Add(childForm);
            panelDeskTop.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        //로그인, 회원 가입 폼 열기 설정
        private void OpenOwnerFrom(Form childForm)
        {
            currentChildFrom = childForm;
            childForm.Owner = this;

            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;

            panelDeskTop.Controls.Add(childForm);
            panelDeskTop.Tag = childForm;

            childForm.BringToFront();
            childForm.Show();

            idTitleChildFrom.Text = childForm.Text;
        }

        //홈버튼 클릭 이벤트 등록
        private void btnHome_Click(object sender, EventArgs e)
        {
            if (!Config.Login)
            {
                sendMessage("로그인이 필요합니다");
                return;
            }

            ActivateButton(sender, RGBColors.color1);

            changeIconCurrentChildForm(HomeBtn.IconColor, HomeBtn.IconChar, HomeBtn.Text);

            OpenChildFrom(new FormHome());
        }

        //랭크 버튼 클릭 이벤트 등록
        private void btnRanck_Click(object sender, EventArgs e)
        {
            if (!Config.Login)
            {
                sendMessage("로그인이 필요합니다");
                return;
            }

            ActivateButton(sender, RGBColors.color2);

            changeIconCurrentChildForm(RankBtn.IconColor, RankBtn.IconChar, RankBtn.Text);

            OpenChildFrom(new FormRank());
        }

        //음식 버튼 클릭 이벤트 등록 
        private void btnFood_Click(object sender, EventArgs e)
        {
            if (!Config.Login)
            {
                sendMessage("로그인이 필요합니다");
                return;
            }

            ActivateButton(sender, RGBColors.color3);

            changeIconCurrentChildForm(FoodBtn.IconColor, FoodBtn.IconChar, FoodBtn.Text);

            OpenChildFrom(new FormFood());
        }

        //운동 버튼 클릭 이벤트 등록
        private void btnExercise_Click(object sender, EventArgs e)
        {
            if (!Config.Login)
            {
                sendMessage("로그인이 필요합니다");
                return;
            }

            ActivateButton(sender, RGBColors.color4);

            changeIconCurrentChildForm(ExerciseBtn.IconColor, ExerciseBtn.IconChar, ExerciseBtn.Text);

            OpenChildFrom(new FormExercise());
        }

        //계산기 버튼 클릭 이벤트 등록
        private void btnCalculator_Click(object sender, EventArgs e)
        {
            if (!Config.Login)
            {
                sendMessage("로그인이 필요합니다");
                return;
            }

            ActivateButton(sender, RGBColors.color5);

            changeIconCurrentChildForm(CalculatorBtn.IconColor, CalculatorBtn.IconChar, CalculatorBtn.Text);

            OpenChildFrom(new FormCalculator());
        }

        private void ScheduleBtn_Click(object sender, EventArgs e)
        {
            if (!Config.Login)
            {
                sendMessage("로그인이 필요합니다");
                return;
            }

            ActivateButton(sender, RGBColors.color6);

            changeIconCurrentChildForm(ScheduleBtn.IconColor, ScheduleBtn.IconChar, ScheduleBtn.Text);

            OpenChildFrom(new FormSchedule());
        }

        //로고 클릭 이벤트 등록
        private void Logo_Click(object sender, EventArgs e)
        {
            if (!Config.Login)
            {
                sendMessage("로그인이 필요합니다");
                return;
            }

            currentChildFrom.Close();
            Reset();
            updateSchedule();
            changeIconCurrentChildForm(Color.DeepSkyBlue, IconChar.User, Config.UserName);
        }

        // 로고 클릭시 선택 초기화
        private void Reset()
        {
            DisableButton();
            leftBorderBtn.Visible = false;
        }

        //현재 선택  위치 반환(넷바)
        private void changeIconCurrentChildForm(Color color, IconChar iconChar, String text)
        {
            iconCurrentChildForm.IconChar = iconChar;
            iconCurrentChildForm.IconColor = color;

            idTitleChildFrom.Text = text;
            idTitleChildFrom.ForeColor = color;
        }

        //폼 이동 설정
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wPram, int lPram);

        private void panelTitleBar_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        //닫기 버튼
        private void CloseBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        
        //최소화 버튼
        private void MinimizeBtn_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        // 자식폼에서 보낸 데이터로 다른 폼 열기
        private void idTitleChildFrom_TextChanged(object sender, EventArgs e)
        {
            if (idTitleChildFrom.Text.Equals("JoinRequset"))
            {
                OpenOwnerFrom(new FormJoin());
            }
            else if (idTitleChildFrom.Text.Equals("LoginRequset"))
            {
                OpenOwnerFrom(new FormLogin());
            }
        }

        //시계
        private void timer1_Tick(object sender, EventArgs e)
        {
            clock.Text = DateTime.Now.ToString("HH:mm:ss");
            date.Text = DateTime.Now.ToString("yyyy MM dd dddd");
        }
        
        // 메세지 박스
        public void sendMessage(string str)
        {
            MessageForm message = new MessageForm(str);
            message.StartPosition = FormStartPosition.CenterParent;
            SystemSounds.Beep.Play();
            message.ShowDialog();
        }

        private void logout_Click(object sender, EventArgs e)
        {
            Reset();
            Config.UserName = null;
            Config.Login = false;
            logout.Visible = false;
            idTitleChildFrom.ForeColor = Color.FromArgb(31, 30, 68);
            iconCurrentChildForm.IconChar = IconChar.None;

            OpenOwnerFrom(new FormLogin());
        }

        public void updateSchedule()
        {
            DataTable todayTable = ss.returnTodaySchedule();

            DataRowCollection rows = todayTable.Rows;

            string scheduleTxt = "";

            foreach (DataRow row in rows)
            {
                string scheduleSave = "";

                for (int i = 0; i < todayTable.Columns.Count; i++)
                {
                    if(i == 0)
                    {
                        scheduleSave += row[i].ToString() + " : ";
                    }
                    else
                    {
                        scheduleSave += row[i].ToString() + "분";
                    }
                }
                scheduleSave += "\n";
                scheduleTxt += scheduleSave;
            }

            schedule.Text = scheduleTxt;
        }

        private void panelDeskTop_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
