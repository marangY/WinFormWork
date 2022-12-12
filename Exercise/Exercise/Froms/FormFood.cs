using Exercise.ExerciseClass.DataBase;
using Exercise.ExerciseClass.Food;
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
    public partial class FormFood : Form
    {
        FoodManagement fm = new FoodManagement();
        string search;
        string categorys;

        public FormFood()
        {
            InitializeComponent();
            EFDataGridView.DataSource = fm.returnAllList();
            EFDataGridView.MouseWheel += new MouseEventHandler(mousewheel);
        }

        private void FormFood_Load(object sender, EventArgs e)
        {
            categoryCustomComboBox.SelectedIndex = 0;
        }

        public void UpdateGridView()
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

        private void categoryCustomComboBox_OnSelectedIndexChanged(object sender, EventArgs e)
        {
            categorys = categoryCustomComboBox.SelectedItem.ToString();
            if(searchCustomTextBox.Texts == null || searchCustomTextBox.Texts.Equals(""))
            {
                search = null;
            }
            UpdateGridView();
        }

        private void searchRoundButton_Click(object sender, EventArgs e)
        {
            search = searchCustomTextBox.Texts;
            if (categoryCustomComboBox.SelectedIndex == -1)
            {
                categorys = "전체";
            }
            UpdateGridView();
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

        private void iconPictureBox3_Click(object sender, EventArgs e)
        {
            String name = nameTxt.Texts;
            String category = categoryInputCustomComboBox.SelectedItem.ToString();
            OracleNumber gram;

            if (name == null || name.Equals(""))
            {
                sendMessage("음식 이름을 입력해 주세요");
                return;
            }
            else if (name.Length > 50)
            {
                sendMessage("음식 이름은 50글자 이상 입력할 수 없습니다");
                return;
            }

            if (category == null)
            {
                sendMessage("카테고리를 선택해 주세요");
                return;
            }

            try
            {
                gram = OracleNumber.Parse(gramTxt.Texts);
            }
            catch (Exception ex)
            {
                sendMessage("그램에 올바른 값을 입력해주세요.");
                return;
            }

            fm.addEntity(name, category, gram);
            sendMessage("데이터가 추가 되었습니다.");

            nameTxt.Texts = String.Empty;
            categoryInputCustomComboBox.Texts = String.Empty;
            categoryCustomComboBox.SelectedIndex = 0;
            gramTxt.Texts = String.Empty;

            UpdateGridView();
;        }

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
