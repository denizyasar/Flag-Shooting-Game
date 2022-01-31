namespace CinsFlags
{
    partial class frmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.tslMode = new System.Windows.Forms.ToolStripStatusLabel();
            this.tslServerAddress = new System.Windows.Forms.ToolStripStatusLabel();
            this.tslPort = new System.Windows.Forms.ToolStripStatusLabel();
            this.tslPlayerName = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tsbtnColorChoser = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.tsbtnNewGame = new System.Windows.Forms.ToolStripButton();
            this.txtLog = new System.Windows.Forms.TextBox();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.picboxAvrupa = new System.Windows.Forms.PictureBox();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.statusStrip1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picboxAvrupa)).BeginInit();
            this.SuspendLayout();
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tslMode,
            this.tslServerAddress,
            this.tslPort,
            this.tslPlayerName});
            this.statusStrip1.Location = new System.Drawing.Point(0, 483);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(995, 24);
            this.statusStrip1.SizingGrip = false;
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // tslMode
            // 
            this.tslMode.BorderSides = ((System.Windows.Forms.ToolStripStatusLabelBorderSides)((((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left | System.Windows.Forms.ToolStripStatusLabelBorderSides.Top) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Right) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom)));
            this.tslMode.BorderStyle = System.Windows.Forms.Border3DStyle.Bump;
            this.tslMode.Name = "tslMode";
            this.tslMode.Size = new System.Drawing.Size(48, 19);
            this.tslMode.Text = "Mode :";
            // 
            // tslServerAddress
            // 
            this.tslServerAddress.BorderSides = ((System.Windows.Forms.ToolStripStatusLabelBorderSides)((((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left | System.Windows.Forms.ToolStripStatusLabelBorderSides.Top) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Right) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom)));
            this.tslServerAddress.BorderStyle = System.Windows.Forms.Border3DStyle.Bump;
            this.tslServerAddress.Name = "tslServerAddress";
            this.tslServerAddress.Size = new System.Drawing.Size(94, 19);
            this.tslServerAddress.Text = "Server Address :";
            // 
            // tslPort
            // 
            this.tslPort.BorderSides = ((System.Windows.Forms.ToolStripStatusLabelBorderSides)((((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left | System.Windows.Forms.ToolStripStatusLabelBorderSides.Top) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Right) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom)));
            this.tslPort.BorderStyle = System.Windows.Forms.Border3DStyle.Bump;
            this.tslPort.Name = "tslPort";
            this.tslPort.Size = new System.Drawing.Size(39, 19);
            this.tslPort.Text = "Port :";
            // 
            // tslPlayerName
            // 
            this.tslPlayerName.BorderSides = ((System.Windows.Forms.ToolStripStatusLabelBorderSides)((((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left | System.Windows.Forms.ToolStripStatusLabelBorderSides.Top) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Right) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom)));
            this.tslPlayerName.BorderStyle = System.Windows.Forms.Border3DStyle.Bump;
            this.tslPlayerName.Name = "tslPlayerName";
            this.tslPlayerName.Size = new System.Drawing.Size(84, 19);
            this.tslPlayerName.Text = "Player Name :";
            // 
            // toolStrip1
            // 
            this.toolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbtnColorChoser,
            this.toolStripSeparator1,
            this.tsbtnNewGame});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.toolStrip1.Size = new System.Drawing.Size(995, 25);
            this.toolStrip1.TabIndex = 2;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // tsbtnColorChoser
            // 
            this.tsbtnColorChoser.Image = global::CinsFlags.Properties.Resources.colors;
            this.tsbtnColorChoser.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtnColorChoser.Name = "tsbtnColorChoser";
            this.tsbtnColorChoser.Size = new System.Drawing.Size(83, 22);
            this.tsbtnColorChoser.Text = "Area Color";
            this.tsbtnColorChoser.Click += new System.EventHandler(this.tsbtnColorChoser_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // tsbtnNewGame
            // 
            this.tsbtnNewGame.Image = global::CinsFlags.Properties.Resources.NewGame;
            this.tsbtnNewGame.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtnNewGame.Name = "tsbtnNewGame";
            this.tsbtnNewGame.Size = new System.Drawing.Size(85, 22);
            this.tsbtnNewGame.Text = "New Game";
            this.tsbtnNewGame.Click += new System.EventHandler(this.tsbtnNewGame_Click);
            // 
            // txtLog
            // 
            this.txtLog.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtLog.Location = new System.Drawing.Point(0, 0);
            this.txtLog.Multiline = true;
            this.txtLog.Name = "txtLog";
            this.txtLog.ReadOnly = true;
            this.txtLog.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtLog.Size = new System.Drawing.Size(187, 458);
            this.txtLog.TabIndex = 3;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 25);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.txtLog);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.picboxAvrupa);
            this.splitContainer1.Size = new System.Drawing.Size(995, 458);
            this.splitContainer1.SplitterDistance = 187;
            this.splitContainer1.TabIndex = 4;
            // 
            // picboxAvrupa
            // 
            this.picboxAvrupa.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.picboxAvrupa.Dock = System.Windows.Forms.DockStyle.Fill;
            this.picboxAvrupa.Image = global::CinsFlags.Properties.Resources.AvrupaHaritasi;
            this.picboxAvrupa.Location = new System.Drawing.Point(0, 0);
            this.picboxAvrupa.Name = "picboxAvrupa";
            this.picboxAvrupa.Size = new System.Drawing.Size(804, 458);
            this.picboxAvrupa.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picboxAvrupa.TabIndex = 0;
            this.picboxAvrupa.TabStop = false;
            this.picboxAvrupa.Paint += new System.Windows.Forms.PaintEventHandler(this.picboxAvrupa_Paint);
            this.picboxAvrupa.MouseClick += new System.Windows.Forms.MouseEventHandler(this.picboxAvrupa_MouseClick);
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(118, 17);
            this.toolStripStatusLabel1.Text = "toolStripStatusLabel1";
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(995, 507);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.statusStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmMain";
            this.Text = "CinsFlags Game via TCP/IP";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmMain_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmMain_FormClosed);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picboxAvrupa)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picboxAvrupa;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel tslServerAddress;
        private System.Windows.Forms.ToolStripStatusLabel tslPlayerName;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.TextBox txtLog;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.ToolStripButton tsbtnColorChoser;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton tsbtnNewGame;
        private System.Windows.Forms.ToolStripStatusLabel tslMode;
        private System.Windows.Forms.ToolStripStatusLabel tslPort;
    }
}