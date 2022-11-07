using Exercise.ExerciseClass.DataBase;
using Exercise.ExerciseClass.User;
using Exercise.Froms.SubForm;
using FontAwesome.Sharp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exercise.Froms
{
    public partial class FormLogin : Form
    {
        //필드
        TextBox[] txtList;
        private string IdPlaceholder = "  ID";
        private string PwPlaceholder = "  Password";

        public FormLogin()
        {
            InitializeComponent();

            //ID, Password TextBox Placeholder 설정
            txtList = new TextBox[] { txtID, txtPW };
            foreach (var txt in txtList)
            {
                //처음 공백 Placeholder 지정
                txt.ForeColor = Color.White;
                if (txt == txtID) txt.Text = IdPlaceholder;
                else if (txt == txtPW) txt.Text = PwPlaceholder;

                //텍스트박스 커서 Focus 여부에 따라 이벤트 지정
                txt.GotFocus += RemovePlaceholder;
                txt.LostFocus += SetPlaceholder;
            }
        }

        //플레이스 홀더 설정/지우기
        private void RemovePlaceholder(object sender, EventArgs e)
        {
            TextBox txt = (TextBox)sender;
            if (txt.Text == IdPlaceholder | txt.Text == PwPlaceholder)
            { //텍스트박스 내용이 사용자가 입력한 값이 아닌 Placeholder일 경우에만, 커서 포커스일때 빈칸으로 만들기
                txt.ForeColor = Color.White; //사용자 입력 진한 글씨
                txt.Text = string.Empty;
                if (txt == txtPW) txtPW.PasswordChar = '*';
            }
        }

        private void SetPlaceholder(object sender, EventArgs e)
        {
            TextBox txt = (TextBox)sender;
            if (string.IsNullOrWhiteSpace(txt.Text))
            {
                //사용자 입력값이 하나도 없는 경우에 포커스 잃으면 Placeholder 적용해주기
                txt.ForeColor = Color.White; //Placeholder 흐린 글씨
                if (txt == txtID) txt.Text = IdPlaceholder;
                else if (txt == txtPW) { txt.Text = PwPlaceholder; txtPW.PasswordChar = default; }
            }
        }
        //

        //회원 가입 이동
        private void join_Click(object sender, EventArgs e)
        {
            FormMain Parent = (FormMain)Owner;
            Parent.idTitleChildFrom.Text = "JoinRequset";
            Close();
        }
        
        //로그인 버튼
        private void loginBtn_Click(object sender, EventArgs e)
        {
            login();
        }
        
        //로그인 기능
        private void login()
        {
            if (txtID.Text.Length > 20)
            {
                sendMessage("아이디는 20 글자 이상 입력할 수 없습니다.");

                return;
            }
            else if (txtID.Text.Equals(IdPlaceholder))
            {
                sendMessage("아이디를 입력해 주세요.");

                return;
            }

            if (txtPW.Text.Length > 20)
            {
                sendMessage("비밀번호는 20 글자 이상 입력할 수 없습니다.");

                return;
            }
            else if (txtPW.Text.Equals(PwPlaceholder))
            {
                sendMessage("비밀번호를 입력해 주세요.");

                return;
            }

            LoginService login = new LoginService(txtID.Text, txtPW.Text);

            if (!login.existenceId())
            {
                sendMessage("해당 아이디가 존재하지 않습니다.");

                return;
            }
            else if (!login.checkingpassword())
            {
                sendMessage("비밀 번호가 일치하지 않습니다.");

                return;
            }

            login.authorization();

            FormMain Parent = (FormMain)Owner;
            Parent.idTitleChildFrom.Text = Config.UserName;
            Parent.idTitleChildFrom.ForeColor = Color.DeepSkyBlue;
            Parent.iconCurrentChildForm.IconChar = IconChar.User;
            Close();
        }

        //메세지 박스
        public void sendMessage(string str)
        {
            MessageForm message = new MessageForm(str);
            message.StartPosition = FormStartPosition.CenterParent;
            SystemSounds.Beep.Play();
            message.ShowDialog();
        }

        //엔터 단축키
        private void txtID_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                e.Handled = true;
                txtPW.Focus();
            }
        }

        private void txtPW_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                e.Handled = true;
                login();
            }
        }
        //
    }
}
