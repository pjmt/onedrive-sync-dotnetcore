using System;
using System.IO;

namespace OneDriveSync
{
    public class Program
    {
        public static void Main(string[] args)
        {
            // Parse command line arguments
            var results = CommandLine.Parser.Default.ParseArguments<Options>(args);

            // Load configuration
            var configDirName = "~/.config/onedrive";
            configDirName = Path.GetFullPath(configDirName);

            if (!Directory.Exists(configDirName)) 
                Directory.CreateDirectory(configDirName);

            var cfg = new Config(configDirName);
            cfg.Init();

            // Update item database.

            // Initialise OneDrive API

            // Open synchronisation database.

            // Initialise synchronisation engine.

            // Perform synchronisation.

            // Monitor changes and synchronisation.
        }
    }
}