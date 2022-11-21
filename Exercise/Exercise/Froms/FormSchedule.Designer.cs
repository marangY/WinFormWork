namespace Exercise.Froms
{
    partial class FormSchedule
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
            this.searchCustomTextBox = new Exercise.CustomControll.CustomTextBox();
            this.categoryCustomComboBox = new Exercise.CustomControll.CustomComboBox();
            this.roundButton1 = new Exercise.CustomControll.RoundButton();
            this.EFDataGridView = new System.Windows.Forms.DataGridView();
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.category = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.calorie = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.EFDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // searchCustomTextBox
            // 
            this.searchCustomTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.searchCustomTextBox.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(135)))), ((int)(((byte)(224)))), ((int)(((byte)(93)))));
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
            this.searchCustomTextBox.Size = new System.Drawing.Size(165, 41);
            this.searchCustomTextBox.TabIndex = 12;
            this.searchCustomTextBox.Texts = "";
            this.searchCustomTextBox.UnderlinedStyle = false;
            // 
            // categoryCustomComboBox
            // 
            this.categoryCustomComboBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.categoryCustomComboBox.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(135)))), ((int)(((byte)(224)))), ((int)(((byte)(93)))));
            this.categoryCustomComboBox.BorderSize = 3;
            this.categoryCustomComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown;
            this.categoryCustomComboBox.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Bold);
            this.categoryCustomComboBox.ForeColor = System.Drawing.Color.White;
            this.categoryCustomComboBox.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(135)))), ((int)(((byte)(224)))), ((int)(((byte)(93)))));
            this.categoryCustomComboBox.Items.AddRange(new object[] {
            "전체",
            "유산소",
            "구기종목",
            "무술",
            "맨몸운동",
            "기타"});
            this.categoryCustomComboBox.ListBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.categoryCustomComboBox.ListTextColor = System.Drawing.Color.White;
            this.categoryCustomComboBox.Location = new System.Drawing.Point(771, 48);
            this.categoryCustomComboBox.Margin = new System.Windows.Forms.Padding(24, 25, 2, 2);
            this.categoryCustomComboBox.MinimumSize = new System.Drawing.Size(160, 25);
            this.categoryCustomComboBox.Name = "categoryCustomComboBox";
            this.categoryCustomComboBox.Padding = new System.Windows.Forms.Padding(2);
            this.categoryCustomComboBox.Size = new System.Drawing.Size(160, 40);
            this.categoryCustomComboBox.TabIndex = 11;
            this.categoryCustomComboBox.Texts = "";
            this.categoryCustomComboBox.OnSelectedIndexChanged += new System.EventHandler(this.categoryCustomComboBox_OnSelectedIndexChanged);
            // 
            // roundButton1
            // 
            this.roundButton1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(135)))), ((int)(((byte)(224)))), ((int)(((byte)(93)))));
            this.roundButton1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(135)))), ((int)(((byte)(224)))), ((int)(((byte)(93)))));
            this.roundButton1.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.roundButton1.BorderRadius = 20;
            this.roundButton1.BorderSize = 0;
            this.roundButton1.FlatAppearance.BorderSize = 0;
            this.roundButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.roundButton1.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.roundButton1.ForeColor = System.Drawing.Color.White;
            this.roundButton1.Location = new System.Drawing.Point(606, 50);
            this.roundButton1.Margin = new System.Windows.Forms.Padding(2);
            this.roundButton1.Name = "roundButton1";
            this.roundButton1.Size = new System.Drawing.Size(84, 33);
            this.roundButton1.TabIndex = 10;
            this.roundButton1.Text = "Search";
            this.roundButton1.TextColor = System.Drawing.Color.White;
            this.roundButton1.UseVisualStyleBackColor = false;
            this.roundButton1.Click += new System.EventHandler(this.searchRoundButton_Click);
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
            dataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle13.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(135)))), ((int)(((byte)(224)))), ((int)(((byte)(93)))));
            dataGridViewCellStyle13.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle13.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle13.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(135)))), ((int)(((byte)(224)))), ((int)(((byte)(93)))));
            dataGridViewCellStyle13.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle13.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.EFDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle13;
            this.EFDataGridView.ColumnHeadersHeight = 50;
            this.EFDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.name,
            this.category,
            this.calorie});
            dataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle14.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
            dataGridViewCellStyle14.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle14.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle14.SelectionBackColor = System.Drawing.Color.DarkBlue;
            dataGridViewCellStyle14.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle14.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.EFDataGridView.DefaultCellStyle = dataGridViewCellStyle14;
            this.EFDataGridView.EnableHeadersVisualStyles = false;
            this.EFDataGridView.GridColor = System.Drawing.Color.White;
            this.EFDataGridView.Location = new System.Drawing.Point(435, 102);
            this.EFDataGridView.Margin = new System.Windows.Forms.Padding(2, 25, 24, 2);
            this.EFDataGridView.MultiSelect = false;
            this.EFDataGridView.Name = "EFDataGridView";
            this.EFDataGridView.ReadOnly = true;
            dataGridViewCellStyle15.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle15.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
            dataGridViewCellStyle15.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle15.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle15.SelectionBackColor = System.Drawing.Color.DarkBlue;
            dataGridViewCellStyle15.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle15.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.EFDataGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle15;
            this.EFDataGridView.RowHeadersVisible = false;
            this.EFDataGridView.RowHeadersWidth = 82;
            this.EFDataGridView.RowTemplate.DividerHeight = 1;
            this.EFDataGridView.RowTemplate.Height = 37;
            this.EFDataGridView.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.EFDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.EFDataGridView.Size = new System.Drawing.Size(496, 428);
            this.EFDataGridView.TabIndex = 9;
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
            // FormSchedule
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.ClientSize = new System.Drawing.Size(962, 562);
            this.Controls.Add(this.searchCustomTextBox);
            this.Controls.Add(this.categoryCustomComboBox);
            this.Controls.Add(this.roundButton1);
            this.Controls.Add(this.EFDataGridView);
            this.Name = "FormSchedule";
            this.Text = "FormSchedule";
            ((System.ComponentModel.ISupportInitialize)(this.EFDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private CustomControll.CustomTextBox searchCustomTextBox;
        private CustomControll.CustomComboBox categoryCustomComboBox;
        private CustomControll.RoundButton roundButton1;
        private System.Windows.Forms.DataGridView EFDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn name;
        private System.Windows.Forms.DataGridViewTextBoxColumn category;
        private System.Windows.Forms.DataGridViewTextBoxColumn calorie;
    }
}