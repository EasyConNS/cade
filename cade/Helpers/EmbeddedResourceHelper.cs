using System.Reflection;

namespace cade.Helpers
{
    public static class EmbeddedResourceHelper
    {
        public static readonly string[] Resources =
        {
            "avrdude.conf",
            "reset.eep",
            "avrdude.exe",
            "dfu-util.exe",
            "teensy_loader_cli.exe",
            "libusb-0-1-4.dll",
            "libusb-1.0.dll"
        };

        public static string GetResourceFolder()
        {
            string appData = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData);
            return Path.Combine(appData, "EasyCon", "cade");
        }

        public static void InitResourceFolder()
        {
            string toolboxData = GetResourceFolder();
            if (Directory.Exists(toolboxData))
            {
                Directory.Delete(toolboxData, true);
            }
            Directory.CreateDirectory(toolboxData);
            ExtractResources(Resources);
        }

        public static void ExtractResource(string file)
        {
            string destPath = Path.Combine(GetResourceFolder(), file);

            if (!File.Exists(destPath))
            {
                using var stream = Assembly.GetExecutingAssembly().GetManifestResourceStream($"cade.Resources.{file}");
                using var filestream = new FileStream(destPath, FileMode.Create);
                stream?.CopyTo(filestream);
            }
        }

        public static void ExtractResources(params string[] files) => ExtractResources(files as IEnumerable<string>);
        public static void ExtractResources(IEnumerable<string> files)
        {
            foreach (var s in files)
            {
                ExtractResource(s);
            }
        }

        public static string GetResourceContent(string file)
        {
            using var stream = Assembly.GetExecutingAssembly().GetManifestResourceStream($"cade.Resources.{file}");
            using StreamReader reader = new(stream);
            return reader.ReadToEnd();
        }
    }
}
