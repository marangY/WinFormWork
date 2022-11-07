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
            this.bodyGroupBox = new System.Windows.Forms.GroupBox();
            this.bmiGroupBox = new System.Windows.Forms.GroupBox();
            this.bmi = new System.Windows.Forms.TextBox();
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
            this.bodyGroupBox.SuspendLayout();
            this.bmiGroupBox.SuspendLayout();
            this.bodyFatGroupBox.SuspendLayout();
            this.weightGroupBox.SuspendLayout();
            this.heightGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // bodyGroupBox
            // 
            this.bodyGroupBox.Controls.Add(this.bmiGroupBox);
            this.bodyGroupBox.Controls.Add(this.bodyFatGroupBox);
            this.bodyGroupBox.Controls.Add(this.weightGroupBox);
            this.bodyGroupBox.Controls.Add(this.heightGroupBox);
            this.bodyGroupBox.Controls.Add(this.user);
            this.bodyGroupBox.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bodyGroupBox.ForeColor = System.Drawing.Color.White;
            this.bodyGroupBox.Location = new System.Drawing.Point(39, 39);
            this.bodyGroupBox.Margin = new System.Windows.Forms.Padding(30, 30, 3, 3);
            this.bodyGroupBox.Name = "bodyGroupBox";
            this.bodyGroupBox.Size = new System.Drawing.Size(350, 600);
            this.bodyGroupBox.TabIndex = 0;
            this.bodyGroupBox.TabStop = false;
            this.bodyGroupBox.Text = "Body Status";
            // 
            // bmiGroupBox
            // 
            this.bmiGroupBox.Controls.Add(this.bmi);
            this.bmiGroupBox.ForeColor = System.Drawing.Color.White;
            this.bmiGroupBox.Location = new System.Drawing.Point(8, 496);
            this.bmiGroupBox.Margin = new System.Windows.Forms.Padding(5, 50, 5, 0);
            this.bmiGroupBox.Name = "bmiGroupBox";
            this.bmiGroupBox.Size = new System.Drawing.Size(329, 72);
            this.bmiGroupBox.TabIndex = 3;
            this.bmiGroupBox.TabStop = false;
            this.bmiGroupBox.Text = "BMI";
            // 
            // bmi
            // 
            this.bmi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.bmi.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.bmi.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bmi.ForeColor = System.Drawing.Color.White;
            this.bmi.Location = new System.Drawing.Point(5, 34);
            this.bmi.Name = "bmi";
            this.bmi.Size = new System.Drawing.Size(260, 33);
            this.bmi.TabIndex = 1;
            this.bmi.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // bodyFatGroupBox
            // 
            this.bodyFatGroupBox.Controls.Add(this.bodyFat);
            this.bodyFatGroupBox.Controls.Add(this.percentage);
            this.bodyFatGroupBox.ForeColor = System.Drawing.Color.White;
            this.bodyFatGroupBox.Location = new System.Drawing.Point(8, 374);
            this.bodyFatGroupBox.Margin = new System.Windows.Forms.Padding(5, 50, 5, 0);
            this.bodyFatGroupBox.Name = "bodyFatGroupBox";
            this.bodyFatGroupBox.Size = new System.Drawing.Size(329, 72);
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
            this.bodyFat.Location = new System.Drawing.Point(6, 34);
            this.bodyFat.Name = "bodyFat";
            this.bodyFat.Size = new System.Drawing.Size(260, 33);
            this.bodyFat.TabIndex = 4;
            this.bodyFat.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // percentage
            // 
            this.percentage.AutoSize = true;
            this.percentage.Location = new System.Drawing.Point(290, 31);
            this.percentage.Name = "percentage";
            this.percentage.Size = new System.Drawing.Size(31, 29);
            this.percentage.TabIndex = 3;
            this.percentage.Text = "%";
            // 
            // weightGroupBox
            // 
            this.weightGroupBox.Controls.Add(this.weight);
            this.weightGroupBox.Controls.Add(this.KG);
            this.weightGroupBox.ForeColor = System.Drawing.Color.White;
            this.weightGroupBox.Location = new System.Drawing.Point(8, 252);
            this.weightGroupBox.Margin = new System.Windows.Forms.Padding(5, 50, 5, 0);
            this.weightGroupBox.Name = "weightGroupBox";
            this.weightGroupBox.Size = new System.Drawing.Size(329, 72);
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
            this.weight.Location = new System.Drawing.Point(5, 34);
            this.weight.Name = "weight";
            this.weight.Size = new System.Drawing.Size(260, 33);
            this.weight.TabIndex = 3;
            this.weight.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // KG
            // 
            this.KG.AutoSize = true;
            this.KG.Location = new System.Drawing.Point(272, 31);
            this.KG.Name = "KG";
            this.KG.Size = new System.Drawing.Size(49, 29);
            this.KG.TabIndex = 2;
            this.KG.Text = "KG";
            // 
            // heightGroupBox
            // 
            this.heightGroupBox.Controls.Add(this.cm);
            this.heightGroupBox.Controls.Add(this.height);
            this.heightGroupBox.ForeColor = System.Drawing.Color.White;
            this.heightGroupBox.Location = new System.Drawing.Point(8, 130);
            this.heightGroupBox.Margin = new System.Windows.Forms.Padding(5, 50, 5, 0);
            this.heightGroupBox.Name = "heightGroupBox";
            this.heightGroupBox.Size = new System.Drawing.Size(329, 72);
            this.heightGroupBox.TabIndex = 1;
            this.heightGroupBox.TabStop = false;
            this.heightGroupBox.Text = "Height";
            // 
            // cm
            // 
            this.cm.AutoSize = true;
            this.cm.Location = new System.Drawing.Point(272, 31);
            this.cm.Name = "cm";
            this.cm.Size = new System.Drawing.Size(51, 29);
            this.cm.TabIndex = 1;
            this.cm.Text = "CM";
            // 
            // height
            // 
            this.height.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.height.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.height.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.height.ForeColor = System.Drawing.Color.White;
            this.height.Location = new System.Drawing.Point(5, 34);
            this.height.Name = "height";
            this.height.Size = new System.Drawing.Size(260, 33);
            this.height.TabIndex = 0;
            this.height.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // user
            // 
            this.user.AutoSize = true;
            this.user.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(172)))), ((int)(((byte)(126)))), ((int)(((byte)(241)))));
            this.user.Location = new System.Drawing.Point(112, 51);
            this.user.Margin = new System.Windows.Forms.Padding(5, 20, 3, 0);
            this.user.Name = "user";
            this.user.Size = new System.Drawing.Size(125, 29);
            this.user.TabIndex = 1;
            this.user.Text = "username";
            this.user.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(172)))), ((int)(((byte)(126)))), ((int)(((byte)(241)))));
            this.label1.Location = new System.Drawing.Point(556, 39);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 20, 3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 37);
            this.label1.TabIndex = 4;
            this.label1.Text = "Today";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(138)))), ((int)(((byte)(114)))));
            this.label2.Location = new System.Drawing.Point(556, 169);
            this.label2.Margin = new System.Windows.Forms.Padding(5, 20, 3, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(232, 37);
            this.label2.TabIndex = 5;
            this.label2.Text = "Food Calories";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(77)))), ((int)(((byte)(221)))));
            this.label3.Location = new System.Drawing.Point(556, 314);
            this.label3.Margin = new System.Windows.Forms.Padding(5, 20, 3, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(289, 37);
            this.label3.TabIndex = 6;
            this.label3.Text = "Exercise Calories";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(172)))), ((int)(((byte)(126)))), ((int)(((byte)(241)))));
            this.label4.Location = new System.Drawing.Point(556, 465);
            this.label4.Margin = new System.Windows.Forms.Padding(5, 20, 3, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(231, 37);
            this.label4.TabIndex = 7;
            this.label4.Text = "Total Calories";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // foodKal
            // 
            this.foodKal.AutoSize = true;
            this.foodKal.Font = new System.Drawing.Font("Arial", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.foodKal.ForeColor = System.Drawing.Color.Khaki;
            this.foodKal.Location = new System.Drawing.Point(945, 169);
            this.foodKal.Margin = new System.Windows.Forms.Padding(5, 20, 3, 0);
            this.foodKal.Name = "foodKal";
            this.foodKal.Size = new System.Drawing.Size(99, 37);
            this.foodKal.TabIndex = 8;
            this.foodKal.Text = "0  kal";
            this.foodKal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // exerciseKal
            // 
            this.exerciseKal.AutoSize = true;
            this.exerciseKal.Font = new System.Drawing.Font("Arial", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exerciseKal.ForeColor = System.Drawing.Color.Khaki;
            this.exerciseKal.Location = new System.Drawing.Point(945, 314);
            this.exerciseKal.Margin = new System.Windows.Forms.Padding(5, 20, 3, 0);
            this.exerciseKal.Name = "exerciseKal";
            this.exerciseKal.Size = new System.Drawing.Size(99, 37);
            this.exerciseKal.TabIndex = 9;
            this.exerciseKal.Text = "0  kal";
            this.exerciseKal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // totalKal
            // 
            this.totalKal.AutoSize = true;
            this.totalKal.Font = new System.Drawing.Font("Arial", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalKal.ForeColor = System.Drawing.Color.Khaki;
            this.totalKal.Location = new System.Drawing.Point(945, 465);
            this.totalKal.Margin = new System.Windows.Forms.Padding(5, 20, 3, 0);
            this.totalKal.Name = "totalKal";
            this.totalKal.Size = new System.Drawing.Size(99, 37);
            this.totalKal.TabIndex = 10;
            this.totalKal.Text = "0  kal";
            this.totalKal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FormHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.ClientSize = new System.Drawing.Size(1203, 674);
            this.Controls.Add(this.totalKal);
            this.Controls.Add(this.exerciseKal);
            this.Controls.Add(this.foodKal);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.bodyGroupBox);
            this.Name = "FormHome";
            this.Text = "FormHome";
            this.Load += new System.EventHandler(this.FormHome_Load);
            this.bodyGroupBox.ResumeLayout(false);
            this.bodyGroupBox.PerformLayout();
            this.bmiGroupBox.ResumeLayout(false);
            this.bmiGroupBox.PerformLayout();
            this.bodyFatGroupBox.ResumeLayout(false);
            this.bodyFatGroupBox.PerformLayout();
            this.weightGroupBox.ResumeLayout(false);
            this.weightGroupBox.PerformLayout();
            this.heightGroupBox.ResumeLayout(false);
            this.heightGroupBox.PerformLayout();
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
        private System.Windows.Forms.TextBox bmi;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label foodKal;
        private System.Windows.Forms.Label exerciseKal;
        private System.Windows.Forms.Label totalKal;
    }
}