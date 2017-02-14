using CommandLine;

namespace OneDriveSync
{
    public class Options
    {
        [Option('c', "confdir", HelpText = "Set the directory to use to store the configuration files.")]
        public string Confdir { get; set; }

        [Option('m', "monitor", HelpText="Keep monitoring for local and remote changes.")]
        public bool Monitor { get; set; }

        [Option('r', "resync", HelpText="Forget the last saved state, perform a full sync.")]
        public bool Resync { get; set; }

        [Option("logout", HelpText="Logout the current user.")]
        public bool Logout { get; set; }

        [Option('v', "verbose", HelpText="Print more details, useful for debugging.")]
        public bool Verbose { get; set; }
    }
}