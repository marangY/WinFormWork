namespace Exercise
{
    partial class FormMain
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.panelMenu = new System.Windows.Forms.Panel();
            this.logout = new System.Windows.Forms.Label();
            this.CalculatorBtn = new FontAwesome.Sharp.IconButton();
            this.ExerciseBtn = new FontAwesome.Sharp.IconButton();
            this.FoodBtn = new FontAwesome.Sharp.IconButton();
            this.RankBtn = new FontAwesome.Sharp.IconButton();
            this.HomeBtn = new FontAwesome.Sharp.IconButton();
            this.panelLogo = new System.Windows.Forms.Panel();
            this.Logo = new System.Windows.Forms.PictureBox();
            this.panelTitleBar = new System.Windows.Forms.Panel();
            this.MinimizeBtn = new System.Windows.Forms.PictureBox();
            this.CloseBtn = new System.Windows.Forms.PictureBox();
            this.idTitleChildFrom = new System.Windows.Forms.Label();
            this.iconCurrentChildForm = new FontAwesome.Sharp.IconPictureBox();
            this.panelShadow = new System.Windows.Forms.Panel();
            this.panelDeskTop = new System.Windows.Forms.Panel();
            this.date = new System.Windows.Forms.Label();
            this.clock = new System.Windows.Forms.Label();
            this.time = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.ScheduleBtn = new FontAwesome.Sharp.IconButton();
            this.panelMenu.SuspendLayout();
            this.panelLogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Logo)).BeginInit();
            this.panelTitleBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MinimizeBtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CloseBtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconCurrentChildForm)).BeginInit();
            this.panelDeskTop.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
            this.panelMenu.Controls.Add(this.ScheduleBtn);
            this.panelMenu.Controls.Add(this.logout);
            this.panelMenu.Controls.Add(this.CalculatorBtn);
            this.panelMenu.Controls.Add(this.ExerciseBtn);
            this.panelMenu.Controls.Add(this.FoodBtn);
            this.panelMenu.Controls.Add(this.RankBtn);
            this.panelMenu.Controls.Add(this.HomeBtn);
            this.panelMenu.Controls.Add(this.panelLogo);
            resources.ApplyResources(this.panelMenu, "panelMenu");
            this.panelMenu.ForeColor = System.Drawing.SystemColors.ControlText;
            this.panelMenu.Name = "panelMenu";
            // 
            // logout
            // 
            resources.ApplyResources(this.logout, "logout");
            this.logout.ForeColor = System.Drawing.Color.OrangeRed;
            this.logout.Name = "logout";
            this.logout.Click += new System.EventHandler(this.logout_Click);
            // 
            // CalculatorBtn
            // 
            resources.ApplyResources(this.CalculatorBtn, "CalculatorBtn");
            this.CalculatorBtn.FlatAppearance.BorderSize = 0;
            this.CalculatorBtn.ForeColor = System.Drawing.Color.White;
            this.CalculatorBtn.IconChar = FontAwesome.Sharp.IconChar.Calculator;
            this.CalculatorBtn.IconColor = System.Drawing.Color.White;
            this.CalculatorBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.CalculatorBtn.Name = "CalculatorBtn";
            this.CalculatorBtn.UseVisualStyleBackColor = true;
            this.CalculatorBtn.Click += new System.EventHandler(this.btnCalculator_Click);
            // 
            // ExerciseBtn
            // 
            resources.ApplyResources(this.ExerciseBtn, "ExerciseBtn");
            this.ExerciseBtn.FlatAppearance.BorderSize = 0;
            this.ExerciseBtn.ForeColor = System.Drawing.Color.White;
            this.ExerciseBtn.IconChar = FontAwesome.Sharp.IconChar.PersonWalking;
            this.ExerciseBtn.IconColor = System.Drawing.Color.White;
            this.ExerciseBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ExerciseBtn.Name = "ExerciseBtn";
            this.ExerciseBtn.UseVisualStyleBackColor = true;
            this.ExerciseBtn.Click += new System.EventHandler(this.btnExercise_Click);
            // 
            // FoodBtn
            // 
            resources.ApplyResources(this.FoodBtn, "FoodBtn");
            this.FoodBtn.FlatAppearance.BorderSize = 0;
            this.FoodBtn.ForeColor = System.Drawing.Color.White;
            this.FoodBtn.IconChar = FontAwesome.Sharp.IconChar.Apple;
            this.FoodBtn.IconColor = System.Drawing.Color.White;
            this.FoodBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.FoodBtn.Name = "FoodBtn";
            this.FoodBtn.UseVisualStyleBackColor = true;
            this.FoodBtn.Click += new System.EventHandler(this.btnFood_Click);
            // 
            // RankBtn
            // 
            resources.ApplyResources(this.RankBtn, "RankBtn");
            this.RankBtn.FlatAppearance.BorderSize = 0;
            this.RankBtn.ForeColor = System.Drawing.Color.White;
            this.RankBtn.IconChar = FontAwesome.Sharp.IconChar.RankingStar;
            this.RankBtn.IconColor = System.Drawing.Color.White;
            this.RankBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.RankBtn.Name = "RankBtn";
            this.RankBtn.UseVisualStyleBackColor = true;
            this.RankBtn.Click += new System.EventHandler(this.btnRanck_Click);
            // 
            // HomeBtn
            // 
            resources.ApplyResources(this.HomeBtn, "HomeBtn");
            this.HomeBtn.FlatAppearance.BorderSize = 0;
            this.HomeBtn.ForeColor = System.Drawing.Color.White;
            this.HomeBtn.IconChar = FontAwesome.Sharp.IconChar.Home;
            this.HomeBtn.IconColor = System.Drawing.Color.White;
            this.HomeBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.HomeBtn.Name = "HomeBtn";
            this.HomeBtn.UseVisualStyleBackColor = true;
            this.HomeBtn.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // panelLogo
            // 
            this.panelLogo.Controls.Add(this.Logo);
            resources.ApplyResources(this.panelLogo, "panelLogo");
            this.panelLogo.Name = "panelLogo";
            // 
            // Logo
            // 
            this.Logo.Image = global::Exercise.Properties.Resources.logo;
            resources.ApplyResources(this.Logo, "Logo");
            this.Logo.Name = "Logo";
            this.Logo.TabStop = false;
            this.Logo.Click += new System.EventHandler(this.Logo_Click);
            // 
            // panelTitleBar
            // 
            this.panelTitleBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(25)))), ((int)(((byte)(62)))));
            this.panelTitleBar.Controls.Add(this.MinimizeBtn);
            this.panelTitleBar.Controls.Add(this.CloseBtn);
            this.panelTitleBar.Controls.Add(this.idTitleChildFrom);
            this.panelTitleBar.Controls.Add(this.iconCurrentChildForm);
            resources.ApplyResources(this.panelTitleBar, "panelTitleBar");
            this.panelTitleBar.ForeColor = System.Drawing.SystemColors.ControlText;
            this.panelTitleBar.Name = "panelTitleBar";
            this.panelTitleBar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelTitleBar_MouseDown);
            // 
            // MinimizeBtn
            // 
            this.MinimizeBtn.Image = global::Exercise.Properties.Resources.Bar;
            resources.ApplyResources(this.MinimizeBtn, "MinimizeBtn");
            this.MinimizeBtn.Name = "MinimizeBtn";
            this.MinimizeBtn.TabStop = false;
            this.MinimizeBtn.Click += new System.EventHandler(this.MinimizeBtn_Click);
            // 
            // CloseBtn
            // 
            this.CloseBtn.Image = global::Exercise.Properties.Resources.Close;
            resources.ApplyResources(this.CloseBtn, "CloseBtn");
            this.CloseBtn.Name = "CloseBtn";
            this.CloseBtn.TabStop = false;
            this.CloseBtn.Click += new System.EventHandler(this.CloseBtn_Click);
            // 
            // idTitleChildFrom
            // 
            resources.ApplyResources(this.idTitleChildFrom, "idTitleChildFrom");
            this.idTitleChildFrom.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(25)))), ((int)(((byte)(62)))));
            this.idTitleChildFrom.Name = "idTitleChildFrom";
            this.idTitleChildFrom.TextChanged += new System.EventHandler(this.idTitleChildFrom_TextChanged);
            // 
            // iconCurrentChildForm
            // 
            this.iconCurrentChildForm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(25)))), ((int)(((byte)(62)))));
            this.iconCurrentChildForm.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.iconCurrentChildForm.IconChar = FontAwesome.Sharp.IconChar.User;
            this.iconCurrentChildForm.IconColor = System.Drawing.Color.DeepSkyBlue;
            this.iconCurrentChildForm.IconFont = FontAwesome.Sharp.IconFont.Auto;
            resources.ApplyResources(this.iconCurrentChildForm, "iconCurrentChildForm");
            this.iconCurrentChildForm.Name = "iconCurrentChildForm";
            this.iconCurrentChildForm.TabStop = false;
            // 
            // panelShadow
            // 
            this.panelShadow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(24)))), ((int)(((byte)(58)))));
            resources.ApplyResources(this.panelShadow, "panelShadow");
            this.panelShadow.Name = "panelShadow";
            // 
            // panelDeskTop
            // 
            this.panelDeskTop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.panelDeskTop.Controls.Add(this.date);
            this.panelDeskTop.Controls.Add(this.clock);
            this.panelDeskTop.Controls.Add(this.time);
            resources.ApplyResources(this.panelDeskTop, "panelDeskTop");
            this.panelDeskTop.Name = "panelDeskTop";
            // 
            // date
            // 
            resources.ApplyResources(this.date, "date");
            this.date.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.date.Name = "date";
            // 
            // clock
            // 
            resources.ApplyResources(this.clock, "clock");
            this.clock.ForeColor = System.Drawing.Color.White;
            this.clock.Name = "clock";
            // 
            // time
            // 
            resources.ApplyResources(this.time, "time");
            this.time.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.time.Name = "time";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // ScheduleBtn
            // 
            resources.ApplyResources(this.ScheduleBtn, "ScheduleBtn");
            this.ScheduleBtn.FlatAppearance.BorderSize = 0;
            this.ScheduleBtn.ForeColor = System.Drawing.Color.White;
            this.ScheduleBtn.IconChar = FontAwesome.Sharp.IconChar.CalendarPlus;
            this.ScheduleBtn.IconColor = System.Drawing.Color.White;
            this.ScheduleBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ScheduleBtn.Name = "ScheduleBtn";
            this.ScheduleBtn.UseVisualStyleBackColor = true;
            this.ScheduleBtn.Click += new System.EventHandler(this.ScheduleBtn_Click);
            // 
            // FormMain
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.Controls.Add(this.panelDeskTop);
            this.Controls.Add(this.panelShadow);
            this.Controls.Add(this.panelTitleBar);
            this.Controls.Add(this.panelMenu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormMain";
            this.panelMenu.ResumeLayout(false);
            this.panelMenu.PerformLayout();
            this.panelLogo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Logo)).EndInit();
            this.panelTitleBar.ResumeLayout(false);
            this.panelTitleBar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MinimizeBtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CloseBtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconCurrentChildForm)).EndInit();
            this.panelDeskTop.ResumeLayout(false);
            this.panelDeskTop.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelMenu;
        private FontAwesome.Sharp.IconButton CalculatorBtn;
        private FontAwesome.Sharp.IconButton ExerciseBtn;
        private FontAwesome.Sharp.IconButton RankBtn;
        private FontAwesome.Sharp.IconButton HomeBtn;
        private System.Windows.Forms.Panel panelLogo;
        private System.Windows.Forms.PictureBox Logo;
        private System.Windows.Forms.Panel panelTitleBar;
        private System.Windows.Forms.Panel panelShadow;
        private System.Windows.Forms.Panel panelDeskTop;
        private System.Windows.Forms.PictureBox CloseBtn;
        private System.Windows.Forms.PictureBox MinimizeBtn;
        private FontAwesome.Sharp.IconButton FoodBtn;
        public System.Windows.Forms.Label idTitleChildFrom;
        public System.Windows.Forms.Label time;
        private System.Windows.Forms.Label clock;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label date;
        public FontAwesome.Sharp.IconPictureBox iconCurrentChildForm;
        public System.Windows.Forms.Label logout;
        private FontAwesome.Sharp.IconButton ScheduleBtn;
    }
}

