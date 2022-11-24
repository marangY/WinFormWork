namespace Exercise.Froms
{
    partial class FormHome
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.bodyGroupBox = new System.Windows.Forms.GroupBox();
            this.bmiGroupBox = new System.Windows.Forms.GroupBox();
            this.bmi = new System.Windows.Forms.Label();
            this.bodyFatGroupBox = new System.Windows.Forms.GroupBox();
            this.bodyFat = new System.Windows.Forms.TextBox();
            this.percentage = new System.Windows.Forms.Label();
            this.weightGroupBox = new System.Windows.Forms.GroupBox();
            this.weight = new System.Windows.Forms.TextBox();
            this.KG = new System.Windows.Forms.Label();
            this.heightGroupBox = new System.Windows.Forms.GroupBox();
            this.cm = new System.Windows.Forms.Label();
            this.height = new System.Windows.Forms.TextBox();
            this.user = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.foodKal = new System.Windows.Forms.Label();
            this.exerciseKal = new System.Windows.Forms.Label();
            this.totalKal = new System.Windows.Forms.Label();
            this.foodGroup = new System.Windows.Forms.GroupBox();
            this.FDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.exerciseGroup = new System.Windows.Forms.GroupBox();
            this.EDataGridView = new System.Windows.Forms.DataGridView();
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.category = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.calorie = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statusUpdateButton = new Exercise.CustomControll.RoundButton();
            this.bodyGroupBox.SuspendLayout();
            this.bmiGroupBox.SuspendLayout();
            this.bodyFatGroupBox.SuspendLayout();
            this.weightGroupBox.SuspendLayout();
            this.heightGroupBox.SuspendLayout();
            this.foodGroup.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.FDataGridView)).BeginInit();
            this.exerciseGroup.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.EDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // bodyGroupBox
            // 
            this.bodyGroupBox.Controls.Add(this.statusUpdateButton);
            this.bodyGroupBox.Controls.Add(this.bmiGroupBox);
            this.bodyGroupBox.Controls.Add(this.bodyFatGroupBox);
            this.bodyGroupBox.Controls.Add(this.weightGroupBox);
            this.bodyGroupBox.Controls.Add(this.heightGroupBox);
            this.bodyGroupBox.Controls.Add(this.user);
            this.bodyGroupBox.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bodyGroupBox.ForeColor = System.Drawing.Color.White;
            this.bodyGroupBox.Location = new System.Drawing.Point(31, 32);
            this.bodyGroupBox.Margin = new System.Windows.Forms.Padding(24, 25, 2, 2);
            this.bodyGroupBox.Name = "bodyGroupBox";
            this.bodyGroupBox.Padding = new System.Windows.Forms.Padding(2);
            this.bodyGroupBox.Size = new System.Drawing.Size(280, 519);
            this.bodyGroupBox.TabIndex = 0;
            this.bodyGroupBox.TabStop = false;
            this.bodyGroupBox.Text = "Body Status";
            // 
            // bmiGroupBox
            // 
            this.bmiGroupBox.Controls.Add(this.bmi);
            this.bmiGroupBox.ForeColor = System.Drawing.Color.White;
            this.bmiGroupBox.Location = new System.Drawing.Point(6, 393);
            this.bmiGroupBox.Margin = new System.Windows.Forms.Padding(4, 42, 4, 0);
            this.bmiGroupBox.Name = "bmiGroupBox";
            this.bmiGroupBox.Padding = new System.Windows.Forms.Padding(2);
            this.bmiGroupBox.Size = new System.Drawing.Size(263, 60);
            this.bmiGroupBox.TabIndex = 3;
            this.bmiGroupBox.TabStop = false;
            this.bmiGroupBox.Text = "BMI";
            // 
            // bmi
            // 
            this.bmi.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold);
            this.bmi.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.bmi.Location = new System.Drawing.Point(5, 26);
            this.bmi.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.bmi.Name = "bmi";
            this.bmi.Size = new System.Drawing.Size(207, 28);
            this.bmi.TabIndex = 0;
            this.bmi.Text = "bmi";
            this.bmi.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // bodyFatGroupBox
            // 
            this.bodyFatGroupBox.Controls.Add(this.bodyFat);
            this.bodyFatGroupBox.Controls.Add(this.percentage);
            this.bodyFatGroupBox.ForeColor = System.Drawing.Color.White;
            this.bodyFatGroupBox.Location = new System.Drawing.Point(6, 292);
            this.bodyFatGroupBox.Margin = new System.Windows.Forms.Padding(4, 42, 4, 0);
            this.bodyFatGroupBox.Name = "bodyFatGroupBox";
            this.bodyFatGroupBox.Padding = new System.Windows.Forms.Padding(2);
            this.bodyFatGroupBox.Size = new System.Drawing.Size(263, 60);
            this.bodyFatGroupBox.TabIndex = 2;
            this.bodyFatGroupBox.TabStop = false;
            this.bodyFatGroupBox.Text = "Body Fat";
            // 
            // bodyFat
            // 
            this.bodyFat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.bodyFat.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.bodyFat.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bodyFat.ForeColor = System.Drawing.Color.White;
            this.bodyFat.Location = new System.Drawing.Point(5, 28);
            this.bodyFat.Margin = new System.Windows.Forms.Padding(2);
            this.bodyFat.Name = "bodyFat";
            this.bodyFat.Size = new System.Drawing.Size(208, 27);
            this.bodyFat.TabIndex = 4;
            this.bodyFat.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // percentage
            // 
            this.percentage.AutoSize = true;
            this.percentage.Location = new System.Drawing.Point(232, 26);
            this.percentage.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.percentage.Name = "percentage";
            this.percentage.Size = new System.Drawing.Size(27, 24);
            this.percentage.TabIndex = 3;
            this.percentage.Text = "%";
            // 
            // weightGroupBox
            // 
            this.weightGroupBox.Controls.Add(this.weight);
            this.weightGroupBox.Controls.Add(this.KG);
            this.weightGroupBox.ForeColor = System.Drawing.Color.White;
            this.weightGroupBox.Location = new System.Drawing.Point(6, 190);
            this.weightGroupBox.Margin = new System.Windows.Forms.Padding(4, 42, 4, 0);
            this.weightGroupBox.Name = "weightGroupBox";
            this.weightGroupBox.Padding = new System.Windows.Forms.Padding(2);
            this.weightGroupBox.Size = new System.Drawing.Size(263, 60);
            this.weightGroupBox.TabIndex = 2;
            this.weightGroupBox.TabStop = false;
            this.weightGroupBox.Text = "Weight";
            // 
            // weight
            // 
            this.weight.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.weight.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.weight.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.weight.ForeColor = System.Drawing.Color.White;
            this.weight.Location = new System.Drawing.Point(4, 28);
            this.weight.Margin = new System.Windows.Forms.Padding(2);
            this.weight.Name = "weight";
            this.weight.Size = new System.Drawing.Size(208, 27);
            this.weight.TabIndex = 3;
            this.weight.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // KG
            // 
            this.KG.AutoSize = true;
            this.KG.Location = new System.Drawing.Point(218, 26);
            this.KG.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.KG.Name = "KG";
            this.KG.Size = new System.Drawing.Size(40, 24);
            this.KG.TabIndex = 2;
            this.KG.Text = "KG";
            // 
            // heightGroupBox
            // 
            this.heightGroupBox.Controls.Add(this.cm);
            this.heightGroupBox.Controls.Add(this.height);
            this.heightGroupBox.ForeColor = System.Drawing.Color.White;
            this.heightGroupBox.Location = new System.Drawing.Point(6, 88);
            this.heightGroupBox.Margin = new System.Windows.Forms.Padding(4, 42, 4, 0);
            this.heightGroupBox.Name = "heightGroupBox";
            this.heightGroupBox.Padding = new System.Windows.Forms.Padding(2);
            this.heightGroupBox.Size = new System.Drawing.Size(263, 60);
            this.heightGroupBox.TabIndex = 1;
            this.heightGroupBox.TabStop = false;
            this.heightGroupBox.Text = "Height";
            // 
            // cm
            // 
            this.cm.AutoSize = true;
            this.cm.Location = new System.Drawing.Point(218, 26);
            this.cm.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.cm.Name = "cm";
            this.cm.Size = new System.Drawing.Size(41, 24);
            this.cm.TabIndex = 1;
            this.cm.Text = "CM";
            // 
            // height
            // 
            this.height.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.height.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.height.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.height.ForeColor = System.Drawing.Color.White;
            this.height.Location = new System.Drawing.Point(4, 28);
            this.height.Margin = new System.Windows.Forms.Padding(2);
            this.height.Name = "height";
            this.height.Size = new System.Drawing.Size(208, 27);
            this.height.TabIndex = 0;
            this.height.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // user
            // 
            this.user.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.user.Location = new System.Drawing.Point(6, 26);
            this.user.Margin = new System.Windows.Forms.Padding(4, 17, 2, 0);
            this.user.Name = "user";
            this.user.Size = new System.Drawing.Size(270, 40);
            this.user.TabIndex = 1;
            this.user.Text = "username";
            this.user.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(172)))), ((int)(((byte)(126)))), ((int)(((byte)(241)))));
            this.label1.Location = new System.Drawing.Point(352, 32);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 17, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 32);
            this.label1.TabIndex = 4;
            this.label1.Text = "Today";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(138)))), ((int)(((byte)(114)))));
            this.label2.Location = new System.Drawing.Point(352, 93);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 17, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(199, 32);
            this.label2.TabIndex = 5;
            this.label2.Text = "Food Calories";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(77)))), ((int)(((byte)(221)))));
            this.label3.Location = new System.Drawing.Point(352, 154);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 17, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(243, 32);
            this.label3.TabIndex = 6;
            this.label3.Text = "Exercise Calories";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(172)))), ((int)(((byte)(126)))), ((int)(((byte)(241)))));
            this.label4.Location = new System.Drawing.Point(352, 211);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 17, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(196, 32);
            this.label4.TabIndex = 7;
            this.label4.Text = "Total Calories";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // foodKal
            // 
            this.foodKal.AutoSize = true;
            this.foodKal.Font = new System.Drawing.Font("Arial", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.foodKal.ForeColor = System.Drawing.Color.Khaki;
            this.foodKal.Location = new System.Drawing.Point(663, 93);
            this.foodKal.Margin = new System.Windows.Forms.Padding(4, 17, 2, 0);
            this.foodKal.Name = "foodKal";
            this.foodKal.Size = new System.Drawing.Size(83, 32);
            this.foodKal.TabIndex = 8;
            this.foodKal.Text = "0  kal";
            this.foodKal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // exerciseKal
            // 
            this.exerciseKal.AutoSize = true;
            this.exerciseKal.Font = new System.Drawing.Font("Arial", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exerciseKal.ForeColor = System.Drawing.Color.Khaki;
            this.exerciseKal.Location = new System.Drawing.Point(663, 154);
            this.exerciseKal.Margin = new System.Windows.Forms.Padding(4, 17, 2, 0);
            this.exerciseKal.Name = "exerciseKal";
            this.exerciseKal.Size = new System.Drawing.Size(83, 32);
            this.exerciseKal.TabIndex = 9;
            this.exerciseKal.Text = "0  kal";
            this.exerciseKal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // totalKal
            // 
            this.totalKal.AutoSize = true;
            this.totalKal.Font = new System.Drawing.Font("Arial", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalKal.ForeColor = System.Drawing.Color.Khaki;
            this.totalKal.Location = new System.Drawing.Point(663, 211);
            this.totalKal.Margin = new System.Windows.Forms.Padding(4, 17, 2, 0);
            this.totalKal.Name = "totalKal";
            this.totalKal.Size = new System.Drawing.Size(83, 32);
            this.totalKal.TabIndex = 10;
            this.totalKal.Text = "0  kal";
            this.totalKal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // foodGroup
            // 
            this.foodGroup.Controls.Add(this.FDataGridView);
            this.foodGroup.Font = new System.Drawing.Font("Arial Narrow", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.foodGroup.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(172)))), ((int)(((byte)(126)))), ((int)(((byte)(241)))));
            this.foodGroup.Location = new System.Drawing.Point(358, 272);
            this.foodGroup.Name = "foodGroup";
            this.foodGroup.Size = new System.Drawing.Size(285, 279);
            this.foodGroup.TabIndex = 11;
            this.foodGroup.TabStop = false;
            this.foodGroup.Text = "Food";
            // 
            // FDataGridView
            // 
            this.FDataGridView.AllowUserToAddRows = false;
            this.FDataGridView.AllowUserToDeleteRows = false;
            this.FDataGridView.AllowUserToResizeColumns = false;
            this.FDataGridView.AllowUserToResizeRows = false;
            this.FDataGridView.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.FDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.FDataGridView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.FDataGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(138)))), ((int)(((byte)(114)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Arial Narrow", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(138)))), ((int)(((byte)(114)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.FDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.FDataGridView.ColumnHeadersHeight = 50;
            this.FDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Arial Narrow", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(172)))), ((int)(((byte)(126)))), ((int)(((byte)(241)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.DarkBlue;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.FDataGridView.DefaultCellStyle = dataGridViewCellStyle2;
            this.FDataGridView.EnableHeadersVisualStyles = false;
            this.FDataGridView.GridColor = System.Drawing.Color.White;
            this.FDataGridView.Location = new System.Drawing.Point(5, 24);
            this.FDataGridView.Margin = new System.Windows.Forms.Padding(2, 25, 24, 2);
            this.FDataGridView.MultiSelect = false;
            this.FDataGridView.Name = "FDataGridView";
            this.FDataGridView.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Arial Narrow", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.DarkBlue;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.FDataGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.FDataGridView.RowHeadersVisible = false;
            this.FDataGridView.RowHeadersWidth = 82;
            this.FDataGridView.RowTemplate.DividerHeight = 1;
            this.FDataGridView.RowTemplate.Height = 37;
            this.FDataGridView.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.FDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.FDataGridView.Size = new System.Drawing.Size(277, 250);
            this.FDataGridView.TabIndex = 13;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn1.DataPropertyName = "name";
            this.dataGridViewTextBoxColumn1.FillWeight = 120F;
            this.dataGridViewTextBoxColumn1.HeaderText = "음식";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 10;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn2.DataPropertyName = "gram";
            this.dataGridViewTextBoxColumn2.FillWeight = 80F;
            this.dataGridViewTextBoxColumn2.HeaderText = "그램";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 10;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn3.DataPropertyName = "kal";
            this.dataGridViewTextBoxColumn3.FillWeight = 80F;
            this.dataGridViewTextBoxColumn3.HeaderText = "kal";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 10;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // exerciseGroup
            // 
            this.exerciseGroup.Controls.Add(this.EDataGridView);
            this.exerciseGroup.Font = new System.Drawing.Font("Arial Narrow", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exerciseGroup.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(172)))), ((int)(((byte)(126)))), ((int)(((byte)(241)))));
            this.exerciseGroup.Location = new System.Drawing.Point(649, 272);
            this.exerciseGroup.Name = "exerciseGroup";
            this.exerciseGroup.Size = new System.Drawing.Size(285, 279);
            this.exerciseGroup.TabIndex = 12;
            this.exerciseGroup.TabStop = false;
            this.exerciseGroup.Text = "Exercise";
            // 
            // EDataGridView
            // 
            this.EDataGridView.AllowUserToAddRows = false;
            this.EDataGridView.AllowUserToDeleteRows = false;
            this.EDataGridView.AllowUserToResizeColumns = false;
            this.EDataGridView.AllowUserToResizeRows = false;
            this.EDataGridView.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.EDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.EDataGridView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.EDataGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(77)))), ((int)(((byte)(221)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Arial Narrow", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(77)))), ((int)(((byte)(221)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.EDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.EDataGridView.ColumnHeadersHeight = 50;
            this.EDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.name,
            this.category,
            this.calorie});
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Arial Narrow", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(172)))), ((int)(((byte)(126)))), ((int)(((byte)(241)))));
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.DarkBlue;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.EDataGridView.DefaultCellStyle = dataGridViewCellStyle5;
            this.EDataGridView.EnableHeadersVisualStyles = false;
            this.EDataGridView.GridColor = System.Drawing.Color.White;
            this.EDataGridView.Location = new System.Drawing.Point(4, 24);
            this.EDataGridView.Margin = new System.Windows.Forms.Padding(2, 25, 24, 2);
            this.EDataGridView.MultiSelect = false;
            this.EDataGridView.Name = "EDataGridView";
            this.EDataGridView.ReadOnly = true;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Arial Narrow", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.DarkBlue;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.EDataGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.EDataGridView.RowHeadersVisible = false;
            this.EDataGridView.RowHeadersWidth = 82;
            this.EDataGridView.RowTemplate.DividerHeight = 1;
            this.EDataGridView.RowTemplate.Height = 37;
            this.EDataGridView.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.EDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.EDataGridView.Size = new System.Drawing.Size(277, 250);
            this.EDataGridView.TabIndex = 10;
            // 
            // name
            // 
            this.name.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.name.DataPropertyName = "name";
            this.name.FillWeight = 120F;
            this.name.HeaderText = "운동";
            this.name.MinimumWidth = 10;
            this.name.Name = "name";
            this.name.ReadOnly = true;
            // 
            // category
            // 
            this.category.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.category.DataPropertyName = "time";
            this.category.FillWeight = 80F;
            this.category.HeaderText = "시간";
            this.category.MinimumWidth = 10;
            this.category.Name = "category";
            this.category.ReadOnly = true;
            // 
            // calorie
            // 
            this.calorie.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.calorie.DataPropertyName = "kal";
            this.calorie.FillWeight = 80F;
            this.calorie.HeaderText = "kal";
            this.calorie.MinimumWidth = 10;
            this.calorie.Name = "calorie";
            this.calorie.ReadOnly = true;
            // 
            // statusUpdateButton
            // 
            this.statusUpdateButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(172)))), ((int)(((byte)(126)))), ((int)(((byte)(241)))));
            this.statusUpdateButton.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(172)))), ((int)(((byte)(126)))), ((int)(((byte)(241)))));
            this.statusUpdateButton.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.statusUpdateButton.BorderRadius = 0;
            this.statusUpdateButton.BorderSize = 0;
            this.statusUpdateButton.FlatAppearance.BorderSize = 0;
            this.statusUpdateButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.statusUpdateButton.ForeColor = System.Drawing.Color.White;
            this.statusUpdateButton.Location = new System.Drawing.Point(93, 469);
            this.statusUpdateButton.Name = "statusUpdateButton";
            this.statusUpdateButton.Size = new System.Drawing.Size(90, 35);
            this.statusUpdateButton.TabIndex = 4;
            this.statusUpdateButton.Text = "Update";
            this.statusUpdateButton.TextColor = System.Drawing.Color.White;
            this.statusUpdateButton.UseVisualStyleBackColor = false;
            this.statusUpdateButton.Click += new System.EventHandler(this.statusUpdateButton_Click);
            // 
            // FormHome
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.ClientSize = new System.Drawing.Size(962, 562);
            this.Controls.Add(this.exerciseGroup);
            this.Controls.Add(this.foodGroup);
            this.Controls.Add(this.totalKal);
            this.Controls.Add(this.exerciseKal);
            this.Controls.Add(this.foodKal);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.bodyGroupBox);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FormHome";
            this.Text = "FormHome";
            this.Load += new System.EventHandler(this.FormHome_Load);
            this.bodyGroupBox.ResumeLayout(false);
            this.bmiGroupBox.ResumeLayout(false);
            this.bodyFatGroupBox.ResumeLayout(false);
            this.bodyFatGroupBox.PerformLayout();
            this.weightGroupBox.ResumeLayout(false);
            this.weightGroupBox.PerformLayout();
            this.heightGroupBox.ResumeLayout(false);
            this.heightGroupBox.PerformLayout();
            this.foodGroup.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.FDataGridView)).EndInit();
            this.exerciseGroup.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.EDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox bodyGroupBox;
        private System.Windows.Forms.GroupBox bmiGroupBox;
        private System.Windows.Forms.GroupBox bodyFatGroupBox;
        private System.Windows.Forms.GroupBox weightGroupBox;
        private System.Windows.Forms.GroupBox heightGroupBox;
        private System.Windows.Forms.Label user;
        private System.Windows.Forms.Label KG;
        private System.Windows.Forms.Label cm;
        private System.Windows.Forms.TextBox height;
        private System.Windows.Forms.TextBox bodyFat;
        private System.Windows.Forms.Label percentage;
        private System.Windows.Forms.TextBox weight;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label foodKal;
        private System.Windows.Forms.Label exerciseKal;
        private System.Windows.Forms.Label totalKal;
        private System.Windows.Forms.Label bmi;
        private CustomControll.RoundButton statusUpdateButton;
        private System.Windows.Forms.GroupBox foodGroup;
        private System.Windows.Forms.GroupBox exerciseGroup;
        private System.Windows.Forms.DataGridView EDataGridView;
        private System.Windows.Forms.DataGridView FDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn name;
        private System.Windows.Forms.DataGridViewTextBoxColumn category;
        private System.Windows.Forms.DataGridViewTextBoxColumn calorie;
    }
}