namespace Training01
{
    partial class Form1
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.MenuBox = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuStart = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuStop = new System.Windows.Forms.ToolStripMenuItem();
            this.ManuExit = new System.Windows.Forms.ToolStripMenuItem();
            this.speedToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SpeedUp = new System.Windows.Forms.ToolStripMenuItem();
            this.SpeedDown = new System.Windows.Forms.ToolStripMenuItem();
            this.setParametersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.picBox = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.ParaPanel = new System.Windows.Forms.Panel();
            this.paraCheckBtn = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.textBoxWinY = new System.Windows.Forms.TextBox();
            this.textBoxWinX = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxMax = new System.Windows.Forms.TextBox();
            this.textBoxMin = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxNumStar = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBox)).BeginInit();
            this.ParaPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuBox,
            this.speedToolStripMenuItem,
            this.setParametersToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(834, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // MenuBox
            // 
            this.MenuBox.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuStart,
            this.MenuStop,
            this.ManuExit});
            this.MenuBox.Name = "MenuBox";
            this.MenuBox.Size = new System.Drawing.Size(50, 20);
            this.MenuBox.Text = "Menu";
            // 
            // MenuStart
            // 
            this.MenuStart.Name = "MenuStart";
            this.MenuStart.ShortcutKeyDisplayString = "Ctrl+Shift+Space";
            this.MenuStart.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.Space)));
            this.MenuStart.Size = new System.Drawing.Size(198, 22);
            this.MenuStart.Text = "Start";
            this.MenuStart.Click += new System.EventHandler(this.MenuStart_Click);
            // 
            // MenuStop
            // 
            this.MenuStop.Name = "MenuStop";
            this.MenuStop.ShortcutKeyDisplayString = "Ctrl+Shift+Pause";
            this.MenuStop.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.Pause)));
            this.MenuStop.Size = new System.Drawing.Size(198, 22);
            this.MenuStop.Text = "Stop";
            this.MenuStop.Click += new System.EventHandler(this.MenuStop_Click);
            // 
            // ManuExit
            // 
            this.ManuExit.Name = "ManuExit";
            this.ManuExit.ShortcutKeyDisplayString = "Ctrl+Shift+End";
            this.ManuExit.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.End)));
            this.ManuExit.Size = new System.Drawing.Size(198, 22);
            this.ManuExit.Text = "Exit";
            this.ManuExit.Click += new System.EventHandler(this.ManuExit_Click);
            // 
            // speedToolStripMenuItem
            // 
            this.speedToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.SpeedUp,
            this.SpeedDown});
            this.speedToolStripMenuItem.Name = "speedToolStripMenuItem";
            this.speedToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.speedToolStripMenuItem.Text = "Speed";
            // 
            // SpeedUp
            // 
            this.SpeedUp.Name = "SpeedUp";
            this.SpeedUp.ShortcutKeyDisplayString = "Ctrl+Shift+UpArrow";
            this.SpeedUp.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.Up)));
            this.SpeedUp.Size = new System.Drawing.Size(237, 22);
            this.SpeedUp.Text = "Up";
            this.SpeedUp.Click += new System.EventHandler(this.SpeedUp_Click);
            // 
            // SpeedDown
            // 
            this.SpeedDown.Name = "SpeedDown";
            this.SpeedDown.ShortcutKeyDisplayString = "Ctrl+Shift+DownArrow";
            this.SpeedDown.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.Down)));
            this.SpeedDown.Size = new System.Drawing.Size(237, 22);
            this.SpeedDown.Text = "Down";
            this.SpeedDown.Click += new System.EventHandler(this.SpeedDown_Click);
            // 
            // setParametersToolStripMenuItem
            // 
            this.setParametersToolStripMenuItem.Name = "setParametersToolStripMenuItem";
            this.setParametersToolStripMenuItem.Size = new System.Drawing.Size(99, 20);
            this.setParametersToolStripMenuItem.Text = "Set Parameters";
            this.setParametersToolStripMenuItem.Click += new System.EventHandler(this.setParametersToolStripMenuItem_Click);
            // 
            // picBox
            // 
            this.picBox.BackColor = System.Drawing.Color.Black;
            this.picBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.picBox.Location = new System.Drawing.Point(0, 24);
            this.picBox.Name = "picBox";
            this.picBox.Size = new System.Drawing.Size(834, 737);
            this.picBox.TabIndex = 1;
            this.picBox.TabStop = false;
            // 
            // timer1
            // 
            this.timer1.Interval = 1;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.Location = new System.Drawing.Point(3, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "Parameters";
            // 
            // ParaPanel
            // 
            this.ParaPanel.Controls.Add(this.paraCheckBtn);
            this.ParaPanel.Controls.Add(this.label1);
            this.ParaPanel.Controls.Add(this.label6);
            this.ParaPanel.Controls.Add(this.label7);
            this.ParaPanel.Controls.Add(this.textBoxWinY);
            this.ParaPanel.Controls.Add(this.textBoxWinX);
            this.ParaPanel.Controls.Add(this.label8);
            this.ParaPanel.Controls.Add(this.label5);
            this.ParaPanel.Controls.Add(this.label4);
            this.ParaPanel.Controls.Add(this.textBoxMax);
            this.ParaPanel.Controls.Add(this.textBoxMin);
            this.ParaPanel.Controls.Add(this.label3);
            this.ParaPanel.Controls.Add(this.textBoxNumStar);
            this.ParaPanel.Controls.Add(this.label2);
            this.ParaPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.ParaPanel.Location = new System.Drawing.Point(0, 24);
            this.ParaPanel.Name = "ParaPanel";
            this.ParaPanel.Size = new System.Drawing.Size(180, 737);
            this.ParaPanel.TabIndex = 3;
            // 
            // paraCheckBtn
            // 
            this.paraCheckBtn.Location = new System.Drawing.Point(96, 213);
            this.paraCheckBtn.Name = "paraCheckBtn";
            this.paraCheckBtn.Size = new System.Drawing.Size(75, 23);
            this.paraCheckBtn.TabIndex = 16;
            this.paraCheckBtn.Text = "Check";
            this.paraCheckBtn.UseVisualStyleBackColor = true;
            this.paraCheckBtn.Click += new System.EventHandler(this.paraCheckBtn_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("굴림", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label6.Location = new System.Drawing.Point(118, 185);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(13, 11);
            this.label6.TabIndex = 15;
            this.label6.Text = "Y";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("굴림", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label7.Location = new System.Drawing.Point(28, 185);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(13, 11);
            this.label7.TabIndex = 14;
            this.label7.Text = "X";
            // 
            // textBoxWinY
            // 
            this.textBoxWinY.Location = new System.Drawing.Point(137, 175);
            this.textBoxWinY.Name = "textBoxWinY";
            this.textBoxWinY.Size = new System.Drawing.Size(34, 21);
            this.textBoxWinY.TabIndex = 13;
            this.textBoxWinY.Text = "800";
            this.textBoxWinY.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBoxWinX
            // 
            this.textBoxWinX.Location = new System.Drawing.Point(47, 175);
            this.textBoxWinX.Name = "textBoxWinX";
            this.textBoxWinX.Size = new System.Drawing.Size(34, 21);
            this.textBoxWinX.TabIndex = 12;
            this.textBoxWinX.Text = "800";
            this.textBoxWinX.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("굴림", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label8.Location = new System.Drawing.Point(13, 159);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(87, 13);
            this.label8.TabIndex = 11;
            this.label8.Text = "Window Size";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("굴림", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label5.Location = new System.Drawing.Point(101, 125);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(30, 11);
            this.label5.TabIndex = 10;
            this.label5.Text = "Max.";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("굴림", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label4.Location = new System.Drawing.Point(14, 125);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(27, 11);
            this.label4.TabIndex = 9;
            this.label4.Text = "Min.";
            // 
            // textBoxMax
            // 
            this.textBoxMax.Location = new System.Drawing.Point(137, 115);
            this.textBoxMax.Name = "textBoxMax";
            this.textBoxMax.Size = new System.Drawing.Size(34, 21);
            this.textBoxMax.TabIndex = 8;
            this.textBoxMax.Text = "5";
            this.textBoxMax.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBoxMin
            // 
            this.textBoxMin.Location = new System.Drawing.Point(47, 115);
            this.textBoxMin.Name = "textBoxMin";
            this.textBoxMin.Size = new System.Drawing.Size(34, 21);
            this.textBoxMin.TabIndex = 7;
            this.textBoxMin.Text = "0";
            this.textBoxMin.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("굴림", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label3.Location = new System.Drawing.Point(13, 99);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Size of Stars";
            // 
            // textBoxNumStar
            // 
            this.textBoxNumStar.Location = new System.Drawing.Point(47, 63);
            this.textBoxNumStar.Name = "textBoxNumStar";
            this.textBoxNumStar.Size = new System.Drawing.Size(124, 21);
            this.textBoxNumStar.TabIndex = 5;
            this.textBoxNumStar.Text = "1000";
            this.textBoxNumStar.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("굴림", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label2.Location = new System.Drawing.Point(13, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Number of Stars";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(834, 761);
            this.Controls.Add(this.ParaPanel);
            this.Controls.Add(this.picBox);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Train #01";
            this.Shown += new System.EventHandler(this.Form1_Shown);
            this.SizeChanged += new System.EventHandler(this.Form1_SizeChanged);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBox)).EndInit();
            this.ParaPanel.ResumeLayout(false);
            this.ParaPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem MenuBox;
        private System.Windows.Forms.ToolStripMenuItem MenuStart;
        private System.Windows.Forms.ToolStripMenuItem MenuStop;
        private System.Windows.Forms.ToolStripMenuItem ManuExit;
        private System.Windows.Forms.PictureBox picBox;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ToolStripMenuItem speedToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem SpeedUp;
        private System.Windows.Forms.ToolStripMenuItem SpeedDown;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel ParaPanel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxMax;
        private System.Windows.Forms.TextBox textBoxMin;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxNumStar;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBoxWinY;
        private System.Windows.Forms.TextBox textBoxWinX;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ToolStripMenuItem setParametersToolStripMenuItem;
        private System.Windows.Forms.Button paraCheckBtn;
    }
}

