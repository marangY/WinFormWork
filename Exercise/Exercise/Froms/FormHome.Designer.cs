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
            this.bodyFatGroupBox = new System.Windows.Forms.GroupBox();
            this.weightGroupBox = new System.Windows.Forms.GroupBox();
            this.heightGroupBox = new System.Windows.Forms.GroupBox();
            this.user = new System.Windows.Forms.Label();
            this.height = new System.Windows.Forms.TextBox();
            this.cm = new System.Windows.Forms.Label();
            this.KG = new System.Windows.Forms.Label();
            this.percentage = new System.Windows.Forms.Label();
            this.weight = new System.Windows.Forms.TextBox();
            this.bodyFat = new System.Windows.Forms.TextBox();
            this.bmi = new System.Windows.Forms.TextBox();
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
            // cm
            // 
            this.cm.AutoSize = true;
            this.cm.Location = new System.Drawing.Point(272, 31);
            this.cm.Name = "cm";
            this.cm.Size = new System.Drawing.Size(51, 29);
            this.cm.TabIndex = 1;
            this.cm.Text = "CM";
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
            // percentage
            // 
            this.percentage.AutoSize = true;
            this.percentage.Location = new System.Drawing.Point(290, 31);
            this.percentage.Name = "percentage";
            this.percentage.Size = new System.Drawing.Size(31, 29);
            this.percentage.TabIndex = 3;
            this.percentage.Text = "%";
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
            // FormHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.ClientSize = new System.Drawing.Size(1203, 674);
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
    }
}