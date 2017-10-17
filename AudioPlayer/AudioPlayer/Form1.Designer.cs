namespace AudioPlayer
{
    partial class home
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
            this.button2 = new System.Windows.Forms.Button();
            this.Modify = new System.Windows.Forms.Button();
            this.sourceFileTexBox = new System.Windows.Forms.TextBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.convertedFileTextbox = new System.Windows.Forms.TextBox();
            this.waveViewer1 = new NAudio.Gui.WaveViewer();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.loadWAVToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.selectFormatToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mp3ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.flacToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.oggToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.wavToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.selectRateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kHzToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kHZToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.kHZToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.kHZToolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.kHZToolStripMenuItem4 = new System.Windows.Forms.ToolStripMenuItem();
            this.kHZToolStripMenuItem5 = new System.Windows.Forms.ToolStripMenuItem();
            this.selectBitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem4 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem5 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem6 = new System.Windows.Forms.ToolStripMenuItem();
            this.selectChanelsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem7 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem8 = new System.Windows.Forms.ToolStripMenuItem();
            this.waveViewer3 = new NAudio.Gui.WaveViewer();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(2, 125);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(136, 50);
            this.button2.TabIndex = 1;
            this.button2.Text = "Play/Stop";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Modify
            // 
            this.Modify.Location = new System.Drawing.Point(12, 207);
            this.Modify.Name = "Modify";
            this.Modify.Size = new System.Drawing.Size(136, 52);
            this.Modify.TabIndex = 9;
            this.Modify.Text = "Modify";
            this.Modify.UseVisualStyleBackColor = true;
            this.Modify.Click += new System.EventHandler(this.Modify_Click);
            // 
            // sourceFileTexBox
            // 
            this.sourceFileTexBox.Location = new System.Drawing.Point(2, 81);
            this.sourceFileTexBox.Name = "sourceFileTexBox";
            this.sourceFileTexBox.Size = new System.Drawing.Size(257, 38);
            this.sourceFileTexBox.TabIndex = 10;
            // 
            // convertedFileTextbox
            // 
            this.convertedFileTextbox.Location = new System.Drawing.Point(0, 289);
            this.convertedFileTextbox.Name = "convertedFileTextbox";
            this.convertedFileTextbox.Size = new System.Drawing.Size(259, 38);
            this.convertedFileTextbox.TabIndex = 12;
            // 
            // waveViewer1
            // 
            this.waveViewer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.waveViewer1.Location = new System.Drawing.Point(295, 72);
            this.waveViewer1.Name = "waveViewer1";
            this.waveViewer1.SamplesPerPixel = 128;
            this.waveViewer1.Size = new System.Drawing.Size(944, 276);
            this.waveViewer1.StartPosition = ((long)(0));
            this.waveViewer1.TabIndex = 14;
            this.waveViewer1.WaveStream = null;
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(40, 40);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.selectFormatToolStripMenuItem,
            this.selectRateToolStripMenuItem,
            this.selectBitToolStripMenuItem,
            this.selectChanelsToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1251, 49);
            this.menuStrip1.TabIndex = 16;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.loadWAVToolStripMenuItem});
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(136, 45);
            this.toolStripMenuItem1.Text = "Options";
            // 
            // loadWAVToolStripMenuItem
            // 
            this.loadWAVToolStripMenuItem.Name = "loadWAVToolStripMenuItem";
            this.loadWAVToolStripMenuItem.Size = new System.Drawing.Size(268, 46);
            this.loadWAVToolStripMenuItem.Text = "Load WAV";
            this.loadWAVToolStripMenuItem.Click += new System.EventHandler(this.loadWAVToolStripMenuItem_Click);
            // 
            // selectFormatToolStripMenuItem
            // 
            this.selectFormatToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mp3ToolStripMenuItem,
            this.flacToolStripMenuItem,
            this.oggToolStripMenuItem,
            this.wavToolStripMenuItem});
            this.selectFormatToolStripMenuItem.Name = "selectFormatToolStripMenuItem";
            this.selectFormatToolStripMenuItem.Size = new System.Drawing.Size(205, 45);
            this.selectFormatToolStripMenuItem.Text = "Select format";
            // 
            // mp3ToolStripMenuItem
            // 
            this.mp3ToolStripMenuItem.Name = "mp3ToolStripMenuItem";
            this.mp3ToolStripMenuItem.Size = new System.Drawing.Size(192, 46);
            this.mp3ToolStripMenuItem.Text = "mp3";
            this.mp3ToolStripMenuItem.Click += new System.EventHandler(this.mp3ToolStripMenuItem_Click);
            // 
            // flacToolStripMenuItem
            // 
            this.flacToolStripMenuItem.Name = "flacToolStripMenuItem";
            this.flacToolStripMenuItem.Size = new System.Drawing.Size(192, 46);
            this.flacToolStripMenuItem.Text = "flac";
            this.flacToolStripMenuItem.Click += new System.EventHandler(this.flacToolStripMenuItem_Click);
            // 
            // oggToolStripMenuItem
            // 
            this.oggToolStripMenuItem.Name = "oggToolStripMenuItem";
            this.oggToolStripMenuItem.Size = new System.Drawing.Size(192, 46);
            this.oggToolStripMenuItem.Text = "ogg";
            this.oggToolStripMenuItem.Click += new System.EventHandler(this.oggToolStripMenuItem_Click);
            // 
            // wavToolStripMenuItem
            // 
            this.wavToolStripMenuItem.Name = "wavToolStripMenuItem";
            this.wavToolStripMenuItem.Size = new System.Drawing.Size(192, 46);
            this.wavToolStripMenuItem.Text = "wav";
            this.wavToolStripMenuItem.Click += new System.EventHandler(this.wavToolStripMenuItem_Click);
            // 
            // selectRateToolStripMenuItem
            // 
            this.selectRateToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.kHzToolStripMenuItem,
            this.kHZToolStripMenuItem1,
            this.kHZToolStripMenuItem2,
            this.kHZToolStripMenuItem3,
            this.kHZToolStripMenuItem4,
            this.kHZToolStripMenuItem5});
            this.selectRateToolStripMenuItem.Name = "selectRateToolStripMenuItem";
            this.selectRateToolStripMenuItem.Size = new System.Drawing.Size(168, 45);
            this.selectRateToolStripMenuItem.Text = "Select rate";
            // 
            // kHzToolStripMenuItem
            // 
            this.kHzToolStripMenuItem.Name = "kHzToolStripMenuItem";
            this.kHzToolStripMenuItem.Size = new System.Drawing.Size(264, 46);
            this.kHzToolStripMenuItem.Text = "8 kHz";
            // 
            // kHZToolStripMenuItem1
            // 
            this.kHZToolStripMenuItem1.Name = "kHZToolStripMenuItem1";
            this.kHZToolStripMenuItem1.Size = new System.Drawing.Size(264, 46);
            this.kHZToolStripMenuItem1.Text = "16 kHz";
            // 
            // kHZToolStripMenuItem2
            // 
            this.kHZToolStripMenuItem2.Name = "kHZToolStripMenuItem2";
            this.kHZToolStripMenuItem2.Size = new System.Drawing.Size(264, 46);
            this.kHZToolStripMenuItem2.Text = "22.05 kHZ";
            // 
            // kHZToolStripMenuItem3
            // 
            this.kHZToolStripMenuItem3.Name = "kHZToolStripMenuItem3";
            this.kHZToolStripMenuItem3.Size = new System.Drawing.Size(264, 46);
            this.kHZToolStripMenuItem3.Text = "32 kHZ";
            // 
            // kHZToolStripMenuItem4
            // 
            this.kHZToolStripMenuItem4.Name = "kHZToolStripMenuItem4";
            this.kHZToolStripMenuItem4.Size = new System.Drawing.Size(264, 46);
            this.kHZToolStripMenuItem4.Text = "44.1 kHZ";
            // 
            // kHZToolStripMenuItem5
            // 
            this.kHZToolStripMenuItem5.Name = "kHZToolStripMenuItem5";
            this.kHZToolStripMenuItem5.Size = new System.Drawing.Size(264, 46);
            this.kHZToolStripMenuItem5.Text = "48 kHZ";
            // 
            // selectBitToolStripMenuItem
            // 
            this.selectBitToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem3,
            this.toolStripMenuItem4,
            this.toolStripMenuItem5,
            this.toolStripMenuItem6});
            this.selectBitToolStripMenuItem.Name = "selectBitToolStripMenuItem";
            this.selectBitToolStripMenuItem.Size = new System.Drawing.Size(152, 45);
            this.selectBitToolStripMenuItem.Text = "Select bit";
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(164, 46);
            this.toolStripMenuItem3.Text = "8";
            // 
            // toolStripMenuItem4
            // 
            this.toolStripMenuItem4.Name = "toolStripMenuItem4";
            this.toolStripMenuItem4.Size = new System.Drawing.Size(164, 46);
            this.toolStripMenuItem4.Text = "16";
            // 
            // toolStripMenuItem5
            // 
            this.toolStripMenuItem5.Name = "toolStripMenuItem5";
            this.toolStripMenuItem5.Size = new System.Drawing.Size(164, 46);
            this.toolStripMenuItem5.Text = "24";
            // 
            // toolStripMenuItem6
            // 
            this.toolStripMenuItem6.Name = "toolStripMenuItem6";
            this.toolStripMenuItem6.Size = new System.Drawing.Size(164, 46);
            this.toolStripMenuItem6.Text = "32";
            // 
            // selectChanelsToolStripMenuItem
            // 
            this.selectChanelsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem7,
            this.toolStripMenuItem8});
            this.selectChanelsToolStripMenuItem.Name = "selectChanelsToolStripMenuItem";
            this.selectChanelsToolStripMenuItem.Size = new System.Drawing.Size(221, 45);
            this.selectChanelsToolStripMenuItem.Text = "Select Chanels";
            // 
            // toolStripMenuItem7
            // 
            this.toolStripMenuItem7.Name = "toolStripMenuItem7";
            this.toolStripMenuItem7.Size = new System.Drawing.Size(148, 46);
            this.toolStripMenuItem7.Text = "1";
            // 
            // toolStripMenuItem8
            // 
            this.toolStripMenuItem8.Name = "toolStripMenuItem8";
            this.toolStripMenuItem8.Size = new System.Drawing.Size(148, 46);
            this.toolStripMenuItem8.Text = "2";
            // 
            // waveViewer3
            // 
            this.waveViewer3.BackColor = System.Drawing.SystemColors.Window;
            this.waveViewer3.ForeColor = System.Drawing.SystemColors.Highlight;
            this.waveViewer3.Location = new System.Drawing.Point(295, 354);
            this.waveViewer3.Name = "waveViewer3";
            this.waveViewer3.SamplesPerPixel = 128;
            this.waveViewer3.Size = new System.Drawing.Size(944, 266);
            this.waveViewer3.StartPosition = ((long)(0));
            this.waveViewer3.TabIndex = 18;
            this.waveViewer3.WaveStream = null;
            // 
            // home
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.ClientSize = new System.Drawing.Size(1251, 647);
            this.Controls.Add(this.waveViewer3);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.waveViewer1);
            this.Controls.Add(this.convertedFileTextbox);
            this.Controls.Add(this.sourceFileTexBox);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.Modify);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "home";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.home_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button Modify;
        private System.Windows.Forms.TextBox sourceFileTexBox;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.TextBox convertedFileTextbox;
        private NAudio.Gui.WaveViewer waveViewer1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem loadWAVToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem selectFormatToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mp3ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem flacToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem oggToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem wavToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem selectRateToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kHzToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kHZToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem kHZToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem kHZToolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem kHZToolStripMenuItem4;
        private System.Windows.Forms.ToolStripMenuItem kHZToolStripMenuItem5;
        private System.Windows.Forms.ToolStripMenuItem selectBitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem4;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem5;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem6;
        private System.Windows.Forms.ToolStripMenuItem selectChanelsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem7;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem8;
        private NAudio.Gui.WaveViewer waveViewer3;
    }
}

