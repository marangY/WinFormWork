using Exercise.ExerciseClass.User;
using Exercise.Froms.SubForm;
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
    public partial class FormJoin : Form
    {
        //필드
        TextBox[] txtList;
        private String IdPlaceholder = "  ID";
        private String PwPlaceholder = "  Password";
        private String ADPlaceholder = "  Adress";

        public FormJoin()
        {
            InitializeComponent();

            //ID, Password TextBox Placeholder 설정
            txtList = new TextBox[] { txtID, txtPW, txtAD };
            foreach (var txt in txtList)
            {
                //처음 공백 Placeholder 지정
                txt.ForeColor = Color.White;
                if (txt == txtID) txt.Text = IdPlaceholder;
                else if (txt == txtPW) txt.Text = PwPlaceholder;
                else if (txt == txtAD) txt.Text = ADPlaceholder;

                //텍스트박스 커서 Focus 여부에 따라 이벤트 지정
                txt.GotFocus += RemovePlaceholder;
                txt.LostFocus += SetPlaceholder;
            }
        }

        //플레이스 홀더 설정/지우기
        private void RemovePlaceholder(object sender, EventArgs e)
        {
            TextBox txt = (TextBox)sender;
            if (txt.Text == IdPlaceholder | txt.Text == PwPlaceholder | txt.Text == ADPlaceholder)
            {
                txt.ForeColor = Color.White; //사용자 입력 진한 글씨
                txt.Text = string.Empty;
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
                else if (txt == txtAD) txt.Text = ADPlaceholder;
                else if (txt == txtPW) { txt.Text = PwPlaceholder; txtPW.PasswordChar = default; }
            }
        }
        //

        //로그인으로 돌아가기
        private void back_Click(object sender, EventArgs e)
        {
            FormMain Parent = (FormMain)Owner;
            Parent.idTitleChildFrom.Text = "LoginRequset";
            Close();
        }

        //회원가입 버튼
        private void joinBtn_Click(object sender, EventArgs e)
        {
            join();
        }

        // 회원 가입 기능
        private void join()
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

            if (txtAD.Text.Length > 100)
            {
                sendMessage("주소는 100 글자 이상 입력할 수 없습니다.");

                return;
            }
            else if (txtAD.Text.Length.Equals(ADPlaceholder))
            {
                sendMessage("주소를 입력해 주세요.");

                return;
            }

            JoinService join = new JoinService(txtID.Text, txtPW.Text, txtAD.Text);

            if (join.existenceId())
            {
                sendMessage("사용 할 수 없는 아이디 입니다.");

                return;
            }

            join.authorization();

            FormMain Parent = (FormMain)Owner;
            Parent.idTitleChildFrom.Text = "LoginRequset";
            Close();
        }

        //메세지 박스
        public void sendMessage(string str)
        {
            MessageForm message = new MessageForm(str);
            message.StartPosition = FormStartPosition.Manual;
            SystemSounds.Beep.Play();
            message.ShowDialog();
        }

        //엔터 단축키
        private void txtID_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char) Keys.Enter)
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
                txtAD.Focus();
            }
        }

        private void txtAD_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                e.Handled = true;
                join();
            }
        }
        //
    }
}
