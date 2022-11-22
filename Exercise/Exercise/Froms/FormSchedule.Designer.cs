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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.EFDataGridView = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.category = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.calorie = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.scheduleListView = new System.Windows.Forms.ListView();
            this.exerciseLabel = new System.Windows.Forms.Label();
            this.timeLabel = new System.Windows.Forms.Label();
            this.scheduleCalendar = new System.Windows.Forms.MonthCalendar();
            this.Schedule = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Time = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Date = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label1 = new System.Windows.Forms.Label();
            this.down = new Exercise.CustomControll.RoundButton();
            this.up = new Exercise.CustomControll.RoundButton();
            this.roundButton3 = new Exercise.CustomControll.RoundButton();
            this.roundButton2 = new Exercise.CustomControll.RoundButton();
            this.timeInput = new Exercise.CustomControll.CustomTextBox();
            this.searchCustomTextBox = new Exercise.CustomControll.CustomTextBox();
            this.categoryCustomComboBox = new Exercise.CustomControll.CustomComboBox();
            this.roundButton1 = new Exercise.CustomControll.RoundButton();
            ((System.ComponentModel.ISupportInitialize)(this.EFDataGridView)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
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
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(135)))), ((int)(((byte)(224)))), ((int)(((byte)(93)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(135)))), ((int)(((byte)(224)))), ((int)(((byte)(93)))));
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
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.DarkBlue;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.EFDataGridView.DefaultCellStyle = dataGridViewCellStyle5;
            this.EFDataGridView.EnableHeadersVisualStyles = false;
            this.EFDataGridView.GridColor = System.Drawing.Color.White;
            this.EFDataGridView.Location = new System.Drawing.Point(575, 56);
            this.EFDataGridView.Margin = new System.Windows.Forms.Padding(2, 30, 30, 2);
            this.EFDataGridView.MultiSelect = false;
            this.EFDataGridView.Name = "EFDataGridView";
            this.EFDataGridView.ReadOnly = true;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Bold);
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
            this.EFDataGridView.Size = new System.Drawing.Size(406, 247);
            this.EFDataGridView.TabIndex = 9;
            this.EFDataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.EFDataGridView_CellClick);
            // 
            // id
            // 
            this.id.DataPropertyName = "EXERCISE_ID";
            this.id.HeaderText = "id";
            this.id.MinimumWidth = 8;
            this.id.Name = "id";
            this.id.ReadOnly = true;
            this.id.Visible = false;
            this.id.Width = 150;
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
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.roundButton2);
            this.groupBox1.Controls.Add(this.scheduleCalendar);
            this.groupBox1.Controls.Add(this.timeInput);
            this.groupBox1.Controls.Add(this.timeLabel);
            this.groupBox1.Controls.Add(this.exerciseLabel);
            this.groupBox1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(135)))), ((int)(((byte)(224)))), ((int)(((byte)(93)))));
            this.groupBox1.Location = new System.Drawing.Point(575, 350);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(615, 296);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "New Schedule";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.down);
            this.groupBox2.Controls.Add(this.up);
            this.groupBox2.Controls.Add(this.roundButton3);
            this.groupBox2.Controls.Add(this.scheduleListView);
            this.groupBox2.Cursor = System.Windows.Forms.Cursors.Default;
            this.groupBox2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(135)))), ((int)(((byte)(224)))), ((int)(((byte)(93)))));
            this.groupBox2.Location = new System.Drawing.Point(12, 57);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(524, 589);
            this.groupBox2.TabIndex = 14;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "User Schedule";
            // 
            // scheduleListView
            // 
            this.scheduleListView.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.scheduleListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Schedule,
            this.Time,
            this.Date});
            this.scheduleListView.Font = new System.Drawing.Font("Arial", 16F, System.Drawing.FontStyle.Bold);
            this.scheduleListView.ForeColor = System.Drawing.Color.Black;
            this.scheduleListView.HideSelection = false;
            this.scheduleListView.Location = new System.Drawing.Point(6, 44);
            this.scheduleListView.Name = "scheduleListView";
            this.scheduleListView.Scrollable = false;
            this.scheduleListView.Size = new System.Drawing.Size(512, 444);
            this.scheduleListView.TabIndex = 0;
            this.scheduleListView.UseCompatibleStateImageBehavior = false;
            this.scheduleListView.View = System.Windows.Forms.View.Details;
            // 
            // exerciseLabel
            // 
            this.exerciseLabel.AutoSize = true;
            this.exerciseLabel.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.exerciseLabel.Location = new System.Drawing.Point(122, 59);
            this.exerciseLabel.Name = "exerciseLabel";
            this.exerciseLabel.Size = new System.Drawing.Size(50, 24);
            this.exerciseLabel.TabIndex = 0;
            this.exerciseLabel.Text = "kind";
            // 
            // timeLabel
            // 
            this.timeLabel.AutoSize = true;
            this.timeLabel.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.timeLabel.Location = new System.Drawing.Point(15, 142);
            this.timeLabel.Name = "timeLabel";
            this.timeLabel.Size = new System.Drawing.Size(56, 24);
            this.timeLabel.TabIndex = 1;
            this.timeLabel.Text = "Time";
            // 
            // scheduleCalendar
            // 
            this.scheduleCalendar.Location = new System.Drawing.Point(305, 31);
            this.scheduleCalendar.Name = "scheduleCalendar";
            this.scheduleCalendar.TabIndex = 16;
            this.scheduleCalendar.TodayDate = new System.DateTime(2022, 11, 22, 0, 0, 0, 0);
            // 
            // Schedule
            // 
            this.Schedule.Text = "Schedule";
            this.Schedule.Width = 262;
            // 
            // Time
            // 
            this.Time.Text = "time";
            this.Time.Width = 100;
            // 
            // Date
            // 
            this.Date.Text = "Date";
            this.Date.Width = 150;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(15, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 24);
            this.label1.TabIndex = 17;
            this.label1.Text = "Exercise";
            // 
            // down
            // 
            this.down.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(135)))), ((int)(((byte)(224)))), ((int)(((byte)(93)))));
            this.down.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(135)))), ((int)(((byte)(224)))), ((int)(((byte)(93)))));
            this.down.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.down.BorderRadius = 20;
            this.down.BorderSize = 0;
            this.down.FlatAppearance.BorderSize = 0;
            this.down.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.down.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.down.ForeColor = System.Drawing.Color.White;
            this.down.Location = new System.Drawing.Point(146, 513);
            this.down.Margin = new System.Windows.Forms.Padding(2);
            this.down.Name = "down";
            this.down.Size = new System.Drawing.Size(105, 40);
            this.down.TabIndex = 19;
            this.down.Text = "Down";
            this.down.TextColor = System.Drawing.Color.White;
            this.down.UseVisualStyleBackColor = false;
            this.down.Click += new System.EventHandler(this.down_Click);
            // 
            // up
            // 
            this.up.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(135)))), ((int)(((byte)(224)))), ((int)(((byte)(93)))));
            this.up.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(135)))), ((int)(((byte)(224)))), ((int)(((byte)(93)))));
            this.up.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.up.BorderRadius = 20;
            this.up.BorderSize = 0;
            this.up.FlatAppearance.BorderSize = 0;
            this.up.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.up.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.up.ForeColor = System.Drawing.Color.White;
            this.up.Location = new System.Drawing.Point(20, 513);
            this.up.Margin = new System.Windows.Forms.Padding(2);
            this.up.Name = "up";
            this.up.Size = new System.Drawing.Size(105, 40);
            this.up.TabIndex = 18;
            this.up.Text = "Up";
            this.up.TextColor = System.Drawing.Color.White;
            this.up.UseVisualStyleBackColor = false;
            this.up.Click += new System.EventHandler(this.up_Click);
            // 
            // roundButton3
            // 
            this.roundButton3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(135)))), ((int)(((byte)(224)))), ((int)(((byte)(93)))));
            this.roundButton3.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(135)))), ((int)(((byte)(224)))), ((int)(((byte)(93)))));
            this.roundButton3.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.roundButton3.BorderRadius = 20;
            this.roundButton3.BorderSize = 0;
            this.roundButton3.FlatAppearance.BorderSize = 0;
            this.roundButton3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.roundButton3.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.roundButton3.ForeColor = System.Drawing.Color.White;
            this.roundButton3.Location = new System.Drawing.Point(413, 512);
            this.roundButton3.Margin = new System.Windows.Forms.Padding(2);
            this.roundButton3.Name = "roundButton3";
            this.roundButton3.Size = new System.Drawing.Size(105, 40);
            this.roundButton3.TabIndex = 17;
            this.roundButton3.Text = "Remove";
            this.roundButton3.TextColor = System.Drawing.Color.White;
            this.roundButton3.UseVisualStyleBackColor = false;
            // 
            // roundButton2
            // 
            this.roundButton2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(135)))), ((int)(((byte)(224)))), ((int)(((byte)(93)))));
            this.roundButton2.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(135)))), ((int)(((byte)(224)))), ((int)(((byte)(93)))));
            this.roundButton2.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.roundButton2.BorderRadius = 20;
            this.roundButton2.BorderSize = 0;
            this.roundButton2.FlatAppearance.BorderSize = 0;
            this.roundButton2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.roundButton2.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.roundButton2.ForeColor = System.Drawing.Color.White;
            this.roundButton2.Location = new System.Drawing.Point(86, 219);
            this.roundButton2.Margin = new System.Windows.Forms.Padding(2);
            this.roundButton2.Name = "roundButton2";
            this.roundButton2.Size = new System.Drawing.Size(105, 40);
            this.roundButton2.TabIndex = 15;
            this.roundButton2.Text = "Add";
            this.roundButton2.TextColor = System.Drawing.Color.White;
            this.roundButton2.UseVisualStyleBackColor = false;
            this.roundButton2.Click += new System.EventHandler(this.roundButton2_Click);
            // 
            // timeInput
            // 
            this.timeInput.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.timeInput.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(135)))), ((int)(((byte)(224)))), ((int)(((byte)(93)))));
            this.timeInput.BorderFocusColor = System.Drawing.Color.HotPink;
            this.timeInput.BorderRadius = 0;
            this.timeInput.BorderSize = 3;
            this.timeInput.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.timeInput.ForeColor = System.Drawing.Color.White;
            this.timeInput.Location = new System.Drawing.Point(126, 132);
            this.timeInput.Margin = new System.Windows.Forms.Padding(5);
            this.timeInput.Multiline = false;
            this.timeInput.Name = "timeInput";
            this.timeInput.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.timeInput.PasswordChar = false;
            this.timeInput.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.timeInput.PlaceholderText = "";
            this.timeInput.Size = new System.Drawing.Size(136, 44);
            this.timeInput.TabIndex = 15;
            this.timeInput.Texts = "";
            this.timeInput.UnderlinedStyle = false;
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
            this.searchCustomTextBox.Location = new System.Drawing.Point(992, 145);
            this.searchCustomTextBox.Margin = new System.Windows.Forms.Padding(5);
            this.searchCustomTextBox.Multiline = false;
            this.searchCustomTextBox.Name = "searchCustomTextBox";
            this.searchCustomTextBox.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.searchCustomTextBox.PasswordChar = false;
            this.searchCustomTextBox.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.searchCustomTextBox.PlaceholderText = "";
            this.searchCustomTextBox.Size = new System.Drawing.Size(200, 47);
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
            this.categoryCustomComboBox.Location = new System.Drawing.Point(991, 59);
            this.categoryCustomComboBox.Margin = new System.Windows.Forms.Padding(30, 30, 2, 2);
            this.categoryCustomComboBox.MinimumSize = new System.Drawing.Size(200, 30);
            this.categoryCustomComboBox.Name = "categoryCustomComboBox";
            this.categoryCustomComboBox.Padding = new System.Windows.Forms.Padding(2);
            this.categoryCustomComboBox.Size = new System.Drawing.Size(200, 48);
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
            this.roundButton1.Location = new System.Drawing.Point(1042, 238);
            this.roundButton1.Margin = new System.Windows.Forms.Padding(2);
            this.roundButton1.Name = "roundButton1";
            this.roundButton1.Size = new System.Drawing.Size(105, 40);
            this.roundButton1.TabIndex = 10;
            this.roundButton1.Text = "Search";
            this.roundButton1.TextColor = System.Drawing.Color.White;
            this.roundButton1.UseVisualStyleBackColor = false;
            this.roundButton1.Click += new System.EventHandler(this.searchRoundButton_Click);
            // 
            // FormSchedule
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.ClientSize = new System.Drawing.Size(1202, 674);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.searchCustomTextBox);
            this.Controls.Add(this.categoryCustomComboBox);
            this.Controls.Add(this.roundButton1);
            this.Controls.Add(this.EFDataGridView);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormSchedule";
            this.Text = "FormSchedule";
            this.Load += new System.EventHandler(this.FormSchedule_Load);
            ((System.ComponentModel.ISupportInitialize)(this.EFDataGridView)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private CustomControll.CustomTextBox searchCustomTextBox;
        private CustomControll.CustomComboBox categoryCustomComboBox;
        private CustomControll.RoundButton roundButton1;
        private System.Windows.Forms.DataGridView EFDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn name;
        private System.Windows.Forms.DataGridViewTextBoxColumn category;
        private System.Windows.Forms.DataGridViewTextBoxColumn calorie;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label exerciseLabel;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ListView scheduleListView;
        private CustomControll.CustomTextBox timeInput;
        private System.Windows.Forms.Label timeLabel;
        private System.Windows.Forms.MonthCalendar scheduleCalendar;
        private CustomControll.RoundButton roundButton2;
        private CustomControll.RoundButton roundButton3;
        private CustomControll.RoundButton down;
        private CustomControll.RoundButton up;
        private System.Windows.Forms.ColumnHeader Schedule;
        private System.Windows.Forms.ColumnHeader Time;
        private System.Windows.Forms.ColumnHeader Date;
        private System.Windows.Forms.Label label1;
    }
}