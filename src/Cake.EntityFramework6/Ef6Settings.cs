using Cake.Core;
using Cake.Core.Diagnostics;
using Cake.Core.IO;
using Cake.Core.Tooling;

namespace Cake.EntityFramework6
{
    /// <summary>
    /// LibMan tool settings
    /// </summary>
    public abstract class Ef6Settings : ToolSettings
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Ef6Settings"/> class.
        /// </summary>
        /// <param name="command">Command to run.</param>
        protected Ef6Settings(string command)
        {
            Command = command;
            RedirectStandardError = false;
            RedirectStandardOutput = false;
        }

        /// <summary>
        /// Gets or Sets whether to show Verbose output
        /// </summary>
        public bool Verbose { get; set; }

        /// <summary>
        /// Gets or Sets whether to show the version of Entity Framework.
        /// </summary>
        public bool Version { get; set; }

        /// <summary>
        /// Gets or Sets whether to colorize the output.
        /// </summary>
        public bool NoColor { get; set; }

        /// <summary>
        /// Gets or sets whether to prefix the output level
        /// </summary>
        public bool PrefixOutput { get; set; }

        /// <summary>
        /// Gets or sets the process option to redirect standard error
        /// </summary>
        public bool RedirectStandardError { get; set; }

        /// <summary>
        /// Gets or sets the process option to redirect standard output
        /// </summary>
        public bool RedirectStandardOutput { get; set; }

        /// <summary>
        /// Gets or sets the Log level set by Cake.
        /// </summary>
        internal Verbosity? CakeVerbosityLevel { get; set; }

        /// <summary>
        /// Gets the command which should be run.
        /// </summary>
        protected string Command { get; private set; }

        /// <summary>
        /// Evaluates the settings and writes them to <paramref name="args"/>.
        /// </summary>
        /// <param name="args">The argument builder into which the settings should be written.</param>
        internal void Evaluate(ProcessArgumentBuilder args)
        {
            args.Append(Command);
            AppendEf6Settings(args);
            EvaluateCore(args);
        }

        /// <summary>
        /// Evaluates the settings and appends LibMan specific options to arguments
        /// </summary>
        /// <param name="args">The argument builder into which the settings should be written.</param>s
        private void AppendEf6Settings(ProcessArgumentBuilder args)
        {
            AppendLogLevel(args);
            AppendNoColor(args);
            AppendVersion(args);
            AppendPrefixOutput(args);
        }

        /// <summary>
        /// Evaluates the settings and writes them to <paramref name="args"/>.
        /// </summary>
        /// <param name="args">The argument builder into which the settings should be written.</param>
        protected virtual void EvaluateCore(ProcessArgumentBuilder args)
        {
        }

        private void AppendLogLevel(ProcessArgumentBuilder args)
        {
            const string @switch = "--verbose";

            if (Verbose)
                args.Append(@switch);
            else if (CakeVerbosityLevel.HasValue)
            {
                switch (CakeVerbosityLevel.Value)
                {
                    case Verbosity.Verbose:
                    case Verbosity.Diagnostic:
                        args.Append(@switch);
                        break;
                }
            }
        }

        private void AppendVersion(ProcessArgumentBuilder args)
        {
            const string @switch = "--version";

            if (Version)
                args.Append(@switch);
        }

        private void AppendNoColor(ProcessArgumentBuilder args)
        {
            const string @switch = "--no-color";

            if (NoColor)
                args.Append(@switch);
        }

        private void AppendPrefixOutput(ProcessArgumentBuilder args)
        {
            const string @switch = "--prefix-output";

            if (PrefixOutput)
                args.Append(@switch);
        }
    }
}
