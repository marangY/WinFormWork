﻿using Exercise.ExerciseClass.Exercise;
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
    public partial class FormExercise : Form
    {
        ExerciseManagement em = new ExerciseManagement();
        string search;
        string categorys = "전체";

        public FormExercise()
        {
            InitializeComponent();
            EFDataGridView.DataSource = em.returnAllList();
            EFDataGridView.MouseWheel += new MouseEventHandler(mousewheel);
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
            if(searchCustomTextBox.Texts == null || searchCustomTextBox.Texts.Equals(""))
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
            OracleNumber time;

            if (name == null || name.Equals(""))
            {
                sendMessage("운동 이름을 입력해 주세요");
                return;
            }
            else if(name.Length > 50)
            {
                sendMessage("운동 이름은 50글자 이상 입력할 수 없습니다");
                return;
            }

            if (category == null)
            {
                sendMessage("카테고리를 선택해 주세요");
                return;
            }

            try
            {
                time = OracleNumber.Parse(timeTxt.Texts);
            }
            catch (Exception ex)
            {
                sendMessage("시간에 올바른 값을 입력해주세요.");
                return;
            }

            em.addEntity(name, category, time);
            sendMessage("데이터가 추가 되었습니다.");

            nameTxt.Texts = String.Empty;
            categoryInputCustomComboBox.Texts = String.Empty;
            categoryCustomComboBox.SelectedIndex = -1;
            timeTxt.Texts = String.Empty;

            searchCustomTextBox.Texts = name;

            UpdateGridView();
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
