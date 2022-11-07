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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle22 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle23 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle24 = new System.Windows.Forms.DataGridViewCellStyle();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.categoryInputCustomComboBox = new Exercise.CustomControll.CustomComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.timeTxt = new Exercise.CustomControll.CustomTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.nameTxt = new Exercise.CustomControll.CustomTextBox();
            this.categoryCustomComboBox = new Exercise.CustomControll.CustomComboBox();
            this.searchRoundButton = new Exercise.CustomControll.RoundButton();
            this.searchCustomTextBox = new Exercise.CustomControll.CustomTextBox();
            this.EFDataGridView = new System.Windows.Forms.DataGridView();
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Category = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.calorie = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iconPictureBox3 = new FontAwesome.Sharp.IconPictureBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.EFDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox3)).BeginInit();
            this.SuspendLayout();
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
            this.groupBox1.Location = new System.Drawing.Point(62, 485);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1080, 157);
            this.groupBox1.TabIndex = 17;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Append";
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
            this.categoryInputCustomComboBox.ListBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.categoryInputCustomComboBox.ListTextColor = System.Drawing.Color.White;
            this.categoryInputCustomComboBox.Location = new System.Drawing.Point(476, 60);
            this.categoryInputCustomComboBox.Margin = new System.Windows.Forms.Padding(4);
            this.categoryInputCustomComboBox.MinimumSize = new System.Drawing.Size(200, 30);
            this.categoryInputCustomComboBox.Name = "categoryInputCustomComboBox";
            this.categoryInputCustomComboBox.Padding = new System.Windows.Forms.Padding(3);
            this.categoryInputCustomComboBox.Size = new System.Drawing.Size(200, 45);
            this.categoryInputCustomComboBox.TabIndex = 13;
            this.categoryInputCustomComboBox.Texts = "";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(332, 72);
            this.label3.Margin = new System.Windows.Forms.Padding(5, 0, 3, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(137, 33);
            this.label3.TabIndex = 17;
            this.label3.Text = "Category";
            // 
            // timeTxt
            // 
            this.timeTxt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.timeTxt.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(138)))), ((int)(((byte)(114)))));
            this.timeTxt.BorderFocusColor = System.Drawing.Color.HotPink;
            this.timeTxt.BorderRadius = 0;
            this.timeTxt.BorderSize = 3;
            this.timeTxt.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.timeTxt.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.timeTxt.Location = new System.Drawing.Point(777, 60);
            this.timeTxt.Margin = new System.Windows.Forms.Padding(4);
            this.timeTxt.Multiline = false;
            this.timeTxt.Name = "timeTxt";
            this.timeTxt.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.timeTxt.PasswordChar = false;
            this.timeTxt.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.timeTxt.PlaceholderText = "";
            this.timeTxt.Size = new System.Drawing.Size(206, 47);
            this.timeTxt.TabIndex = 16;
            this.timeTxt.Texts = "";
            this.timeTxt.UnderlinedStyle = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(688, 72);
            this.label2.Margin = new System.Windows.Forms.Padding(20, 0, 3, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 33);
            this.label2.TabIndex = 15;
            this.label2.Text = "Gram";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(13, 72);
            this.label1.Margin = new System.Windows.Forms.Padding(20, 0, 3, 0);
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
            this.nameTxt.Location = new System.Drawing.Point(117, 58);
            this.nameTxt.Margin = new System.Windows.Forms.Padding(4);
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
            // categoryCustomComboBox
            // 
            this.categoryCustomComboBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.categoryCustomComboBox.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(138)))), ((int)(((byte)(114)))));
            this.categoryCustomComboBox.BorderSize = 3;
            this.categoryCustomComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown;
            this.categoryCustomComboBox.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Bold);
            this.categoryCustomComboBox.ForeColor = System.Drawing.Color.White;
            this.categoryCustomComboBox.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(138)))), ((int)(((byte)(114)))));
            this.categoryCustomComboBox.ListBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.categoryCustomComboBox.ListTextColor = System.Drawing.Color.White;
            this.categoryCustomComboBox.Location = new System.Drawing.Point(942, 39);
            this.categoryCustomComboBox.Margin = new System.Windows.Forms.Padding(30, 30, 3, 3);
            this.categoryCustomComboBox.MinimumSize = new System.Drawing.Size(200, 30);
            this.categoryCustomComboBox.Name = "categoryCustomComboBox";
            this.categoryCustomComboBox.Padding = new System.Windows.Forms.Padding(3);
            this.categoryCustomComboBox.Size = new System.Drawing.Size(200, 45);
            this.categoryCustomComboBox.TabIndex = 16;
            this.categoryCustomComboBox.Texts = "";
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
            this.searchRoundButton.Name = "searchRoundButton";
            this.searchRoundButton.Size = new System.Drawing.Size(105, 40);
            this.searchRoundButton.TabIndex = 15;
            this.searchRoundButton.Text = "Search";
            this.searchRoundButton.TextColor = System.Drawing.Color.White;
            this.searchRoundButton.UseVisualStyleBackColor = false;
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
            this.searchCustomTextBox.Margin = new System.Windows.Forms.Padding(4);
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
            dataGridViewCellStyle22.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle22.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(138)))), ((int)(((byte)(114)))));
            dataGridViewCellStyle22.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle22.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle22.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(138)))), ((int)(((byte)(114)))));
            dataGridViewCellStyle22.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle22.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.EFDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle22;
            this.EFDataGridView.ColumnHeadersHeight = 50;
            this.EFDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.name,
            this.Category,
            this.calorie});
            dataGridViewCellStyle23.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle23.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
            dataGridViewCellStyle23.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle23.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle23.SelectionBackColor = System.Drawing.Color.DarkBlue;
            dataGridViewCellStyle23.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle23.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.EFDataGridView.DefaultCellStyle = dataGridViewCellStyle23;
            this.EFDataGridView.EnableHeadersVisualStyles = false;
            this.EFDataGridView.GridColor = System.Drawing.Color.White;
            this.EFDataGridView.Location = new System.Drawing.Point(62, 116);
            this.EFDataGridView.Margin = new System.Windows.Forms.Padding(101, 0, 101, 30);
            this.EFDataGridView.MultiSelect = false;
            this.EFDataGridView.Name = "EFDataGridView";
            this.EFDataGridView.ReadOnly = true;
            dataGridViewCellStyle24.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle24.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
            dataGridViewCellStyle24.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle24.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle24.SelectionBackColor = System.Drawing.Color.DarkBlue;
            dataGridViewCellStyle24.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle24.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.EFDataGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle24;
            this.EFDataGridView.RowHeadersVisible = false;
            this.EFDataGridView.RowHeadersWidth = 82;
            this.EFDataGridView.RowTemplate.DividerHeight = 1;
            this.EFDataGridView.RowTemplate.Height = 37;
            this.EFDataGridView.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.EFDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.EFDataGridView.Size = new System.Drawing.Size(1080, 345);
            this.EFDataGridView.TabIndex = 13;
            // 
            // name
            // 
            this.name.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.name.FillWeight = 80F;
            this.name.HeaderText = "음식";
            this.name.MinimumWidth = 10;
            this.name.Name = "name";
            this.name.ReadOnly = true;
            // 
            // Category
            // 
            this.Category.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Category.FillWeight = 80F;
            this.Category.HeaderText = "카테고리";
            this.Category.MinimumWidth = 10;
            this.Category.Name = "Category";
            this.Category.ReadOnly = true;
            // 
            // calorie
            // 
            this.calorie.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.calorie.FillWeight = 120F;
            this.calorie.HeaderText = "그램당 칼로리(kal)";
            this.calorie.MinimumWidth = 10;
            this.calorie.Name = "calorie";
            this.calorie.ReadOnly = true;
            // 
            // iconPictureBox3
            // 
            this.iconPictureBox3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(25)))), ((int)(((byte)(62)))));
            this.iconPictureBox3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(138)))), ((int)(((byte)(114)))));
            this.iconPictureBox3.IconChar = FontAwesome.Sharp.IconChar.Plus;
            this.iconPictureBox3.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(138)))), ((int)(((byte)(114)))));
            this.iconPictureBox3.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconPictureBox3.IconSize = 70;
            this.iconPictureBox3.Location = new System.Drawing.Point(997, 49);
            this.iconPictureBox3.Margin = new System.Windows.Forms.Padding(3, 3, 10, 3);
            this.iconPictureBox3.Name = "iconPictureBox3";
            this.iconPictureBox3.Size = new System.Drawing.Size(70, 70);
            this.iconPictureBox3.TabIndex = 21;
            this.iconPictureBox3.TabStop = false;
            // 
            // FormFood
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.ClientSize = new System.Drawing.Size(1203, 674);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.categoryCustomComboBox);
            this.Controls.Add(this.searchRoundButton);
            this.Controls.Add(this.searchCustomTextBox);
            this.Controls.Add(this.EFDataGridView);
            this.Name = "FormFood";
            this.ShowInTaskbar = false;
            this.Text = "FormFood";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.EFDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private CustomControll.CustomComboBox categoryInputCustomComboBox;
        private System.Windows.Forms.Label label3;
        private CustomControll.CustomTextBox timeTxt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private CustomControll.CustomTextBox nameTxt;
        private CustomControll.CustomComboBox categoryCustomComboBox;
        private CustomControll.RoundButton searchRoundButton;
        private CustomControll.CustomTextBox searchCustomTextBox;
        private System.Windows.Forms.DataGridView EFDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn name;
        private System.Windows.Forms.DataGridViewTextBoxColumn Category;
        private System.Windows.Forms.DataGridViewTextBoxColumn calorie;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox3;
    }
}