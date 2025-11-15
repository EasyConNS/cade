namespace Usb.Bootloader;

class Stm32DuinoDevice : BootloaderDevice
{
    public Stm32DuinoDevice(UsbDevice d) : base(d)
    {
        Type = BootloaderType.Stm32Duino;
        Name = "STM32Duino";
        PreferredDriver = "WinUSB";
    }

    public async override Task Flash(string mcu, string file)
    {
        if (Path.GetExtension(file)?.ToLower() == ".bin")
        {
            await RunProcessAsync("dfu-util.exe", $"-a 2 -d 1EAF:0003 -R -D \"{file}\"");
        }
        else
        {
            PrintErrorMessage("Only firmware files in .bin format can be flashed with dfu-util!");
        }
    }
}
