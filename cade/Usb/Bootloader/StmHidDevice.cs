namespace Usb.Bootloader;

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
            await RunProcessAsync("hid-flash.exe", $"\"{file}\" COM3");
        }
        else
        {
            PrintErrorMessage("Only firmware files in .bin format can be flashed with hid-flash!");
        }
    }
}
