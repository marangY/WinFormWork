namespace Exercise.Froms
{
    partial class FormFood
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.iconPictureBox3 = new FontAwesome.Sharp.IconPictureBox();
            this.categoryInputCustomComboBox = new Exercise.CustomControll.CustomComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.gramTxt = new Exercise.CustomControll.CustomTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.nameTxt = new Exercise.CustomControll.CustomTextBox();
            this.EFDataGridView = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NAME = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CATEGORY = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CALORIE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.categoryCustomComboBox = new Exercise.CustomControll.CustomComboBox();
            this.searchRoundButton = new Exercise.CustomControll.RoundButton();
            this.searchCustomTextBox = new Exercise.CustomControll.CustomTextBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.EFDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.iconPictureBox3);
            this.groupBox1.Controls.Add(this.categoryInputCustomComboBox);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.gramTxt);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.nameTxt);
            this.groupBox1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(62, 485);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(1080, 157);
            this.groupBox1.TabIndex = 17;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Append";
            // 
            // iconPictureBox3
            // 
            this.iconPictureBox3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(25)))), ((int)(((byte)(62)))));
            this.iconPictureBox3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(138)))), ((int)(((byte)(114)))));
            this.iconPictureBox3.IconChar = FontAwesome.Sharp.IconChar.Plus;
            this.iconPictureBox3.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(138)))), ((int)(((byte)(114)))));
            this.iconPictureBox3.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconPictureBox3.IconSize = 70;
            this.iconPictureBox3.Location = new System.Drawing.Point(998, 49);
            this.iconPictureBox3.Margin = new System.Windows.Forms.Padding(2, 2, 10, 2);
            this.iconPictureBox3.Name = "iconPictureBox3";
            this.iconPictureBox3.Size = new System.Drawing.Size(70, 70);
            this.iconPictureBox3.TabIndex = 21;
            this.iconPictureBox3.TabStop = false;
            this.iconPictureBox3.Click += new System.EventHandler(this.iconPictureBox3_Click);
            // 
            // categoryInputCustomComboBox
            // 
            this.categoryInputCustomComboBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.categoryInputCustomComboBox.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(138)))), ((int)(((byte)(114)))));
            this.categoryInputCustomComboBox.BorderSize = 3;
            this.categoryInputCustomComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown;
            this.categoryInputCustomComboBox.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Bold);
            this.categoryInputCustomComboBox.ForeColor = System.Drawing.Color.White;
            this.categoryInputCustomComboBox.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(138)))), ((int)(((byte)(114)))));
            this.categoryInputCustomComboBox.Items.AddRange(new object[] {
            "곡류",
            "채소",
            "과일",
            "유제품",
            "육류",
            "해산물",
            "주류",
            "음료",
            "요리",
            "기타"});
            this.categoryInputCustomComboBox.ListBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.categoryInputCustomComboBox.ListTextColor = System.Drawing.Color.White;
            this.categoryInputCustomComboBox.Location = new System.Drawing.Point(476, 60);
            this.categoryInputCustomComboBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.categoryInputCustomComboBox.MinimumSize = new System.Drawing.Size(200, 30);
            this.categoryInputCustomComboBox.Name = "categoryInputCustomComboBox";
            this.categoryInputCustomComboBox.Padding = new System.Windows.Forms.Padding(2);
            this.categoryInputCustomComboBox.Size = new System.Drawing.Size(200, 48);
            this.categoryInputCustomComboBox.TabIndex = 13;
            this.categoryInputCustomComboBox.Texts = "";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(332, 72);
            this.label3.Margin = new System.Windows.Forms.Padding(5, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(137, 33);
            this.label3.TabIndex = 17;
            this.label3.Text = "Category";
            // 
            // gramTxt
            // 
            this.gramTxt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.gramTxt.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(138)))), ((int)(((byte)(114)))));
            this.gramTxt.BorderFocusColor = System.Drawing.Color.HotPink;
            this.gramTxt.BorderRadius = 0;
            this.gramTxt.BorderSize = 3;
            this.gramTxt.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.gramTxt.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.gramTxt.Location = new System.Drawing.Point(778, 60);
            this.gramTxt.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.gramTxt.Multiline = false;
            this.gramTxt.Name = "gramTxt";
            this.gramTxt.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.gramTxt.PasswordChar = false;
            this.gramTxt.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.gramTxt.PlaceholderText = "";
            this.gramTxt.Size = new System.Drawing.Size(206, 47);
            this.gramTxt.TabIndex = 16;
            this.gramTxt.Texts = "";
            this.gramTxt.UnderlinedStyle = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(688, 72);
            this.label2.Margin = new System.Windows.Forms.Padding(20, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 33);
            this.label2.TabIndex = 15;
            this.label2.Text = "Gram";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(12, 72);
            this.label1.Margin = new System.Windows.Forms.Padding(20, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 33);
            this.label1.TabIndex = 14;
            this.label1.Text = "Name";
            // 
            // nameTxt
            // 
            this.nameTxt.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
            this.nameTxt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.nameTxt.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(138)))), ((int)(((byte)(114)))));
            this.nameTxt.BorderFocusColor = System.Drawing.Color.HotPink;
            this.nameTxt.BorderRadius = 0;
            this.nameTxt.BorderSize = 3;
            this.nameTxt.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.nameTxt.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.nameTxt.Location = new System.Drawing.Point(118, 58);
            this.nameTxt.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.nameTxt.Multiline = false;
            this.nameTxt.Name = "nameTxt";
            this.nameTxt.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.nameTxt.PasswordChar = false;
            this.nameTxt.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.nameTxt.PlaceholderText = "";
            this.nameTxt.Size = new System.Drawing.Size(206, 47);
            this.nameTxt.TabIndex = 13;
            this.nameTxt.Texts = "";
            this.nameTxt.UnderlinedStyle = false;
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
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(138)))), ((int)(((byte)(114)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(138)))), ((int)(((byte)(114)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.EFDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.EFDataGridView.ColumnHeadersHeight = 50;
            this.EFDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.NAME,
            this.CATEGORY,
            this.CALORIE});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.DarkBlue;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.EFDataGridView.DefaultCellStyle = dataGridViewCellStyle2;
            this.EFDataGridView.EnableHeadersVisualStyles = false;
            this.EFDataGridView.GridColor = System.Drawing.Color.White;
            this.EFDataGridView.Location = new System.Drawing.Point(62, 116);
            this.EFDataGridView.Margin = new System.Windows.Forms.Padding(101, 0, 101, 30);
            this.EFDataGridView.MultiSelect = false;
            this.EFDataGridView.Name = "EFDataGridView";
            this.EFDataGridView.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.DarkBlue;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.EFDataGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.EFDataGridView.RowHeadersVisible = false;
            this.EFDataGridView.RowHeadersWidth = 82;
            this.EFDataGridView.RowTemplate.DividerHeight = 1;
            this.EFDataGridView.RowTemplate.Height = 37;
            this.EFDataGridView.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.EFDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.EFDataGridView.Size = new System.Drawing.Size(1080, 346);
            this.EFDataGridView.TabIndex = 13;
            // 
            // id
            // 
            this.id.DataPropertyName = "FOOD_ID";
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
            this.NAME.HeaderText = "음식";
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
            this.CALORIE.HeaderText = "그램당 칼로리(kal)";
            this.CALORIE.MinimumWidth = 10;
            this.CALORIE.Name = "CALORIE";
            this.CALORIE.ReadOnly = true;
            // 
            // categoryCustomComboBox
            // 
            this.categoryCustomComboBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.categoryCustomComboBox.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(138)))), ((int)(((byte)(114)))));
            this.categoryCustomComboBox.BorderSize = 3;
            this.categoryCustomComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown;
            this.categoryCustomComboBox.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Bold);
            this.categoryCustomComboBox.ForeColor = System.Drawing.Color.White;
            this.categoryCustomComboBox.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(138)))), ((int)(((byte)(114)))));
            this.categoryCustomComboBox.Items.AddRange(new object[] {
            "전체",
            "곡류",
            "채소",
            "과일",
            "유제품",
            "육류",
            "해산물",
            "주류",
            "음료",
            "요리",
            "기타"});
            this.categoryCustomComboBox.ListBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.categoryCustomComboBox.ListTextColor = System.Drawing.Color.White;
            this.categoryCustomComboBox.Location = new System.Drawing.Point(942, 40);
            this.categoryCustomComboBox.Margin = new System.Windows.Forms.Padding(30, 30, 2, 2);
            this.categoryCustomComboBox.MinimumSize = new System.Drawing.Size(200, 30);
            this.categoryCustomComboBox.Name = "categoryCustomComboBox";
            this.categoryCustomComboBox.Padding = new System.Windows.Forms.Padding(2);
            this.categoryCustomComboBox.Size = new System.Drawing.Size(200, 48);
            this.categoryCustomComboBox.TabIndex = 16;
            this.categoryCustomComboBox.Texts = "";
            this.categoryCustomComboBox.OnSelectedIndexChanged += new System.EventHandler(this.categoryCustomComboBox_OnSelectedIndexChanged);
            // 
            // searchRoundButton
            // 
            this.searchRoundButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(138)))), ((int)(((byte)(114)))));
            this.searchRoundButton.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(138)))), ((int)(((byte)(114)))));
            this.searchRoundButton.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.searchRoundButton.BorderRadius = 20;
            this.searchRoundButton.BorderSize = 0;
            this.searchRoundButton.FlatAppearance.BorderSize = 0;
            this.searchRoundButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.searchRoundButton.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchRoundButton.ForeColor = System.Drawing.Color.White;
            this.searchRoundButton.Location = new System.Drawing.Point(290, 47);
            this.searchRoundButton.Margin = new System.Windows.Forms.Padding(2);
            this.searchRoundButton.Name = "searchRoundButton";
            this.searchRoundButton.Size = new System.Drawing.Size(105, 40);
            this.searchRoundButton.TabIndex = 15;
            this.searchRoundButton.Text = "Search";
            this.searchRoundButton.TextColor = System.Drawing.Color.White;
            this.searchRoundButton.UseVisualStyleBackColor = false;
            this.searchRoundButton.Click += new System.EventHandler(this.searchRoundButton_Click);
            // 
            // searchCustomTextBox
            // 
            this.searchCustomTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.searchCustomTextBox.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(138)))), ((int)(((byte)(114)))));
            this.searchCustomTextBox.BorderFocusColor = System.Drawing.Color.HotPink;
            this.searchCustomTextBox.BorderRadius = 0;
            this.searchCustomTextBox.BorderSize = 3;
            this.searchCustomTextBox.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Bold);
            this.searchCustomTextBox.ForeColor = System.Drawing.Color.White;
            this.searchCustomTextBox.Location = new System.Drawing.Point(62, 40);
            this.searchCustomTextBox.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.searchCustomTextBox.Multiline = false;
            this.searchCustomTextBox.Name = "searchCustomTextBox";
            this.searchCustomTextBox.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.searchCustomTextBox.PasswordChar = false;
            this.searchCustomTextBox.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.searchCustomTextBox.PlaceholderText = "";
            this.searchCustomTextBox.Size = new System.Drawing.Size(206, 47);
            this.searchCustomTextBox.TabIndex = 14;
            this.searchCustomTextBox.Texts = "";
            this.searchCustomTextBox.UnderlinedStyle = false;
            // 
            // FormFood
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.ClientSize = new System.Drawing.Size(1202, 674);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.categoryCustomComboBox);
            this.Controls.Add(this.searchRoundButton);
            this.Controls.Add(this.searchCustomTextBox);
            this.Controls.Add(this.EFDataGridView);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FormFood";
            this.ShowInTaskbar = false;
            this.Text = "FormFood";
            this.Load += new System.EventHandler(this.FormFood_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.EFDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private CustomControll.CustomComboBox categoryInputCustomComboBox;
        private System.Windows.Forms.Label label3;
        private CustomControll.CustomTextBox gramTxt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private CustomControll.CustomTextBox nameTxt;
        private CustomControll.CustomComboBox categoryCustomComboBox;
        private CustomControll.RoundButton searchRoundButton;
        private CustomControll.CustomTextBox searchCustomTextBox;
        private System.Windows.Forms.DataGridView EFDataGridView;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox3;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn NAME;
        private System.Windows.Forms.DataGridViewTextBoxColumn CATEGORY;
        private System.Windows.Forms.DataGridViewTextBoxColumn CALORIE;
    }
}