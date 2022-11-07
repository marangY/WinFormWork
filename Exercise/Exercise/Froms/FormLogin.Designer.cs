namespace Exercise.Froms
{
    partial class FormLogin
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
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.txtPW = new System.Windows.Forms.TextBox();
            this.join = new System.Windows.Forms.Label();
            this.loginBtn = new Exercise.CustomControll.RoundButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txtID = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 28F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(520, 74);
            this.label1.Margin = new System.Windows.Forms.Padding(500, 0, 500, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(180, 65);
            this.label1.TabIndex = 18;
            this.label1.Text = "Login";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::Exercise.Properties.Resources.bar_Space;
            this.pictureBox3.Location = new System.Drawing.Point(445, 383);
            this.pictureBox3.Margin = new System.Windows.Forms.Padding(96, 70, 96, 0);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(330, 60);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 27;
            this.pictureBox3.TabStop = false;
            // 
            // txtPW
            // 
            this.txtPW.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.txtPW.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPW.Cursor = System.Windows.Forms.Cursors.No;
            this.txtPW.Font = new System.Drawing.Font("맑은 고딕", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.txtPW.ForeColor = System.Drawing.Color.White;
            this.txtPW.Location = new System.Drawing.Point(462, 396);
            this.txtPW.Margin = new System.Windows.Forms.Padding(110, 2, 110, 2);
            this.txtPW.MaxLength = 64;
            this.txtPW.Name = "txtPW";
            this.txtPW.Size = new System.Drawing.Size(300, 38);
            this.txtPW.TabIndex = 25;
            this.txtPW.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPW_KeyPress);
            // 
            // join
            // 
            this.join.AutoSize = true;
            this.join.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.join.ForeColor = System.Drawing.Color.IndianRed;
            this.join.Location = new System.Drawing.Point(805, 598);
            this.join.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.join.Name = "join";
            this.join.Size = new System.Drawing.Size(50, 24);
            this.join.TabIndex = 29;
            this.join.Text = "Join";
            this.join.Click += new System.EventHandler(this.join_Click);
            // 
            // loginBtn
            // 
            this.loginBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.loginBtn.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.loginBtn.BorderColor = System.Drawing.Color.White;
            this.loginBtn.BorderRadius = 20;
            this.loginBtn.BorderSize = 2;
            this.loginBtn.FlatAppearance.BorderSize = 0;
            this.loginBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.loginBtn.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loginBtn.ForeColor = System.Drawing.Color.White;
            this.loginBtn.Location = new System.Drawing.Point(520, 522);
            this.loginBtn.Margin = new System.Windows.Forms.Padding(511, 2, 511, 2);
            this.loginBtn.Name = "loginBtn";
            this.loginBtn.Size = new System.Drawing.Size(180, 50);
            this.loginBtn.TabIndex = 24;
            this.loginBtn.Text = "Login";
            this.loginBtn.TextColor = System.Drawing.Color.White;
            this.loginBtn.UseVisualStyleBackColor = false;
            this.loginBtn.Click += new System.EventHandler(this.loginBtn_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Exercise.Properties.Resources.bar_Space;
            this.pictureBox1.Location = new System.Drawing.Point(445, 266);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(96, 70, 96, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(330, 60);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 31;
            this.pictureBox1.TabStop = false;
            // 
            // txtID
            // 
            this.txtID.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.txtID.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtID.Cursor = System.Windows.Forms.Cursors.No;
            this.txtID.Font = new System.Drawing.Font("맑은 고딕", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.txtID.ForeColor = System.Drawing.Color.White;
            this.txtID.Location = new System.Drawing.Point(462, 280);
            this.txtID.Margin = new System.Windows.Forms.Padding(110, 2, 110, 2);
            this.txtID.MaxLength = 64;
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(300, 38);
            this.txtID.TabIndex = 32;
            this.txtID.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtID_KeyPress);
            // 
            // FormLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.ClientSize = new System.Drawing.Size(1202, 674);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.join);
            this.Controls.Add(this.txtPW);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.loginBtn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FormLogin";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.Text = "FormLogin";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private CustomControll.RoundButton loginBtn;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.TextBox txtPW;
        private System.Windows.Forms.Label join;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox txtID;
    }
}