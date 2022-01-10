using cade.Properties;
using System.IO.Ports;

namespace cade
{
    public partial class MainForm : Form
    {
        private Settings settings = new();
        private Execute cmd;
        public string port
        {
            get { return cmbPort.Text.Trim(); }
            set { cmbPort.Text = value; }
        }
        public MainForm()
        {
            InitializeComponent();
        }
        protected override void WndProc(ref Message m)
        {
            switch (m.Msg)
            {
                case 0x0219: // WM_DEVICECHANGE
                    InitSerialPorts();
                    break;
            }
            base.WndProc(ref m);
        }
        private void MainForm_Load(object sender, EventArgs e)
        {
            InitSerialPorts();
            InitMCUs();
            InitFormats();
            LoadConfigs();

            cmd = new Execute();
            cmd.Load(this.rtxtConsole);
        }
        private void InitSerialPorts()
        {
            cmbPort.Items.Clear();
            cmbPort.Items.AddRange(SerialPort.GetPortNames());
            if (cmbPort.Items.Count > 0)
            {
                cmbPort.SelectedIndex = 0;
            }
        }
        private void InitMCUs()
        {
            cmbMCU.Items.Clear();
            cmbMCU.Items.Add(new Chip("ATmega32U4(m32u4)", "avr109", "m32u4", 32768, 1024));
            cmbMCU.Items.Add(new Chip("ATmega16U2(m16u2)", "avr109", "m16u2", 16384, 512));
            cmbMCU.Items.Add(new Chip("Teensy2pp(usb1286)", "teensy", "usb1286", 32768, 1024));
            cmbMCU.SelectedIndex = 0;
        }

        private void InitFormats()
        {
            cmbFormat.Items.Clear();
            cmbFormat.Items.Add(new Format("Auto", "a"));
            cmbFormat.Items.Add(new Format("Intel Hex", "i"));
            cmbFormat.Items.Add(new Format("Raw", "r"));
            cmbFormat.SelectedIndex = 0;

        }
        private void LoadConfigs()
        {
            txtFilePath.Text = settings.filepath;
            cmbMCU.SelectedIndex = settings.device;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
                txtFilePath.Text = openFileDialog1.FileName;
        }

        private void MainForm_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
            {
                e.Effect = DragDropEffects.Copy;
            }
        }

        private void MainForm_DragDrop(object sender, DragEventArgs e)
        {
            string[] path = (string[])e.Data.GetData(DataFormats.FileDrop, false);
            var ext = Path.GetExtension(path[0]);
            if (ext != ".hex" && ext != ".eep" && ext != ".bin") return;
            txtFilePath.Text = path[0];
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            settings.filepath = txtFilePath.Text;
            settings.device = cmbMCU.SelectedIndex;
            settings.Save();
        }

        private void btnProgram_Click(object sender, EventArgs e)
        {
            if (txtFilePath.Text.Length == 0)
            {
                MessageBox.Show("请选择Flash文件", this.Text);
                return;
            }
            if (cmbPort.SelectedIndex < 0)
            {
                MessageBox.Show("请选择设备端口", this.Text);
                return;
            }
            if (!File.Exists(txtFilePath.Text))
            {
                MessageBox.Show("文件不存在", this.Text);
                return;
            }
            if (new FileInfo(txtFilePath.Text).Length == 0)
            {
                MessageBox.Show("文件格式不正确", this.Text);
                return;
            }
            var b = cmd.ExecCommand(getArgs());
            if (b != 0)
            {
                MessageBox.Show("执行出错");
            }
        }

        private string getArgs()
        {
            string flashType = "flash"; // flash,eeprom
            if (ckbEEPROM.Checked)
            {
                flashType = "eeprom";
            }
            string option = "w"; // w,r,v
            string flashFormat = (cmbFormat.SelectedItem as Format).FormatType;

            var args = "";
            args += " -c " + (cmbMCU.SelectedItem as Chip).Programer; // programmer
            args += " -p" + (cmbMCU.SelectedItem as Chip).DeviceName; // partno
            args += " -P" + cmbPort.Text; // port
            args += " -D";
            args += $" -U {flashType}:{option}:\"{txtFilePath.Text}\":{flashFormat}";
            return args;
        }

        private void btnErase_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("是否需要擦除单片机?\n本操作有一定危险性，请确认你清楚自己在做什么", "警告", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                var args = "";
                args += " -c avr109"; // programmer
                args += " -p" + (cmbMCU.SelectedItem as Chip).DeviceName; // partno
                args += " -P" + cmbPort.Text; // port
                args += " -e";
                cmd.ExecCommand(args);
            }
        }

        private void btnHelp_Click(object sender, EventArgs e)
        {
            MessageBox.Show
                (@"1、选择烧录文件(支持拖拽)
2、Port下选择端口(单片机接入PC后[按复位键/短接RST和GND]自动识别)
 - 请确保PC上只接入一个USB串口设备，即单片机
3、Device下选择单片机类型
4、点击Flash!");
        }

        private void 清空ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            rtxtConsole.Clear();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            gpAdv.Visible = ckbAdv.Checked;
        }

        private void ckbEEPROM_CheckedChanged(object sender, EventArgs e)
        {
            if (ckbEEPROM.Checked)
            {
                btnProgram.Text = "EEPROM";
            }
            else
            {
                btnProgram.Text = "FLASH";
            }
        }
    }
}