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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.EFDataGridView = new System.Windows.Forms.DataGridView();
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Category = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.calorie = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.inputLabel = new System.Windows.Forms.Label();
            this.totalCalorie = new System.Windows.Forms.Label();
            this.totalKal = new System.Windows.Forms.Label();
            this.kindTxt = new System.Windows.Forms.Label();
            this.inputKind = new System.Windows.Forms.Label();
            this.saveToday = new Exercise.CustomControll.RoundButton();
            this.inputBox = new Exercise.CustomControll.CustomTextBox();
            this.customTextBox1 = new Exercise.CustomControll.CustomTextBox();
            this.customComboBox1 = new Exercise.CustomControll.CustomComboBox();
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
            this.label1.Size = new System.Drawing.Size(147, 32);
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
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(161)))), ((int)(((byte)(251)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(161)))), ((int)(((byte)(251)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.EFDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.EFDataGridView.ColumnHeadersHeight = 50;
            this.EFDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.name,
            this.Category,
            this.calorie});
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
            this.EFDataGridView.Location = new System.Drawing.Point(435, 102);
            this.EFDataGridView.Margin = new System.Windows.Forms.Padding(2, 25, 24, 2);
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
            this.EFDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.EFDataGridView.Size = new System.Drawing.Size(496, 428);
            this.EFDataGridView.TabIndex = 3;
            // 
            // name
            // 
            this.name.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.name.FillWeight = 80F;
            this.name.HeaderText = "운동";
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
            this.inputLabel.Size = new System.Drawing.Size(158, 32);
            this.inputLabel.TabIndex = 9;
            this.inputLabel.Text = "Time (min)";
            this.inputLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // totalCalorie
            // 
            this.totalCalorie.AutoSize = true;
            this.totalCalorie.Font = new System.Drawing.Font("Arial", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalCalorie.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(161)))), ((int)(((byte)(251)))));
            this.totalCalorie.Location = new System.Drawing.Point(40, 352);
            this.totalCalorie.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.totalCalorie.Name = "totalCalorie";
            this.totalCalorie.Size = new System.Drawing.Size(181, 32);
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
            this.totalKal.Size = new System.Drawing.Size(75, 32);
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
            this.kindTxt.Size = new System.Drawing.Size(126, 32);
            this.kindTxt.TabIndex = 14;
            this.kindTxt.Text = "Exercise";
            this.kindTxt.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // inputKind
            // 
            this.inputKind.AutoSize = true;
            this.inputKind.Font = new System.Drawing.Font("Arial", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inputKind.ForeColor = System.Drawing.Color.White;
            this.inputKind.Location = new System.Drawing.Point(228, 142);
            this.inputKind.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.inputKind.Name = "inputKind";
            this.inputKind.Size = new System.Drawing.Size(71, 32);
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
            this.saveToday.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.saveToday.Name = "saveToday";
            this.saveToday.Size = new System.Drawing.Size(152, 42);
            this.saveToday.TabIndex = 13;
            this.saveToday.Text = "Save Today";
            this.saveToday.TextColor = System.Drawing.Color.White;
            this.saveToday.UseVisualStyleBackColor = false;
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
            this.inputBox.Multiline = false;
            this.inputBox.Name = "inputBox";
            this.inputBox.Padding = new System.Windows.Forms.Padding(8, 6, 8, 6);
            this.inputBox.PasswordChar = false;
            this.inputBox.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.inputBox.PlaceholderText = "";
            this.inputBox.Size = new System.Drawing.Size(165, 41);
            this.inputBox.TabIndex = 10;
            this.inputBox.Texts = "";
            this.inputBox.UnderlinedStyle = false;
            // 
            // customTextBox1
            // 
            this.customTextBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.customTextBox1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(161)))), ((int)(((byte)(251)))));
            this.customTextBox1.BorderFocusColor = System.Drawing.Color.HotPink;
            this.customTextBox1.BorderRadius = 0;
            this.customTextBox1.BorderSize = 3;
            this.customTextBox1.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Bold);
            this.customTextBox1.ForeColor = System.Drawing.Color.White;
            this.customTextBox1.Location = new System.Drawing.Point(435, 48);
            this.customTextBox1.Multiline = false;
            this.customTextBox1.Name = "customTextBox1";
            this.customTextBox1.Padding = new System.Windows.Forms.Padding(8, 6, 8, 6);
            this.customTextBox1.PasswordChar = false;
            this.customTextBox1.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.customTextBox1.PlaceholderText = "";
            this.customTextBox1.Size = new System.Drawing.Size(165, 41);
            this.customTextBox1.TabIndex = 8;
            this.customTextBox1.Texts = "";
            this.customTextBox1.UnderlinedStyle = false;
            // 
            // customComboBox1
            // 
            this.customComboBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.customComboBox1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(161)))), ((int)(((byte)(251)))));
            this.customComboBox1.BorderSize = 3;
            this.customComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown;
            this.customComboBox1.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Bold);
            this.customComboBox1.ForeColor = System.Drawing.Color.White;
            this.customComboBox1.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(161)))), ((int)(((byte)(251)))));
            this.customComboBox1.ListBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.customComboBox1.ListTextColor = System.Drawing.Color.White;
            this.customComboBox1.Location = new System.Drawing.Point(771, 48);
            this.customComboBox1.Margin = new System.Windows.Forms.Padding(24, 25, 2, 2);
            this.customComboBox1.MinimumSize = new System.Drawing.Size(160, 25);
            this.customComboBox1.Name = "customComboBox1";
            this.customComboBox1.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.customComboBox1.Size = new System.Drawing.Size(160, 40);
            this.customComboBox1.TabIndex = 7;
            this.customComboBox1.Texts = "";
            // 
            // roundButton1
            // 
            this.roundButton1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(161)))), ((int)(((byte)(251)))));
            this.roundButton1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(161)))), ((int)(((byte)(251)))));
            this.roundButton1.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.roundButton1.BorderRadius = 20;
            this.roundButton1.BorderSize = 0;
            this.roundButton1.FlatAppearance.BorderSize = 0;
            this.roundButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.roundButton1.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.roundButton1.ForeColor = System.Drawing.Color.White;
            this.roundButton1.Location = new System.Drawing.Point(606, 50);
            this.roundButton1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.roundButton1.Name = "roundButton1";
            this.roundButton1.Size = new System.Drawing.Size(84, 33);
            this.roundButton1.TabIndex = 6;
            this.roundButton1.Text = "Search";
            this.roundButton1.TextColor = System.Drawing.Color.White;
            this.roundButton1.UseVisualStyleBackColor = false;
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
            this.selectCustomComboBox.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.selectCustomComboBox.Size = new System.Drawing.Size(192, 62);
            this.selectCustomComboBox.TabIndex = 0;
            this.selectCustomComboBox.Texts = "";
            this.selectCustomComboBox.OnSelectedIndexChanged += new System.EventHandler(this.selectCustomComboBox_OnSelectedIndexChanged);
            // 
            // FormCalculator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.ClientSize = new System.Drawing.Size(962, 562);
            this.Controls.Add(this.inputKind);
            this.Controls.Add(this.kindTxt);
            this.Controls.Add(this.saveToday);
            this.Controls.Add(this.totalKal);
            this.Controls.Add(this.totalCalorie);
            this.Controls.Add(this.inputBox);
            this.Controls.Add(this.inputLabel);
            this.Controls.Add(this.customTextBox1);
            this.Controls.Add(this.customComboBox1);
            this.Controls.Add(this.roundButton1);
            this.Controls.Add(this.EFDataGridView);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.selectCustomComboBox);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
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
        private CustomControll.CustomComboBox customComboBox1;
        private CustomControll.CustomTextBox customTextBox1;
        private System.Windows.Forms.Label inputLabel;
        private CustomControll.CustomTextBox inputBox;
        private System.Windows.Forms.Label totalCalorie;
        private System.Windows.Forms.Label totalKal;
        private CustomControll.RoundButton saveToday;
        private System.Windows.Forms.Label kindTxt;
        private System.Windows.Forms.Label inputKind;
        private System.Windows.Forms.DataGridViewTextBoxColumn name;
        private System.Windows.Forms.DataGridViewTextBoxColumn Category;
        private System.Windows.Forms.DataGridViewTextBoxColumn calorie;
    }
}