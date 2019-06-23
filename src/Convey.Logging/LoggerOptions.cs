using Convey.Logging.Options;

namespace Convey.Logging
{
    public class LoggerOptions
    {
        public string Level { get; set; }
        public ConsoleOptions Console { get; set; }
        public FileOptions File { get; set; }
        public ElkOptions Elk { get; set; }
        public SeqOptions Seq { get; set; }
    }
}