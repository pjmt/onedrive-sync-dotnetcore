namespace OneDriveSync
{
    public class Program
    {
        public static void Main(string[] args)
        {
            // Parse command line arguments
            var results = CommandLine.Parser.Default.ParseArguments<Options>(args);

            // Load configuration

            // Initialise OneDrive API

            // Open synchronisation database.

            // Initialise synchronisation engine.

            // Perform synchronisation.

            // Monitor changes and synchronisation.
        }
    }
}