namespace Exercise.Froms
{
    partial class FormCalculator
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
            this.label1 = new System.Windows.Forms.Label();
            this.EFDataGridView = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.category = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.calorie = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.inputLabel = new System.Windows.Forms.Label();
            this.totalCalorie = new System.Windows.Forms.Label();
            this.totalKal = new System.Windows.Forms.Label();
            this.kindTxt = new System.Windows.Forms.Label();
            this.inputKind = new System.Windows.Forms.Label();
            this.saveToday = new Exercise.CustomControll.RoundButton();
            this.inputBox = new Exercise.CustomControll.CustomTextBox();
            this.searchCustomTextBox = new Exercise.CustomControll.CustomTextBox();
            this.categoryCustomComboBox = new Exercise.CustomControll.CustomComboBox();
            this.roundButton1 = new Exercise.CustomControll.RoundButton();
            this.selectCustomComboBox = new Exercise.CustomControll.CustomComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.EFDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(161)))), ((int)(((byte)(251)))));
            this.label1.Location = new System.Drawing.Point(228, 48);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(175, 37);
            this.label1.TabIndex = 1;
            this.label1.Text = "Calculater";
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
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(161)))), ((int)(((byte)(251)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(161)))), ((int)(((byte)(251)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.EFDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.EFDataGridView.ColumnHeadersHeight = 50;
            this.EFDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.name,
            this.category,
            this.calorie});
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
            this.EFDataGridView.Location = new System.Drawing.Point(435, 102);
            this.EFDataGridView.Margin = new System.Windows.Forms.Padding(2, 25, 24, 2);
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
            this.EFDataGridView.Size = new System.Drawing.Size(496, 428);
            this.EFDataGridView.TabIndex = 3;
            this.EFDataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.EFDataGridView_CellClick);
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
            // name
            // 
            this.name.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.name.DataPropertyName = "NAME";
            this.name.FillWeight = 80F;
            this.name.HeaderText = "운동";
            this.name.MinimumWidth = 10;
            this.name.Name = "name";
            this.name.ReadOnly = true;
            // 
            // category
            // 
            this.category.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.category.DataPropertyName = "CATEGORY";
            this.category.FillWeight = 80F;
            this.category.HeaderText = "카테고리";
            this.category.MinimumWidth = 10;
            this.category.Name = "category";
            this.category.ReadOnly = true;
            // 
            // calorie
            // 
            this.calorie.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.calorie.DataPropertyName = "CALORIE";
            this.calorie.FillWeight = 120F;
            this.calorie.HeaderText = "분당 칼로리(kal)";
            this.calorie.MinimumWidth = 10;
            this.calorie.Name = "calorie";
            this.calorie.ReadOnly = true;
            // 
            // inputLabel
            // 
            this.inputLabel.AutoSize = true;
            this.inputLabel.Font = new System.Drawing.Font("Arial", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inputLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(161)))), ((int)(((byte)(251)))));
            this.inputLabel.Location = new System.Drawing.Point(40, 240);
            this.inputLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.inputLabel.Name = "inputLabel";
            this.inputLabel.Size = new System.Drawing.Size(180, 37);
            this.inputLabel.TabIndex = 9;
            this.inputLabel.Text = "Time (min)";
            this.inputLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // totalCalorie
            // 
            this.totalCalorie.AutoSize = true;
            this.totalCalorie.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold);
            this.totalCalorie.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(161)))), ((int)(((byte)(251)))));
            this.totalCalorie.Location = new System.Drawing.Point(40, 352);
            this.totalCalorie.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.totalCalorie.Name = "totalCalorie";
            this.totalCalorie.Size = new System.Drawing.Size(185, 33);
            this.totalCalorie.TabIndex = 11;
            this.totalCalorie.Text = "Total Calorie";
            // 
            // totalKal
            // 
            this.totalKal.AutoSize = true;
            this.totalKal.Font = new System.Drawing.Font("Arial", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalKal.ForeColor = System.Drawing.Color.White;
            this.totalKal.Location = new System.Drawing.Point(228, 352);
            this.totalKal.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.totalKal.Name = "totalKal";
            this.totalKal.Size = new System.Drawing.Size(90, 37);
            this.totalKal.TabIndex = 12;
            this.totalKal.Text = "0 kal";
            this.totalKal.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // kindTxt
            // 
            this.kindTxt.AutoSize = true;
            this.kindTxt.Font = new System.Drawing.Font("Arial", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kindTxt.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(161)))), ((int)(((byte)(251)))));
            this.kindTxt.Location = new System.Drawing.Point(40, 142);
            this.kindTxt.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.kindTxt.Name = "kindTxt";
            this.kindTxt.Size = new System.Drawing.Size(151, 37);
            this.kindTxt.TabIndex = 14;
            this.kindTxt.Text = "Exercise";
            this.kindTxt.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // inputKind
            // 
            this.inputKind.AutoSize = true;
            this.inputKind.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold);
            this.inputKind.ForeColor = System.Drawing.Color.White;
            this.inputKind.Location = new System.Drawing.Point(228, 142);
            this.inputKind.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.inputKind.Name = "inputKind";
            this.inputKind.Size = new System.Drawing.Size(73, 33);
            this.inputKind.TabIndex = 15;
            this.inputKind.Text = "kind";
            this.inputKind.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // saveToday
            // 
            this.saveToday.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(161)))), ((int)(((byte)(251)))));
            this.saveToday.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(161)))), ((int)(((byte)(251)))));
            this.saveToday.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.saveToday.BorderRadius = 20;
            this.saveToday.BorderSize = 0;
            this.saveToday.FlatAppearance.BorderSize = 0;
            this.saveToday.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.saveToday.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.saveToday.ForeColor = System.Drawing.Color.White;
            this.saveToday.Location = new System.Drawing.Point(31, 462);
            this.saveToday.Margin = new System.Windows.Forms.Padding(2);
            this.saveToday.Name = "saveToday";
            this.saveToday.Size = new System.Drawing.Size(152, 42);
            this.saveToday.TabIndex = 13;
            this.saveToday.Text = "Save Today";
            this.saveToday.TextColor = System.Drawing.Color.White;
            this.saveToday.UseVisualStyleBackColor = false;
            this.saveToday.Click += new System.EventHandler(this.saveToday_Click);
            // 
            // inputBox
            // 
            this.inputBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.inputBox.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(161)))), ((int)(((byte)(251)))));
            this.inputBox.BorderFocusColor = System.Drawing.Color.HotPink;
            this.inputBox.BorderRadius = 0;
            this.inputBox.BorderSize = 3;
            this.inputBox.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Bold);
            this.inputBox.ForeColor = System.Drawing.Color.White;
            this.inputBox.Location = new System.Drawing.Point(234, 240);
            this.inputBox.Margin = new System.Windows.Forms.Padding(4);
            this.inputBox.Multiline = false;
            this.inputBox.Name = "inputBox";
            this.inputBox.Padding = new System.Windows.Forms.Padding(8, 6, 8, 6);
            this.inputBox.PasswordChar = false;
            this.inputBox.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.inputBox.PlaceholderText = "";
            this.inputBox.Size = new System.Drawing.Size(165, 45);
            this.inputBox.TabIndex = 10;
            this.inputBox.Texts = "";
            this.inputBox.UnderlinedStyle = false;
            // 
            // searchCustomTextBox
            // 
            this.searchCustomTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.searchCustomTextBox.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(161)))), ((int)(((byte)(251)))));
            this.searchCustomTextBox.BorderFocusColor = System.Drawing.Color.HotPink;
            this.searchCustomTextBox.BorderRadius = 0;
            this.searchCustomTextBox.BorderSize = 3;
            this.searchCustomTextBox.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Bold);
            this.searchCustomTextBox.ForeColor = System.Drawing.Color.White;
            this.searchCustomTextBox.Location = new System.Drawing.Point(435, 48);
            this.searchCustomTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.searchCustomTextBox.Multiline = false;
            this.searchCustomTextBox.Name = "searchCustomTextBox";
            this.searchCustomTextBox.Padding = new System.Windows.Forms.Padding(8, 6, 8, 6);
            this.searchCustomTextBox.PasswordChar = false;
            this.searchCustomTextBox.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.searchCustomTextBox.PlaceholderText = "";
            this.searchCustomTextBox.Size = new System.Drawing.Size(165, 45);
            this.searchCustomTextBox.TabIndex = 8;
            this.searchCustomTextBox.Texts = "";
            this.searchCustomTextBox.UnderlinedStyle = false;
            this.searchCustomTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.searchCustomTextBox_KeyPress);
            // 
            // categoryCustomComboBox
            // 
            this.categoryCustomComboBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.categoryCustomComboBox.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(161)))), ((int)(((byte)(251)))));
            this.categoryCustomComboBox.BorderSize = 3;
            this.categoryCustomComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown;
            this.categoryCustomComboBox.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Bold);
            this.categoryCustomComboBox.ForeColor = System.Drawing.Color.White;
            this.categoryCustomComboBox.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(161)))), ((int)(((byte)(251)))));
            this.categoryCustomComboBox.ListBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.categoryCustomComboBox.ListTextColor = System.Drawing.Color.White;
            this.categoryCustomComboBox.Location = new System.Drawing.Point(771, 48);
            this.categoryCustomComboBox.Margin = new System.Windows.Forms.Padding(24, 25, 2, 2);
            this.categoryCustomComboBox.MinimumSize = new System.Drawing.Size(160, 25);
            this.categoryCustomComboBox.Name = "categoryCustomComboBox";
            this.categoryCustomComboBox.Padding = new System.Windows.Forms.Padding(2);
            this.categoryCustomComboBox.Size = new System.Drawing.Size(160, 40);
            this.categoryCustomComboBox.TabIndex = 7;
            this.categoryCustomComboBox.Texts = "";
            this.categoryCustomComboBox.OnSelectedIndexChanged += new System.EventHandler(this.categoryCustomComboBox_OnSelectedIndexChanged);
            // 
            // roundButton1
            // 
            this.roundButton1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(161)))), ((int)(((byte)(251)))));
            this.roundButton1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(161)))), ((int)(((byte)(251)))));
            this.roundButton1.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.roundButton1.BorderRadius = 17;
            this.roundButton1.BorderSize = 0;
            this.roundButton1.FlatAppearance.BorderSize = 0;
            this.roundButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.roundButton1.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.roundButton1.ForeColor = System.Drawing.Color.White;
            this.roundButton1.Location = new System.Drawing.Point(606, 50);
            this.roundButton1.Margin = new System.Windows.Forms.Padding(2);
            this.roundButton1.Name = "roundButton1";
            this.roundButton1.Size = new System.Drawing.Size(84, 33);
            this.roundButton1.TabIndex = 6;
            this.roundButton1.Text = "Search";
            this.roundButton1.TextColor = System.Drawing.Color.White;
            this.roundButton1.UseVisualStyleBackColor = false;
            this.roundButton1.Click += new System.EventHandler(this.roundButton1_Click);
            // 
            // selectCustomComboBox
            // 
            this.selectCustomComboBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.selectCustomComboBox.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(161)))), ((int)(((byte)(251)))));
            this.selectCustomComboBox.BorderSize = 3;
            this.selectCustomComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.selectCustomComboBox.Font = new System.Drawing.Font("Arial", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.selectCustomComboBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(161)))), ((int)(((byte)(251)))));
            this.selectCustomComboBox.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(161)))), ((int)(((byte)(251)))));
            this.selectCustomComboBox.Items.AddRange(new object[] {
            "Exercise",
            "Food"});
            this.selectCustomComboBox.ListBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.selectCustomComboBox.ListTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(161)))), ((int)(((byte)(251)))));
            this.selectCustomComboBox.Location = new System.Drawing.Point(31, 32);
            this.selectCustomComboBox.Margin = new System.Windows.Forms.Padding(24, 25, 2, 2);
            this.selectCustomComboBox.MinimumSize = new System.Drawing.Size(160, 25);
            this.selectCustomComboBox.Name = "selectCustomComboBox";
            this.selectCustomComboBox.Padding = new System.Windows.Forms.Padding(2);
            this.selectCustomComboBox.Size = new System.Drawing.Size(192, 62);
            this.selectCustomComboBox.TabIndex = 0;
            this.selectCustomComboBox.Texts = "";
            this.selectCustomComboBox.OnSelectedIndexChanged += new System.EventHandler(this.selectCustomComboBox_OnSelectedIndexChanged);
            // 
            // FormCalculator
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.ClientSize = new System.Drawing.Size(962, 562);
            this.Controls.Add(this.inputKind);
            this.Controls.Add(this.kindTxt);
            this.Controls.Add(this.saveToday);
            this.Controls.Add(this.totalKal);
            this.Controls.Add(this.totalCalorie);
            this.Controls.Add(this.inputBox);
            this.Controls.Add(this.inputLabel);
            this.Controls.Add(this.searchCustomTextBox);
            this.Controls.Add(this.categoryCustomComboBox);
            this.Controls.Add(this.roundButton1);
            this.Controls.Add(this.EFDataGridView);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.selectCustomComboBox);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FormCalculator";
            this.Text = "FormCalculator";
            this.Load += new System.EventHandler(this.FormCalculator_Load);
            ((System.ComponentModel.ISupportInitialize)(this.EFDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CustomControll.CustomComboBox selectCustomComboBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView EFDataGridView;
        private CustomControll.RoundButton roundButton1;
        private CustomControll.CustomComboBox categoryCustomComboBox;
        private CustomControll.CustomTextBox searchCustomTextBox;
        private System.Windows.Forms.Label inputLabel;
        private CustomControll.CustomTextBox inputBox;
        private System.Windows.Forms.Label totalCalorie;
        private System.Windows.Forms.Label totalKal;
        private CustomControll.RoundButton saveToday;
        private System.Windows.Forms.Label kindTxt;
        private System.Windows.Forms.Label inputKind;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn name;
        private System.Windows.Forms.DataGridViewTextBoxColumn category;
        private System.Windows.Forms.DataGridViewTextBoxColumn calorie;
    }
}