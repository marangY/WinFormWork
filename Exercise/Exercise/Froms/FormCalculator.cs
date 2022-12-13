using Exercise.ExerciseClass.Calculator;
using Exercise.ExerciseClass.Exercise;
using Exercise.ExerciseClass.Food;
using Exercise.ExerciseClass.Rank;
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
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exercise.Froms
{
    public partial class FormCalculator : Form
    {

        //필드
        FoodManagement fm = new FoodManagement();
        ExerciseManagement em = new ExerciseManagement();
        RankService rs = new RankService();

        string search = null;
        string categorys = "전체";

        OracleNumber select_id;
        OracleNumber select_input;

        Regex regexnumber = new Regex(@"[0-9]");

        //생성자
        public FormCalculator()
        {
            InitializeComponent();
            EFDataGridView.MouseWheel += new MouseEventHandler(mousewheel);
        }

        // 계산기 로드
        private void FormCalculator_Load(object sender, EventArgs e)
        {
            selectCustomComboBox.SelectedIndex = 0;
        }

        //마우스 휠 이벤트 등록
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

        //계산기 스왑 콤보 박스 이벤트 등록
        private void selectCustomComboBox_OnSelectedIndexChanged(object sender, EventArgs e)
        {
            if (selectCustomComboBox.SelectedIndex == 0)
            {
                inputKind.Text = "kind";
                totalKal.Text = "0 kal";
                inputBox.Texts = String.Empty;

                EFDataGridView.Columns[0].DataPropertyName = "EXERCISE_ID";
                EFDataGridView.Columns[1].HeaderText = "운동종류";
                EFDataGridView.Columns[2].HeaderText = "카테고리";
                EFDataGridView.Columns[3].HeaderText = "분당 칼로리(kal)";
                inputLabel.Text = "Time (min)";
                kindTxt.Text = "Exercise";

                categoryCustomComboBox.Items.Clear();
                categoryCustomComboBox.Texts = String.Empty;
                categoryCustomComboBox.Items.Add("전체");
                categoryCustomComboBox.Items.Add("유산소");
                categoryCustomComboBox.Items.Add("구기종목");
                categoryCustomComboBox.Items.Add("무술");
                categoryCustomComboBox.Items.Add("맨몸운동");
                categoryCustomComboBox.Items.Add("기타");
                categoryCustomComboBox.SelectedIndex = 0;

                EFDataGridView.DataSource = em.returnAllList();
            }
            else if (selectCustomComboBox.SelectedIndex == 1)
            {
                inputKind.Text = "kind";
                totalKal.Text = "0 kal";
                inputBox.Texts = String.Empty;

                EFDataGridView.Columns[0].DataPropertyName = "FOOD_ID";
                EFDataGridView.Columns[1].HeaderText = "음식종류";
                EFDataGridView.Columns[2].HeaderText = "카테고리";
                EFDataGridView.Columns[3].HeaderText = "그램당 칼로리(kal)";
                inputLabel.Text = "gram (g)";
                kindTxt.Text = "Food";

                categoryCustomComboBox.Items.Clear();
                categoryCustomComboBox.Texts = String.Empty;
                categoryCustomComboBox.Items.Add("전체");
                categoryCustomComboBox.Items.Add("곡류");
                categoryCustomComboBox.Items.Add("채소");
                categoryCustomComboBox.Items.Add("과일");
                categoryCustomComboBox.Items.Add("유제품");
                categoryCustomComboBox.Items.Add("육류");
                categoryCustomComboBox.Items.Add("해산물");
                categoryCustomComboBox.Items.Add("주류");
                categoryCustomComboBox.Items.Add("음료");
                categoryCustomComboBox.Items.Add("요리");
                categoryCustomComboBox.Items.Add("기타");
                categoryCustomComboBox.SelectedIndex = 0;

                EFDataGridView.DataSource = fm.returnAllList();
            }
        }

        //음식 데이터 그리드뷰 업데이트 함수
        public void UpdatefmGridView()
        {
            if (search != null && categorys.Equals("전체"))
            {
                EFDataGridView.DataSource = fm.returnSearchList(search);
            }
            else if (search == null && !categorys.Equals("전체"))
            {
                EFDataGridView.DataSource = fm.returnSelectCategoryList(categorys);
            }
            else if (search == null || categorys.Equals("전체"))
            {
                EFDataGridView.DataSource = fm.returnAllList();
            }
            else
            {
                EFDataGridView.DataSource = fm.returnSearchSelectList(categorys, search);
            }
        }

        //운동 데이터 그리드뷰 업데이트 함수
        public void UpdateemGridView()
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

        // 카테고리 선택 이벤트
        private void categoryCustomComboBox_OnSelectedIndexChanged(object sender, EventArgs e)
        {
            categorys = categoryCustomComboBox.SelectedItem.ToString();

            if (selectCustomComboBox.SelectedIndex == 0)
            {
                UpdateemGridView();
            }
            else if (selectCustomComboBox.SelectedIndex == 1)
            {
                UpdatefmGridView();
            }
         }

        // 검색 버튼 이벤트
        private void roundButton1_Click(object sender, EventArgs e)
        {
            search = searchCustomTextBox.Texts.ToString();

            if (selectCustomComboBox.SelectedIndex == 0)
            {
                UpdateemGridView();
            }
            else if (selectCustomComboBox.SelectedIndex == 1)
            {
                UpdatefmGridView();
            }
        }

        //검색 엔터 단축키 등록
        private void searchCustomTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                e.Handled = true;

                search = searchCustomTextBox.Texts.ToString();

                if (selectCustomComboBox.SelectedIndex == 0)
                {
                    UpdateemGridView();
                }
                else if (selectCustomComboBox.SelectedIndex == 1)
                {
                    UpdatefmGridView();
                }
            }
        }

        //그리드뷰 셀클릭 이벤트 등록
        private void EFDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            updateInfo();
        }
        private void saveToday_Click(object sender, EventArgs e)
        {
            updateInfo();

            CalculatorService cs = new CalculatorService();
            if (selectCustomComboBox.SelectedIndex == 0)
            {
                cs.addExerciseEntity(select_id, select_input);
            }
            else if (selectCustomComboBox.SelectedIndex == 1)
            {
                cs.addFoodEntity(select_id, select_input);
            }

            sendMessage("오늘 활동에 추가 되었습니다.");
            rs.updateCalorie();
        }

        //오늘 활동 등록 버튼 이벤트
        public void updateInfo()
        {
            //유효성 검사
            if (inputBox.Texts == "")
            {
                if (selectCustomComboBox.SelectedIndex == 0)
                {
                    sendMessage("운동 시간을 입력해 주세요.");
                    inputBox.Focus();
                }
                else if (selectCustomComboBox.SelectedIndex == 1)
                {
                    sendMessage("음식 그램을 입력해 주세요.");
                    inputBox.Focus();
                }
                return;
            }

            if (!regexnumber.IsMatch(inputBox.Texts))
            {
                sendMessage("숫자를 입력해 주세요.");
                inputBox.Texts = string.Empty;
                inputBox.Focus();
            }

            DataGridViewRow row = EFDataGridView.SelectedRows[0];

            inputKind.Text = row.Cells[1].Value.ToString();
            totalKal.Text = (Double.Parse(row.Cells[3].Value.ToString()) * Double.Parse(inputBox.Texts)).ToString();

            select_id = OracleNumber.Parse(row.Cells[0].Value.ToString());
            select_input = OracleNumber.Parse(inputBox.Texts);
        }



        //메세지 박스
        public void sendMessage(string str)
        {
            MessageForm message = new MessageForm(str);
            message.StartPosition = FormStartPosition.CenterParent;
            SystemSounds.Beep.Play();
            message.ShowDialog();
        }
    }
}
