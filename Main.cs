using AppKit;

namespace ChromeSpeechProxy
{
	static class MainClass
	{
		static void Main(string[] args)
		{
            if (args.Length > 0)
            {
                string strPort = args[0];
                int port;
                if (int.TryParse(strPort, out port))
                {
                    ViewController.SetProxyPort(port);
                }
            }


            NSApplication.Init();
			NSApplication.Main(args);
		}
	}
}
