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
            this.components = new System.ComponentModel.Container();
            this.btnProgram = new System.Windows.Forms.Button();
            this.gbFilePath = new System.Windows.Forms.GroupBox();
            this.txtFilePath = new System.Windows.Forms.TextBox();
            this.btnBrowse = new System.Windows.Forms.Button();
            this.gpPort = new System.Windows.Forms.GroupBox();
            this.cmbPort = new System.Windows.Forms.ComboBox();
            this.gpDevice = new System.Windows.Forms.GroupBox();
            this.cmbMCU = new System.Windows.Forms.ComboBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.rtxtConsole = new System.Windows.Forms.RichTextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.清空ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ckbAdv = new System.Windows.Forms.CheckBox();
            this.gpAdv = new System.Windows.Forms.GroupBox();
            this.ckbRead = new System.Windows.Forms.CheckBox();
            this.cmbFormat = new System.Windows.Forms.ComboBox();
            this.ckbEEPROM = new System.Windows.Forms.CheckBox();
            this.btnErase = new System.Windows.Forms.Button();
            this.btnHelp = new System.Windows.Forms.Button();
            this.gbFilePath.SuspendLayout();
            this.gpPort.SuspendLayout();
            this.gpDevice.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.gpAdv.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnProgram
            // 
            this.btnProgram.Location = new System.Drawing.Point(375, 74);
            this.btnProgram.Margin = new System.Windows.Forms.Padding(4);
            this.btnProgram.Name = "btnProgram";
            this.btnProgram.Size = new System.Drawing.Size(133, 60);
            this.btnProgram.TabIndex = 2;
            this.btnProgram.Text = "FLASH";
            this.btnProgram.UseVisualStyleBackColor = true;
            this.btnProgram.Click += new System.EventHandler(this.btnProgram_Click);
            // 
            // gbFilePath
            // 
            this.gbFilePath.Controls.Add(this.txtFilePath);
            this.gbFilePath.Controls.Add(this.btnBrowse);
            this.gbFilePath.Location = new System.Drawing.Point(15, 10);
            this.gbFilePath.Margin = new System.Windows.Forms.Padding(4);
            this.gbFilePath.Name = "gbFilePath";
            this.gbFilePath.Padding = new System.Windows.Forms.Padding(4);
            this.gbFilePath.Size = new System.Drawing.Size(493, 60);
            this.gbFilePath.TabIndex = 5;
            this.gbFilePath.TabStop = false;
            this.gbFilePath.Text = "Flash/EEPROM";
            // 
            // txtFilePath
            // 
            this.txtFilePath.AcceptsTab = true;
            this.txtFilePath.Location = new System.Drawing.Point(8, 23);
            this.txtFilePath.Margin = new System.Windows.Forms.Padding(4);
            this.txtFilePath.Name = "txtFilePath";
            this.txtFilePath.Size = new System.Drawing.Size(389, 23);
            this.txtFilePath.TabIndex = 3;
            // 
            // btnBrowse
            // 
            this.btnBrowse.Location = new System.Drawing.Point(422, 23);
            this.btnBrowse.Margin = new System.Windows.Forms.Padding(4);
            this.btnBrowse.Name = "btnBrowse";
            this.btnBrowse.Size = new System.Drawing.Size(54, 23);
            this.btnBrowse.TabIndex = 2;
            this.btnBrowse.Text = "...";
            this.btnBrowse.UseVisualStyleBackColor = true;
            this.btnBrowse.Click += new System.EventHandler(this.btnBrowse_Click);
            // 
            // gpPort
            // 
            this.gpPort.Controls.Add(this.cmbPort);
            this.gpPort.Location = new System.Drawing.Point(15, 74);
            this.gpPort.Margin = new System.Windows.Forms.Padding(4);
            this.gpPort.Name = "gpPort";
            this.gpPort.Padding = new System.Windows.Forms.Padding(4);
            this.gpPort.Size = new System.Drawing.Size(114, 60);
            this.gpPort.TabIndex = 6;
            this.gpPort.TabStop = false;
            this.gpPort.Text = "Port";
            // 
            // cmbPort
            // 
            this.cmbPort.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPort.FormattingEnabled = true;
            this.cmbPort.Location = new System.Drawing.Point(7, 21);
            this.cmbPort.Margin = new System.Windows.Forms.Padding(4);
            this.cmbPort.Name = "cmbPort";
            this.cmbPort.Size = new System.Drawing.Size(100, 25);
            this.cmbPort.TabIndex = 4;
            // 
            // gpDevice
            // 
            this.gpDevice.Controls.Add(this.cmbMCU);
            this.gpDevice.Location = new System.Drawing.Point(139, 74);
            this.gpDevice.Margin = new System.Windows.Forms.Padding(4);
            this.gpDevice.Name = "gpDevice";
            this.gpDevice.Padding = new System.Windows.Forms.Padding(4);
            this.gpDevice.Size = new System.Drawing.Size(158, 60);
            this.gpDevice.TabIndex = 7;
            this.gpDevice.TabStop = false;
            this.gpDevice.Text = "Device";
            // 
            // cmbMCU
            // 
            this.cmbMCU.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbMCU.FormattingEnabled = true;
            this.cmbMCU.Location = new System.Drawing.Point(7, 21);
            this.cmbMCU.Margin = new System.Windows.Forms.Padding(4);
            this.cmbMCU.Name = "cmbMCU";
            this.cmbMCU.Size = new System.Drawing.Size(138, 25);
            this.cmbMCU.TabIndex = 5;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.Filter = "Hex 文件 (.hex)|*.hex|EEP 文件 (.eep)|*.eep|BIN 文件 (.bin)|*.bin";
            // 
            // rtxtConsole
            // 
            this.rtxtConsole.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rtxtConsole.BackColor = System.Drawing.Color.Black;
            this.rtxtConsole.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rtxtConsole.ContextMenuStrip = this.contextMenuStrip1;
            this.rtxtConsole.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.rtxtConsole.ForeColor = System.Drawing.Color.White;
            this.rtxtConsole.Location = new System.Drawing.Point(15, 204);
            this.rtxtConsole.Margin = new System.Windows.Forms.Padding(4);
            this.rtxtConsole.Name = "rtxtConsole";
            this.rtxtConsole.ReadOnly = true;
            this.rtxtConsole.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.ForcedVertical;
            this.rtxtConsole.Size = new System.Drawing.Size(500, 113);
            this.rtxtConsole.TabIndex = 14;
            this.rtxtConsole.Text = "";
            this.rtxtConsole.WordWrap = false;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.清空ToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(101, 26);
            // 
            // 清空ToolStripMenuItem
            // 
            this.清空ToolStripMenuItem.Name = "清空ToolStripMenuItem";
            this.清空ToolStripMenuItem.Size = new System.Drawing.Size(100, 22);
            this.清空ToolStripMenuItem.Text = "清空";
            this.清空ToolStripMenuItem.Click += new System.EventHandler(this.清空ToolStripMenuItem_Click);
            // 
            // ckbAdv
            // 
            this.ckbAdv.AutoSize = true;
            this.ckbAdv.Location = new System.Drawing.Point(15, 158);
            this.ckbAdv.Margin = new System.Windows.Forms.Padding(4);
            this.ckbAdv.Name = "ckbAdv";
            this.ckbAdv.Size = new System.Drawing.Size(84, 21);
            this.ckbAdv.TabIndex = 15;
            this.ckbAdv.Text = "Advanced";
            this.ckbAdv.UseVisualStyleBackColor = true;
            this.ckbAdv.CheckedChanged += new System.EventHandler(this.ckbAdv_CheckedChanged);
            // 
            // gpAdv
            // 
            this.gpAdv.Controls.Add(this.ckbRead);
            this.gpAdv.Controls.Add(this.cmbFormat);
            this.gpAdv.Controls.Add(this.ckbEEPROM);
            this.gpAdv.Controls.Add(this.btnErase);
            this.gpAdv.Location = new System.Drawing.Point(107, 136);
            this.gpAdv.Margin = new System.Windows.Forms.Padding(4);
            this.gpAdv.Name = "gpAdv";
            this.gpAdv.Padding = new System.Windows.Forms.Padding(4);
            this.gpAdv.Size = new System.Drawing.Size(402, 60);
            this.gpAdv.TabIndex = 16;
            this.gpAdv.TabStop = false;
            this.gpAdv.Text = "高级功能";
            this.gpAdv.Visible = false;
            // 
            // ckbRead
            // 
            this.ckbRead.AutoSize = true;
            this.ckbRead.Location = new System.Drawing.Point(188, 25);
            this.ckbRead.Name = "ckbRead";
            this.ckbRead.Size = new System.Drawing.Size(108, 21);
            this.ckbRead.TabIndex = 6;
            this.ckbRead.Text = "Read(Backup)";
            this.ckbRead.UseVisualStyleBackColor = true;
            this.ckbRead.CheckedChanged += new System.EventHandler(this.FlashOptCheckedChanged);
            // 
            // cmbFormat
            // 
            this.cmbFormat.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbFormat.FormattingEnabled = true;
            this.cmbFormat.Location = new System.Drawing.Point(8, 21);
            this.cmbFormat.Margin = new System.Windows.Forms.Padding(4);
            this.cmbFormat.Name = "cmbFormat";
            this.cmbFormat.Size = new System.Drawing.Size(87, 25);
            this.cmbFormat.TabIndex = 5;
            // 
            // ckbEEPROM
            // 
            this.ckbEEPROM.AutoSize = true;
            this.ckbEEPROM.Location = new System.Drawing.Point(103, 24);
            this.ckbEEPROM.Margin = new System.Windows.Forms.Padding(4);
            this.ckbEEPROM.Name = "ckbEEPROM";
            this.ckbEEPROM.Size = new System.Drawing.Size(78, 21);
            this.ckbEEPROM.TabIndex = 1;
            this.ckbEEPROM.Text = "EEPROM";
            this.ckbEEPROM.UseVisualStyleBackColor = true;
            this.ckbEEPROM.CheckedChanged += new System.EventHandler(this.FlashOptCheckedChanged);
            // 
            // btnErase
            // 
            this.btnErase.Location = new System.Drawing.Point(315, 18);
            this.btnErase.Margin = new System.Windows.Forms.Padding(4);
            this.btnErase.Name = "btnErase";
            this.btnErase.Size = new System.Drawing.Size(82, 30);
            this.btnErase.TabIndex = 0;
            this.btnErase.Text = "Erase";
            this.btnErase.UseVisualStyleBackColor = true;
            this.btnErase.Click += new System.EventHandler(this.btnErase_Click);
            // 
            // btnHelp
            // 
            this.btnHelp.Location = new System.Drawing.Point(308, 74);
            this.btnHelp.Margin = new System.Windows.Forms.Padding(4);
            this.btnHelp.Name = "btnHelp";
            this.btnHelp.Size = new System.Drawing.Size(49, 60);
            this.btnHelp.TabIndex = 17;
            this.btnHelp.Text = "帮助";
            this.btnHelp.UseVisualStyleBackColor = true;
            this.btnHelp.Click += new System.EventHandler(this.btnHelp_Click);
            // 
            // MainForm
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(517, 320);
            this.Controls.Add(this.btnHelp);
            this.Controls.Add(this.gpAdv);
            this.Controls.Add(this.ckbAdv);
            this.Controls.Add(this.rtxtConsole);
            this.Controls.Add(this.gpDevice);
            this.Controls.Add(this.gpPort);
            this.Controls.Add(this.gbFilePath);
            this.Controls.Add(this.btnProgram);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "cade 0.4b";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.DragDrop += new System.Windows.Forms.DragEventHandler(this.MainForm_DragDrop);
            this.DragEnter += new System.Windows.Forms.DragEventHandler(this.MainForm_DragEnter);
            this.gbFilePath.ResumeLayout(false);
            this.gbFilePath.PerformLayout();
            this.gpPort.ResumeLayout(false);
            this.gpDevice.ResumeLayout(false);
            this.contextMenuStrip1.ResumeLayout(false);
            this.gpAdv.ResumeLayout(false);
            this.gpAdv.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

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

