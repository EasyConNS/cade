namespace cade
{
    class Chip
    {
        public readonly string DisplayName;
        public readonly string DeviceName;
        public readonly int FlashSize;
        public readonly int EEPROMSize;
        public readonly string Programer;

        public Chip(string displayname,string prog, string devicename, int flash, int eeprom)
        {
            DisplayName = displayname;
            Programer = prog;
            DeviceName = devicename;
            FlashSize = flash;
            EEPROMSize = eeprom;
        }
        public override string ToString()
        {
            return DisplayName;
        }
    }
}
