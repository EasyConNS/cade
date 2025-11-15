using cade.Helpers;
using cade.Properties;
using Usb;
using Usb.Bootloader;
using System.Diagnostics;
using System.Runtime.InteropServices;

namespace cade
{
    public partial class MainForm : Form
    {
        public const int WM_DEVICECHANGE = 0x0219;
        public const int DBT_DEVICEARRIVAL = 0x8000;
        public const int DBT_DEVICEREMOVECOMPLETE = 0x8004;
        private readonly Version VER = new(0, 5);

        public MainForm()
        {
            InitializeComponent();
        }
        protected override void WndProc(ref Message m)
        {
            switch (m.Msg)
            {
                case WM_DEVICECHANGE:
                    InitBootloaders();
                    switch (m.WParam)
                    {
                        case DBT_DEVICEARRIVAL:
                            Debug.WriteLine("dev arrived");
                            break;
                        case DBT_DEVICEREMOVECOMPLETE:
                            Debug.WriteLine("dev removed");
                            break;
                    }
                    break;
            }
            if (m.Msg == NativeMethods.WmShowme)
            {
                ShowMe();
            }
            base.WndProc(ref m);
        }
        private void ShowMe()
        {
            if (WindowState == FormWindowState.Minimized)
            {
                WindowState = FormWindowState.Normal;
            }
            Activate();
        }
        private void MainForm_Load(object sender, EventArgs e)
        {
            this.Text = $"cade v{VER} 【伊机控烧录工具】 QQ群:946057081";
            txtFilePath.Text = Settings.Default.filepath;
            cmbMCU.SelectedValue = Settings.Default.targetSetting;

            usbListener.bootloaderDeviceConnected += BootloaderDeviceConnected;
            usbListener.bootloaderDeviceDisconnected += BootloaderDeviceDisconnected;
            usbListener.outputReceived += BootloaderCommandOutputReceived;

            try
            {
                usbListener.Start();
            }
            catch (COMException ex)
            {
                Debug.WriteLine($"USB device enumeration failed.{ex}");
            }
        }
        private void MainForm_Shown(object sender, EventArgs e)
        {
            if (Settings.Default.firstStart)
            {
                EmbeddedResourceHelper.InitResourceFolder();
                Settings.Default.Upgrade();
                Settings.Default.firstStart = false;
                Settings.Default.Save();
            }
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
            Settings.Default.filepath = txtFilePath.Text;
            Settings.Default.targetSetting = (string)cmbMCU.SelectedValue;
            Settings.Default.Save();
        }

        #region USB Devices & Bootloaders
        private readonly UsbListener usbListener = new();

        private void BootloaderDeviceConnected(BootloaderDevice device)
        {
            Invoke(new Action(() =>
            {
                rtxtConsole.LogBootloader($"{device.Name} 设备已连接 ({device.Driver}): {device}");

                cmbTarget.Items.Add(device);
                cmbTarget.SelectedIndex = 0;

                if (device.PreferredDriver != device.Driver)
                {
                    Debug.WriteLine($"{device.Name} device has {device.Driver} driver assigned but should be {device.PreferredDriver}.");
                    rtxtConsole.LogError($"设备{device.Name}驱动可能存在异常");
                }

                if (ckbAutoFlash.Checked)
                {
                    FlashAllAsync();
                }
                else
                {
                    //EnableUI();
                }
            }));
        }

        private void BootloaderDeviceDisconnected(BootloaderDevice device)
        {
            Invoke(new Action(() =>
            {
                rtxtConsole.LogBootloader($"{device.Name} 设备已断开 ({device.Driver}): {device}");

                cmbTarget.Items.Clear();

                if (!ckbAutoFlash.Checked)
                {
                    //EnableUI();
                }
            }));
        }

        private void BootloaderCommandOutputReceived(BootloaderDevice device, string data, MessageType type)
        {
            Invoke(new Action(() =>
            {
                rtxtConsole.Log(data, type);
            }));
        }


        private void InitBootloaders()
        {
            //cmbTarget.Items.Clear();
            //foreach (var b in FindBootloaders())
            //{
            //    cmbTarget.Items.Add(b.Name);
            //}
            // TODO
        }

        private List<BootloaderDevice> FindBootloaders()
        {
            return usbListener.Devices.Where(d => d is BootloaderDevice).Select(b => b as BootloaderDevice).ToList();
        }
        #endregion

        private async void FlashAllAsync()
        {
            string selectedMcu = (string)cmbMCU.SelectedValue;
            string filePath = txtFilePath.Text;
            if (!File.Exists(filePath))
            {
                MessageBox.Show("文件不存在", this.Text);
                return;
            }
            if (new FileInfo(filePath).Length == 0)
            {
                MessageBox.Show("文件格式不正确", this.Text);
                return;
            }

            try
            {
                foreach (BootloaderDevice b in FindBootloaders())
                {
                    rtxtConsole.LogBootloader("准备烧录中，请不要移除单片机");
                    await b.Flash(selectedMcu, filePath);
                    rtxtConsole.LogBootloader("烧录完成");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"执行出错:{ex.Message}");
            }
        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
                txtFilePath.Text = openFileDialog1.FileName;
        }

        private void btnProgram_Click(object sender, EventArgs e)
        {
            FlashAllAsync();
        }


        private void btnHelp_Click(object sender, EventArgs e)
        {
            MessageBox.Show
                (@"1、选择需要烧录的固件文件(支持拖拽)
2、Port下选择端口(单片机接入PC后[按复位键/短接RST和GND]自动识别)
 - 请确保PC上只接入一个USB串口设备，即单片机
3、Device下选择单片机类型
4、点击FLASH!
等待下方日志输出<Thank you>即成功");
        }

        private void 清空ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            rtxtConsole.Clear();
        }
    }
}