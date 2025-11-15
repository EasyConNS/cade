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
            cmbTarget = new ComboBox();
            gpDevice = new GroupBox();
            cmbMCU = new MicrocontrollerSelector();
            openFileDialog1 = new OpenFileDialog();
            rtxtConsole = new LogTextBox();
            contextMenuStrip1 = new ContextMenuStrip(components);
            清空ToolStripMenuItem = new ToolStripMenuItem();
            ckbAutoFlash = new CheckBox();
            btnHelp = new Button();
            gbFilePath.SuspendLayout();
            gpPort.SuspendLayout();
            gpDevice.SuspendLayout();
            contextMenuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // btnProgram
            // 
            btnProgram.Location = new Point(560, 93);
            btnProgram.Margin = new Padding(5);
            btnProgram.Name = "btnProgram";
            btnProgram.Size = new Size(104, 37);
            btnProgram.TabIndex = 2;
            btnProgram.Text = "烧录";
            btnProgram.UseVisualStyleBackColor = true;
            btnProgram.Click += btnProgram_Click;
            // 
            // gbFilePath
            // 
            gbFilePath.Controls.Add(txtFilePath);
            gbFilePath.Controls.Add(btnBrowse);
            gbFilePath.Location = new Point(19, 12);
            gbFilePath.Margin = new Padding(5);
            gbFilePath.Name = "gbFilePath";
            gbFilePath.Padding = new Padding(5);
            gbFilePath.Size = new Size(757, 71);
            gbFilePath.TabIndex = 5;
            gbFilePath.TabStop = false;
            gbFilePath.Text = "file";
            // 
            // txtFilePath
            // 
            txtFilePath.AcceptsTab = true;
            txtFilePath.Location = new Point(10, 27);
            txtFilePath.Margin = new Padding(5);
            txtFilePath.Name = "txtFilePath";
            txtFilePath.Size = new Size(635, 27);
            txtFilePath.TabIndex = 3;
            // 
            // btnBrowse
            // 
            btnBrowse.Location = new Point(655, 27);
            btnBrowse.Margin = new Padding(5);
            btnBrowse.Name = "btnBrowse";
            btnBrowse.Size = new Size(69, 27);
            btnBrowse.TabIndex = 2;
            btnBrowse.Text = "...";
            btnBrowse.UseVisualStyleBackColor = true;
            btnBrowse.Click += btnBrowse_Click;
            // 
            // gpPort
            // 
            gpPort.Controls.Add(cmbTarget);
            gpPort.Location = new Point(19, 87);
            gpPort.Margin = new Padding(5);
            gpPort.Name = "gpPort";
            gpPort.Padding = new Padding(5);
            gpPort.Size = new Size(315, 71);
            gpPort.TabIndex = 6;
            gpPort.TabStop = false;
            gpPort.Text = "Target";
            // 
            // cmbTarget
            // 
            cmbTarget.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbTarget.FormattingEnabled = true;
            cmbTarget.Location = new Point(9, 25);
            cmbTarget.Margin = new Padding(5);
            cmbTarget.Name = "cmbTarget";
            cmbTarget.Size = new Size(297, 28);
            cmbTarget.TabIndex = 4;
            // 
            // gpDevice
            // 
            gpDevice.Controls.Add(cmbMCU);
            gpDevice.Location = new Point(344, 87);
            gpDevice.Margin = new Padding(5);
            gpDevice.Name = "gpDevice";
            gpDevice.Padding = new Padding(5);
            gpDevice.Size = new Size(203, 71);
            gpDevice.TabIndex = 7;
            gpDevice.TabStop = false;
            gpDevice.Text = "Device";
            // 
            // cmbMCU
            // 
            cmbMCU.DisplayMember = "Value";
            cmbMCU.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbMCU.FormattingEnabled = true;
            cmbMCU.Location = new Point(9, 25);
            cmbMCU.Margin = new Padding(5);
            cmbMCU.Name = "cmbMCU";
            cmbMCU.Size = new Size(176, 28);
            cmbMCU.TabIndex = 5;
            cmbMCU.ValueMember = "Key";
            // 
            // openFileDialog1
            // 
            openFileDialog1.Filter = "Hex 文件 (.hex)|*.hex|EEP 文件 (.eep)|*.eep|BIN 文件 (.bin)|*.bin";
            // 
            // rtxtConsole
            // 
            rtxtConsole.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            rtxtConsole.BackColor = Color.FromArgb(30, 30, 30);
            rtxtConsole.BorderStyle = BorderStyle.None;
            rtxtConsole.ContextMenuStrip = contextMenuStrip1;
            rtxtConsole.DetectUrls = false;
            rtxtConsole.Font = new Font("Consolas", 8.25F);
            rtxtConsole.ForeColor = Color.White;
            rtxtConsole.HideSelection = false;
            rtxtConsole.Location = new Point(19, 174);
            rtxtConsole.Margin = new Padding(5);
            rtxtConsole.Name = "rtxtConsole";
            rtxtConsole.ReadOnly = true;
            rtxtConsole.Size = new Size(766, 347);
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
            // ckbAutoFlash
            // 
            ckbAutoFlash.AutoSize = true;
            ckbAutoFlash.Location = new Point(560, 134);
            ckbAutoFlash.Margin = new Padding(5);
            ckbAutoFlash.Name = "ckbAutoFlash";
            ckbAutoFlash.Size = new Size(91, 24);
            ckbAutoFlash.TabIndex = 15;
            ckbAutoFlash.Text = "自动烧录";
            ckbAutoFlash.UseVisualStyleBackColor = true;
            // 
            // btnHelp
            // 
            btnHelp.Location = new Point(674, 93);
            btnHelp.Margin = new Padding(5);
            btnHelp.Name = "btnHelp";
            btnHelp.Size = new Size(102, 71);
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
            ClientSize = new Size(791, 523);
            Controls.Add(btnHelp);
            Controls.Add(ckbAutoFlash);
            Controls.Add(rtxtConsole);
            Controls.Add(gpDevice);
            Controls.Add(gpPort);
            Controls.Add(gbFilePath);
            Controls.Add(btnProgram);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(5);
            MaximizeBox = false;
            Name = "MainForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "伊机控烧录工具";
            FormClosing += MainForm_FormClosing;
            Load += MainForm_Load;
            Shown += MainForm_Shown;
            DragDrop += MainForm_DragDrop;
            DragEnter += MainForm_DragEnter;
            gbFilePath.ResumeLayout(false);
            gbFilePath.PerformLayout();
            gpPort.ResumeLayout(false);
            gpDevice.ResumeLayout(false);
            contextMenuStrip1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private System.Windows.Forms.Button btnProgram;
        private System.Windows.Forms.GroupBox gbFilePath;
        private System.Windows.Forms.TextBox txtFilePath;
        private System.Windows.Forms.Button btnBrowse;
        private System.Windows.Forms.GroupBox gpPort;
        private System.Windows.Forms.ComboBox cmbTarget;
        private System.Windows.Forms.GroupBox gpDevice;
        private MicrocontrollerSelector cmbMCU;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private LogTextBox rtxtConsole;
        private System.Windows.Forms.CheckBox ckbAutoFlash;
        private System.Windows.Forms.Button btnHelp;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 清空ToolStripMenuItem;
    }
}

