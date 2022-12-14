namespace Exercise.Froms
{
    partial class FormExercise
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.EFDataGridView = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NAME = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CATEGORY = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CALORIE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.iconPictureBox3 = new FontAwesome.Sharp.IconPictureBox();
            this.categoryInputCustomComboBox = new Exercise.CustomControll.CustomComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.timeTxt = new Exercise.CustomControll.CustomTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.nameTxt = new Exercise.CustomControll.CustomTextBox();
            this.categoryCustomComboBox = new Exercise.CustomControll.CustomComboBox();
            this.searchRoundButton = new Exercise.CustomControll.RoundButton();
            this.searchCustomTextBox = new Exercise.CustomControll.CustomTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.EFDataGridView)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // EFDataGridView
            // 
            this.EFDataGridView.AllowUserToAddRows = false;
            this.EFDataGridView.AllowUserToDeleteRows = false;
            this.EFDataGridView.AllowUserToResizeColumns = false;
            this.EFDataGridView.AllowUserToResizeRows = false;
            this.EFDataGridView.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.EFDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.EFDataGridView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.EFDataGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(77)))), ((int)(((byte)(221)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(77)))), ((int)(((byte)(221)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.EFDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.EFDataGridView.ColumnHeadersHeight = 50;
            this.EFDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.NAME,
            this.CATEGORY,
            this.CALORIE});
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.DarkBlue;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.EFDataGridView.DefaultCellStyle = dataGridViewCellStyle5;
            this.EFDataGridView.EnableHeadersVisualStyles = false;
            this.EFDataGridView.GridColor = System.Drawing.Color.White;
            this.EFDataGridView.Location = new System.Drawing.Point(50, 97);
            this.EFDataGridView.Margin = new System.Windows.Forms.Padding(81, 0, 81, 25);
            this.EFDataGridView.MultiSelect = false;
            this.EFDataGridView.Name = "EFDataGridView";
            this.EFDataGridView.ReadOnly = true;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.DarkBlue;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.EFDataGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.EFDataGridView.RowHeadersVisible = false;
            this.EFDataGridView.RowHeadersWidth = 82;
            this.EFDataGridView.RowTemplate.DividerHeight = 1;
            this.EFDataGridView.RowTemplate.Height = 37;
            this.EFDataGridView.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.EFDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.EFDataGridView.Size = new System.Drawing.Size(864, 288);
            this.EFDataGridView.TabIndex = 4;
            // 
            // id
            // 
            this.id.DataPropertyName = "EXERCISE_ID";
            this.id.HeaderText = "id";
            this.id.MinimumWidth = 6;
            this.id.Name = "id";
            this.id.ReadOnly = true;
            this.id.Visible = false;
            this.id.Width = 125;
            // 
            // NAME
            // 
            this.NAME.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.NAME.DataPropertyName = "NAME";
            this.NAME.FillWeight = 120F;
            this.NAME.HeaderText = "운동";
            this.NAME.MinimumWidth = 10;
            this.NAME.Name = "NAME";
            this.NAME.ReadOnly = true;
            // 
            // CATEGORY
            // 
            this.CATEGORY.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.CATEGORY.DataPropertyName = "CATEGORY";
            this.CATEGORY.FillWeight = 80F;
            this.CATEGORY.HeaderText = "카테고리";
            this.CATEGORY.MinimumWidth = 10;
            this.CATEGORY.Name = "CATEGORY";
            this.CATEGORY.ReadOnly = true;
            // 
            // CALORIE
            // 
            this.CALORIE.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.CALORIE.DataPropertyName = "CALORIE";
            this.CALORIE.FillWeight = 80F;
            this.CALORIE.HeaderText = "분당 칼로리(kal)";
            this.CALORIE.MinimumWidth = 10;
            this.CALORIE.Name = "CALORIE";
            this.CALORIE.ReadOnly = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.iconPictureBox3);
            this.groupBox1.Controls.Add(this.categoryInputCustomComboBox);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.timeTxt);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.nameTxt);
            this.groupBox1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(50, 404);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(864, 131);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Append";
            // 
            // iconPictureBox3
            // 
            this.iconPictureBox3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(25)))), ((int)(((byte)(62)))));
            this.iconPictureBox3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(77)))), ((int)(((byte)(221)))));
            this.iconPictureBox3.IconChar = FontAwesome.Sharp.IconChar.Plus;
            this.iconPictureBox3.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(77)))), ((int)(((byte)(221)))));
            this.iconPictureBox3.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconPictureBox3.IconSize = 56;
            this.iconPictureBox3.Location = new System.Drawing.Point(798, 41);
            this.iconPictureBox3.Margin = new System.Windows.Forms.Padding(2, 2, 8, 2);
            this.iconPictureBox3.Name = "iconPictureBox3";
            this.iconPictureBox3.Size = new System.Drawing.Size(56, 58);
            this.iconPictureBox3.TabIndex = 20;
            this.iconPictureBox3.TabStop = false;
            this.iconPictureBox3.Click += new System.EventHandler(this.iconPictureBox3_Click);
            // 
            // categoryInputCustomComboBox
            // 
            this.categoryInputCustomComboBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.categoryInputCustomComboBox.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(77)))), ((int)(((byte)(221)))));
            this.categoryInputCustomComboBox.BorderSize = 3;
            this.categoryInputCustomComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown;
            this.categoryInputCustomComboBox.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Bold);
            this.categoryInputCustomComboBox.ForeColor = System.Drawing.Color.White;
            this.categoryInputCustomComboBox.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(77)))), ((int)(((byte)(221)))));
            this.categoryInputCustomComboBox.Items.AddRange(new object[] {
            "유산소",
            "구기종목",
            "무술",
            "맨몸운동",
            "기타"});
            this.categoryInputCustomComboBox.ListBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.categoryInputCustomComboBox.ListTextColor = System.Drawing.Color.White;
            this.categoryInputCustomComboBox.Location = new System.Drawing.Point(381, 50);
            this.categoryInputCustomComboBox.MinimumSize = new System.Drawing.Size(160, 25);
            this.categoryInputCustomComboBox.Name = "categoryInputCustomComboBox";
            this.categoryInputCustomComboBox.Padding = new System.Windows.Forms.Padding(2);
            this.categoryInputCustomComboBox.Size = new System.Drawing.Size(160, 40);
            this.categoryInputCustomComboBox.TabIndex = 13;
            this.categoryInputCustomComboBox.Texts = "";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(260, 53);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(116, 29);
            this.label3.TabIndex = 17;
            this.label3.Text = "Category";
            // 
            // timeTxt
            // 
            this.timeTxt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.timeTxt.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(77)))), ((int)(((byte)(221)))));
            this.timeTxt.BorderFocusColor = System.Drawing.Color.HotPink;
            this.timeTxt.BorderRadius = 0;
            this.timeTxt.BorderSize = 3;
            this.timeTxt.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.timeTxt.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.timeTxt.Location = new System.Drawing.Point(622, 50);
            this.timeTxt.Margin = new System.Windows.Forms.Padding(4);
            this.timeTxt.Multiline = false;
            this.timeTxt.Name = "timeTxt";
            this.timeTxt.Padding = new System.Windows.Forms.Padding(8, 6, 8, 6);
            this.timeTxt.PasswordChar = false;
            this.timeTxt.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.timeTxt.PlaceholderText = "";
            this.timeTxt.Size = new System.Drawing.Size(165, 45);
            this.timeTxt.TabIndex = 16;
            this.timeTxt.Texts = "";
            this.timeTxt.UnderlinedStyle = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(550, 53);
            this.label2.Margin = new System.Windows.Forms.Padding(16, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 29);
            this.label2.TabIndex = 15;
            this.label2.Text = "Time";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(11, 53);
            this.label1.Margin = new System.Windows.Forms.Padding(16, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 29);
            this.label1.TabIndex = 14;
            this.label1.Text = "Name";
            // 
            // nameTxt
            // 
            this.nameTxt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.nameTxt.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(77)))), ((int)(((byte)(221)))));
            this.nameTxt.BorderFocusColor = System.Drawing.Color.HotPink;
            this.nameTxt.BorderRadius = 0;
            this.nameTxt.BorderSize = 3;
            this.nameTxt.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.nameTxt.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.nameTxt.Location = new System.Drawing.Point(94, 48);
            this.nameTxt.Margin = new System.Windows.Forms.Padding(4);
            this.nameTxt.Multiline = false;
            this.nameTxt.Name = "nameTxt";
            this.nameTxt.Padding = new System.Windows.Forms.Padding(8, 6, 8, 6);
            this.nameTxt.PasswordChar = false;
            this.nameTxt.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.nameTxt.PlaceholderText = "";
            this.nameTxt.Size = new System.Drawing.Size(165, 45);
            this.nameTxt.TabIndex = 13;
            this.nameTxt.Texts = "";
            this.nameTxt.UnderlinedStyle = false;
            // 
            // categoryCustomComboBox
            // 
            this.categoryCustomComboBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.categoryCustomComboBox.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(77)))), ((int)(((byte)(221)))));
            this.categoryCustomComboBox.BorderSize = 3;
            this.categoryCustomComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown;
            this.categoryCustomComboBox.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Bold);
            this.categoryCustomComboBox.ForeColor = System.Drawing.Color.White;
            this.categoryCustomComboBox.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(77)))), ((int)(((byte)(221)))));
            this.categoryCustomComboBox.Items.AddRange(new object[] {
            "전체",
            "유산소",
            "구기종목",
            "무술",
            "맨몸운동",
            "기타"});
            this.categoryCustomComboBox.ListBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.categoryCustomComboBox.ListTextColor = System.Drawing.Color.White;
            this.categoryCustomComboBox.Location = new System.Drawing.Point(754, 33);
            this.categoryCustomComboBox.Margin = new System.Windows.Forms.Padding(24, 25, 2, 2);
            this.categoryCustomComboBox.MinimumSize = new System.Drawing.Size(160, 25);
            this.categoryCustomComboBox.Name = "categoryCustomComboBox";
            this.categoryCustomComboBox.Padding = new System.Windows.Forms.Padding(2);
            this.categoryCustomComboBox.Size = new System.Drawing.Size(160, 40);
            this.categoryCustomComboBox.TabIndex = 11;
            this.categoryCustomComboBox.Texts = "";
            this.categoryCustomComboBox.OnSelectedIndexChanged += new System.EventHandler(this.categoryCustomComboBox_OnSelectedIndexChanged);
            // 
            // searchRoundButton
            // 
            this.searchRoundButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(77)))), ((int)(((byte)(221)))));
            this.searchRoundButton.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(77)))), ((int)(((byte)(221)))));
            this.searchRoundButton.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.searchRoundButton.BorderRadius = 17;
            this.searchRoundButton.BorderSize = 0;
            this.searchRoundButton.FlatAppearance.BorderSize = 0;
            this.searchRoundButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.searchRoundButton.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchRoundButton.ForeColor = System.Drawing.Color.White;
            this.searchRoundButton.Location = new System.Drawing.Point(232, 39);
            this.searchRoundButton.Margin = new System.Windows.Forms.Padding(2);
            this.searchRoundButton.Name = "searchRoundButton";
            this.searchRoundButton.Size = new System.Drawing.Size(84, 33);
            this.searchRoundButton.TabIndex = 10;
            this.searchRoundButton.Text = "Search";
            this.searchRoundButton.TextColor = System.Drawing.Color.White;
            this.searchRoundButton.UseVisualStyleBackColor = false;
            this.searchRoundButton.Click += new System.EventHandler(this.searchRoundButton_Click);
            // 
            // searchCustomTextBox
            // 
            this.searchCustomTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.searchCustomTextBox.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(77)))), ((int)(((byte)(221)))));
            this.searchCustomTextBox.BorderFocusColor = System.Drawing.Color.HotPink;
            this.searchCustomTextBox.BorderRadius = 0;
            this.searchCustomTextBox.BorderSize = 3;
            this.searchCustomTextBox.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Bold);
            this.searchCustomTextBox.ForeColor = System.Drawing.Color.White;
            this.searchCustomTextBox.Location = new System.Drawing.Point(50, 33);
            this.searchCustomTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.searchCustomTextBox.Multiline = false;
            this.searchCustomTextBox.Name = "searchCustomTextBox";
            this.searchCustomTextBox.Padding = new System.Windows.Forms.Padding(8, 6, 8, 6);
            this.searchCustomTextBox.PasswordChar = false;
            this.searchCustomTextBox.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.searchCustomTextBox.PlaceholderText = "";
            this.searchCustomTextBox.Size = new System.Drawing.Size(165, 45);
            this.searchCustomTextBox.TabIndex = 9;
            this.searchCustomTextBox.Texts = "";
            this.searchCustomTextBox.UnderlinedStyle = false;
            // 
            // FormExercise
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.ClientSize = new System.Drawing.Size(962, 562);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.categoryCustomComboBox);
            this.Controls.Add(this.searchRoundButton);
            this.Controls.Add(this.searchCustomTextBox);
            this.Controls.Add(this.EFDataGridView);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FormExercise";
            this.Text = "FormExercise";
            this.Load += new System.EventHandler(this.FormExercise_Load);
            ((System.ComponentModel.ISupportInitialize)(this.EFDataGridView)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView EFDataGridView;
        private CustomControll.CustomTextBox searchCustomTextBox;
        private CustomControll.RoundButton searchRoundButton;
        private CustomControll.CustomComboBox categoryCustomComboBox;
        private System.Windows.Forms.GroupBox groupBox1;
        private CustomControll.CustomTextBox nameTxt;
        private CustomControll.CustomComboBox categoryInputCustomComboBox;
        private System.Windows.Forms.Label label3;
        private CustomControll.CustomTextBox timeTxt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox3;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn NAME;
        private System.Windows.Forms.DataGridViewTextBoxColumn CATEGORY;
        private System.Windows.Forms.DataGridViewTextBoxColumn CALORIE;
    }
}