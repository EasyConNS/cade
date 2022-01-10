namespace cade
{
    class Format
    {
        public readonly string DisplayName;
        public readonly string FormatType;
        public Format(string displayname, string format)
        {
            DisplayName = displayname;
            FormatType = format;
        }
        public override string ToString()
        {
            return DisplayName;
        }
    }
}
