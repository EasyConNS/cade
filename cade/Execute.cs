using System.Diagnostics;

namespace cade
{
    class Execute
    {
        private Process p = new Process();
        private static RichTextBox console;

        public void Load(RichTextBox textBox)
        {
            console = textBox;
            Thread t = new Thread(new ThreadStart(TConsoleUpdate))
            {
                IsBackground = true
            };
            t.Start();
        }

        public int ExecCommand(string args)
        {
            var binary = "avrdude.exe";
            p.StartInfo.FileName = binary;
            p.StartInfo.Arguments = args;
            p.StartInfo.CreateNoWindow = true;
            p.StartInfo.UseShellExecute = false;
            p.StartInfo.RedirectStandardOutput = true;
            p.StartInfo.RedirectStandardError = true;
            p.EnableRaisingEvents = true;
            p.Exited += new EventHandler(p_Exited);

            try
            {
                p.Start();
            }
            catch (Exception)
            {
                return -1;
            }

            return 0;
        }
        private void TConsoleUpdate()
        {
            while (true)
            {
                Thread.Sleep(15);

                try
                {
                    if (p != null)
                    {
                        char[] buff = new char[256];

                        // TODO: read from stdError AND stdOut (AVRDUDE outputs stuff through stdError)
                        if (p.StandardError.Read(buff, 0, buff.Length) > 0)
                        {
                            string s = new string(buff);
                            consoleWrite(s, Color.White);
                        }
                    }
                }
                catch (Exception)
                {

                }
            }
        }
        private void p_Exited(object sender, EventArgs e)
        {
            //
        }
        public static void consoleWrite(string text, Color colour)
        {
            // Credits:
            // Uwe Tanger (Console in main window instead of separate window)
            // Dean (Console in main window instead of separate window)

            if (console != null)
            {
                console.InvokeIfRequired(c =>
                {
                    c.AppendText(text, colour);
                    if (text.Contains("\n")) // Without this the text box spazzes a bit on the progress bars
                        c.ScrollToCaret();
                });
            }
        }
    }
    static class Ext
    {
        public static void InvokeIfRequired<T>(this T c, Action<T> action)
            where T : Control
        {
            try
            {
                if (c.InvokeRequired)
                    c.Invoke(new Action(() => action(c)));
                else
                    action(c);
            }
            catch (Exception)
            {

            }
        }
        public static void AppendText(this RichTextBox box, string text, Color color)
        {
            box.SelectionStart = box.TextLength;
            box.SelectionLength = 0;

            box.SelectionColor = color;
            box.AppendText(text);
            box.SelectionColor = box.ForeColor;
        }
    }
}
