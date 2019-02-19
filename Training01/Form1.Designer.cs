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
            this.picBox = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.speedToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SpeedUp = new System.Windows.Forms.ToolStripMenuItem();
            this.SpeedDown = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBox)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuBox,
            this.speedToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(784, 24);
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
            this.MenuStart.ShortcutKeyDisplayString = "*";
            this.MenuStart.Size = new System.Drawing.Size(180, 22);
            this.MenuStart.Text = "Start";
            this.MenuStart.Click += new System.EventHandler(this.MenuStart_Click);
            // 
            // MenuStop
            // 
            this.MenuStop.Name = "MenuStop";
            this.MenuStop.ShortcutKeyDisplayString = "2";
            this.MenuStop.Size = new System.Drawing.Size(180, 22);
            this.MenuStop.Text = "Stop";
            this.MenuStop.Click += new System.EventHandler(this.MenuStop_Click);
            // 
            // ManuExit
            // 
            this.ManuExit.Name = "ManuExit";
            this.ManuExit.Size = new System.Drawing.Size(99, 22);
            this.ManuExit.Text = "Exit";
            // 
            // picBox
            // 
            this.picBox.BackColor = System.Drawing.Color.Black;
            this.picBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.picBox.Location = new System.Drawing.Point(0, 24);
            this.picBox.Name = "picBox";
            this.picBox.Size = new System.Drawing.Size(784, 737);
            this.picBox.TabIndex = 1;
            this.picBox.TabStop = false;
            // 
            // timer1
            // 
            this.timer1.Interval = 1;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
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
            this.SpeedUp.ShortcutKeyDisplayString = "+";
            this.SpeedUp.Size = new System.Drawing.Size(180, 22);
            this.SpeedUp.Text = "Up";
            this.SpeedUp.Click += new System.EventHandler(this.SpeedUp_Click);
            // 
            // SpeedDown
            // 
            this.SpeedDown.Name = "SpeedDown";
            this.SpeedDown.ShortcutKeyDisplayString = "-";
            this.SpeedDown.Size = new System.Drawing.Size(180, 22);
            this.SpeedDown.Text = "Down";
            this.SpeedDown.Click += new System.EventHandler(this.SpeedDown_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(784, 761);
            this.Controls.Add(this.picBox);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Train #01";
            this.Shown += new System.EventHandler(this.Form1_Shown);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBox)).EndInit();
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
    }
}

