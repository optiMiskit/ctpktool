using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using CommandLine;
using CommandLine.Text;

namespace ctpktool
{
    class Config
    {
        [Option('x', "extract", MutuallyExclusiveSet = "input_parameter", HelpText = "Specify CTPK archive to be extracted")]
        public string InputFile { get; set; }

        [Option('r', "raw", MutuallyExclusiveSet = "input_parameter", HelpText = "Specify CTPK archive to be extracted. Extracts the raw image data instead of converting to another format.")]
        public string InputFileRaw { get; set; }

        [Option('c', "create", MutuallyExclusiveSet = "input_parameter", HelpText = "Specify folder to be archived")]
        public string InputFolder { get; set; }

        [Option('o', "output", HelpText = "Specify output file or path")]
        public string OutputPath { get; set; }

        [HelpOption]
        public string GetUsage()
        {
            return HelpText.AutoBuild(this, (HelpText current) => HelpText.DefaultParsingErrorsHandler(this, current));
        }
    }
}
