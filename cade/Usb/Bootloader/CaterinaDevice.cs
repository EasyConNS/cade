namespace cade.Usb.Bootloader
{
    class CaterinaDevice : BootloaderDevice
    {
        public string ComPort { get; }

        public CaterinaDevice(UsbDevice d) : base(d)
        {
            Type = BootloaderType.Caterina;
            Name = "Caterina";
            PreferredDriver = "usbser";
            IsEepromFlashable = true;
            IsCanErease = true;

            ComPort = FindComPort();
        }

        private readonly string flashprogrammer = "avr109"; // "teensy" for teensy
        private readonly string rw = "w"; // r(read) or w(write)
        //Format("Auto", "a")
        //Format("Intel Hex", "i")
        #if DEBUG
        //Format("Moto S-record", "s")
        #endif
        //Format("Raw", "r")
        private readonly string flashFormat = "a";

        public async override Task Flash(string mcu, string file)
        {
            if (ComPort == null)
            {
                PrintMessage("COM port not found!", MessageType.Error);
                return;
            }

            await RunProcessAsync("avrdude.exe", $"-p {mcu} -c {flashprogrammer} -U flash:{rw}:\"{file}\":{flashFormat} -P {ComPort}");
        }

        public async override Task FlashEeprom(string mcu, string file)
        {
            if (ComPort == null)
            {
                PrintMessage("COM port not found!", MessageType.Error);
                return;
            }

            await RunProcessAsync("avrdude.exe", $"-p {mcu} -c {flashprogrammer} -U eeprom:{rw}:\"{file}\":{flashFormat} -P {ComPort}");
        }

        public async override Task Erease(string mcu)
        {
            if (ComPort == null)
            {
                PrintMessage("COM port not found!", MessageType.Error);
                return;
            }

            await RunProcessAsync("avrdude.exe", $"-p {mcu} -c {flashprogrammer} -e -P {ComPort}");
        }

        public override string ToString() => $"{base.ToString()} [{ComPort}]";
    }
}
