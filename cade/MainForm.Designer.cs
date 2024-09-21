namespace cade
{
    partial class MainForm
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            btnProgram = new Button();
            gbFilePath = new GroupBox();
            txtFilePath = new TextBox();
            btnBrowse = new Button();
            gpPort = new GroupBox();
            cmbPort = new ComboBox();
            gpDevice = new GroupBox();
            cmbMCU = new ComboBox();
            openFileDialog1 = new OpenFileDialog();
            rtxtConsole = new RichTextBox();
            contextMenuStrip1 = new ContextMenuStrip(components);
            清空ToolStripMenuItem = new ToolStripMenuItem();
            ckbAdv = new CheckBox();
            gpAdv = new GroupBox();
            ckbRead = new CheckBox();
            cmbFormat = new ComboBox();
            ckbEEPROM = new CheckBox();
            btnErase = new Button();
            btnHelp = new Button();
            gbFilePath.SuspendLayout();
            gpPort.SuspendLayout();
            gpDevice.SuspendLayout();
            contextMenuStrip1.SuspendLayout();
            gpAdv.SuspendLayout();
            SuspendLayout();
            // 
            // btnProgram
            // 
            btnProgram.Location = new Point(482, 87);
            btnProgram.Margin = new Padding(5, 5, 5, 5);
            btnProgram.Name = "btnProgram";
            btnProgram.Size = new Size(171, 71);
            btnProgram.TabIndex = 2;
            btnProgram.Text = "FLASH";
            btnProgram.UseVisualStyleBackColor = true;
            btnProgram.Click += btnProgram_Click;
            // 
            // gbFilePath
            // 
            gbFilePath.Controls.Add(txtFilePath);
            gbFilePath.Controls.Add(btnBrowse);
            gbFilePath.Location = new Point(19, 12);
            gbFilePath.Margin = new Padding(5, 5, 5, 5);
            gbFilePath.Name = "gbFilePath";
            gbFilePath.Padding = new Padding(5, 5, 5, 5);
            gbFilePath.Size = new Size(634, 71);
            gbFilePath.TabIndex = 5;
            gbFilePath.TabStop = false;
            gbFilePath.Text = "Flash/EEPROM";
            // 
            // txtFilePath
            // 
            txtFilePath.AcceptsTab = true;
            txtFilePath.Location = new Point(10, 27);
            txtFilePath.Margin = new Padding(5, 5, 5, 5);
            txtFilePath.Name = "txtFilePath";
            txtFilePath.Size = new Size(499, 27);
            txtFilePath.TabIndex = 3;
            // 
            // btnBrowse
            // 
            btnBrowse.Location = new Point(543, 27);
            btnBrowse.Margin = new Padding(5, 5, 5, 5);
            btnBrowse.Name = "btnBrowse";
            btnBrowse.Size = new Size(69, 27);
            btnBrowse.TabIndex = 2;
            btnBrowse.Text = "...";
            btnBrowse.UseVisualStyleBackColor = true;
            btnBrowse.Click += btnBrowse_Click;
            // 
            // gpPort
            // 
            gpPort.Controls.Add(cmbPort);
            gpPort.Location = new Point(19, 87);
            gpPort.Margin = new Padding(5, 5, 5, 5);
            gpPort.Name = "gpPort";
            gpPort.Padding = new Padding(5, 5, 5, 5);
            gpPort.Size = new Size(147, 71);
            gpPort.TabIndex = 6;
            gpPort.TabStop = false;
            gpPort.Text = "Port";
            // 
            // cmbPort
            // 
            cmbPort.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbPort.FormattingEnabled = true;
            cmbPort.Location = new Point(9, 25);
            cmbPort.Margin = new Padding(5, 5, 5, 5);
            cmbPort.Name = "cmbPort";
            cmbPort.Size = new Size(127, 28);
            cmbPort.TabIndex = 4;
            // 
            // gpDevice
            // 
            gpDevice.Controls.Add(cmbMCU);
            gpDevice.Location = new Point(179, 87);
            gpDevice.Margin = new Padding(5, 5, 5, 5);
            gpDevice.Name = "gpDevice";
            gpDevice.Padding = new Padding(5, 5, 5, 5);
            gpDevice.Size = new Size(203, 71);
            gpDevice.TabIndex = 7;
            gpDevice.TabStop = false;
            gpDevice.Text = "Device";
            // 
            // cmbMCU
            // 
            cmbMCU.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbMCU.FormattingEnabled = true;
            cmbMCU.Location = new Point(9, 25);
            cmbMCU.Margin = new Padding(5, 5, 5, 5);
            cmbMCU.Name = "cmbMCU";
            cmbMCU.Size = new Size(176, 28);
            cmbMCU.TabIndex = 5;
            // 
            // openFileDialog1
            // 
            openFileDialog1.Filter = "Hex 文件 (.hex)|*.hex|EEP 文件 (.eep)|*.eep|BIN 文件 (.bin)|*.bin";
            // 
            // rtxtConsole
            // 
            rtxtConsole.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            rtxtConsole.BackColor = Color.Black;
            rtxtConsole.BorderStyle = BorderStyle.None;
            rtxtConsole.ContextMenuStrip = contextMenuStrip1;
            rtxtConsole.Font = new Font("Consolas", 8.25F);
            rtxtConsole.ForeColor = Color.White;
            rtxtConsole.Location = new Point(19, 240);
            rtxtConsole.Margin = new Padding(5, 5, 5, 5);
            rtxtConsole.Name = "rtxtConsole";
            rtxtConsole.ReadOnly = true;
            rtxtConsole.ScrollBars = RichTextBoxScrollBars.ForcedVertical;
            rtxtConsole.Size = new Size(643, 133);
            rtxtConsole.TabIndex = 14;
            rtxtConsole.Text = "";
            rtxtConsole.WordWrap = false;
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.ImageScalingSize = new Size(20, 20);
            contextMenuStrip1.Items.AddRange(new ToolStripItem[] { 清空ToolStripMenuItem });
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(109, 28);
            // 
            // 清空ToolStripMenuItem
            // 
            清空ToolStripMenuItem.Name = "清空ToolStripMenuItem";
            清空ToolStripMenuItem.Size = new Size(108, 24);
            清空ToolStripMenuItem.Text = "清空";
            清空ToolStripMenuItem.Click += 清空ToolStripMenuItem_Click;
            // 
            // ckbAdv
            // 
            ckbAdv.AutoSize = true;
            ckbAdv.Location = new Point(19, 186);
            ckbAdv.Margin = new Padding(5, 5, 5, 5);
            ckbAdv.Name = "ckbAdv";
            ckbAdv.Size = new Size(104, 24);
            ckbAdv.TabIndex = 15;
            ckbAdv.Text = "Advanced";
            ckbAdv.UseVisualStyleBackColor = true;
            ckbAdv.CheckedChanged += ckbAdv_CheckedChanged;
            // 
            // gpAdv
            // 
            gpAdv.Controls.Add(ckbRead);
            gpAdv.Controls.Add(cmbFormat);
            gpAdv.Controls.Add(ckbEEPROM);
            gpAdv.Controls.Add(btnErase);
            gpAdv.Location = new Point(138, 160);
            gpAdv.Margin = new Padding(5, 5, 5, 5);
            gpAdv.Name = "gpAdv";
            gpAdv.Padding = new Padding(5, 5, 5, 5);
            gpAdv.Size = new Size(517, 71);
            gpAdv.TabIndex = 16;
            gpAdv.TabStop = false;
            gpAdv.Text = "高级功能";
            gpAdv.Visible = false;
            // 
            // ckbRead
            // 
            ckbRead.AutoSize = true;
            ckbRead.Location = new Point(242, 29);
            ckbRead.Margin = new Padding(4, 4, 4, 4);
            ckbRead.Name = "ckbRead";
            ckbRead.Size = new Size(130, 24);
            ckbRead.TabIndex = 6;
            ckbRead.Text = "Read(Backup)";
            ckbRead.UseVisualStyleBackColor = true;
            ckbRead.CheckedChanged += FlashOptCheckedChanged;
            // 
            // cmbFormat
            // 
            cmbFormat.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbFormat.FormattingEnabled = true;
            cmbFormat.Location = new Point(10, 25);
            cmbFormat.Margin = new Padding(5, 5, 5, 5);
            cmbFormat.Name = "cmbFormat";
            cmbFormat.Size = new Size(111, 28);
            cmbFormat.TabIndex = 5;
            // 
            // ckbEEPROM
            // 
            ckbEEPROM.AutoSize = true;
            ckbEEPROM.Location = new Point(132, 28);
            ckbEEPROM.Margin = new Padding(5, 5, 5, 5);
            ckbEEPROM.Name = "ckbEEPROM";
            ckbEEPROM.Size = new Size(93, 24);
            ckbEEPROM.TabIndex = 1;
            ckbEEPROM.Text = "EEPROM";
            ckbEEPROM.UseVisualStyleBackColor = true;
            ckbEEPROM.CheckedChanged += FlashOptCheckedChanged;
            // 
            // btnErase
            // 
            btnErase.Location = new Point(405, 21);
            btnErase.Margin = new Padding(5, 5, 5, 5);
            btnErase.Name = "btnErase";
            btnErase.Size = new Size(105, 35);
            btnErase.TabIndex = 0;
            btnErase.Text = "Erase";
            btnErase.UseVisualStyleBackColor = true;
            btnErase.Click += btnErase_Click;
            // 
            // btnHelp
            // 
            btnHelp.Location = new Point(396, 87);
            btnHelp.Margin = new Padding(5, 5, 5, 5);
            btnHelp.Name = "btnHelp";
            btnHelp.Size = new Size(63, 71);
            btnHelp.TabIndex = 17;
            btnHelp.Text = "帮助";
            btnHelp.UseVisualStyleBackColor = true;
            btnHelp.Click += btnHelp_Click;
            // 
            // MainForm
            // 
            AllowDrop = true;
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(665, 376);
            Controls.Add(btnHelp);
            Controls.Add(gpAdv);
            Controls.Add(ckbAdv);
            Controls.Add(rtxtConsole);
            Controls.Add(gpDevice);
            Controls.Add(gpPort);
            Controls.Add(gbFilePath);
            Controls.Add(btnProgram);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(5, 5, 5, 5);
            MaximizeBox = false;
            Name = "MainForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "cade 0.5";
            FormClosing += MainForm_FormClosing;
            Load += MainForm_Load;
            DragDrop += MainForm_DragDrop;
            DragEnter += MainForm_DragEnter;
            gbFilePath.ResumeLayout(false);
            gbFilePath.PerformLayout();
            gpPort.ResumeLayout(false);
            gpDevice.ResumeLayout(false);
            contextMenuStrip1.ResumeLayout(false);
            gpAdv.ResumeLayout(false);
            gpAdv.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private System.Windows.Forms.Button btnProgram;
        private System.Windows.Forms.GroupBox gbFilePath;
        private System.Windows.Forms.TextBox txtFilePath;
        private System.Windows.Forms.Button btnBrowse;
        private System.Windows.Forms.GroupBox gpPort;
        private System.Windows.Forms.ComboBox cmbPort;
        private System.Windows.Forms.GroupBox gpDevice;
        private System.Windows.Forms.ComboBox cmbMCU;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.RichTextBox rtxtConsole;
        private System.Windows.Forms.CheckBox ckbAdv;
        private System.Windows.Forms.GroupBox gpAdv;
        private System.Windows.Forms.Button btnErase;
        private System.Windows.Forms.Button btnHelp;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 清空ToolStripMenuItem;
        private System.Windows.Forms.CheckBox ckbEEPROM;
        private System.Windows.Forms.ComboBox cmbFormat;
        private CheckBox ckbRead;
    }
}

