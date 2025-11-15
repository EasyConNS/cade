namespace cade.Usb.Bootloader;

class StmHidDevice : BootloaderDevice
{
    public StmHidDevice(UsbDevice d) : base(d)
    {
        Type = BootloaderType.StmHid;
        Name = "STM HID Bootloader";
        PreferredDriver = "HidUsb";
    }

    public async override Task Flash(string mcu, string file)
    {
        if (Path.GetExtension(file)?.ToLower() == ".bin")
        {
            await RunProcessAsync("hid-flash.exe", $"\"{file}\" COM1");
        }
        else
        {
            PrintMessage("Only firmware files in .bin format can be flashed with hid-flash!", MessageType.Error);
        }
    }
}
