using Cake.Core;
using Cake.Core.IO;

namespace Cake.EntityFramework6.Database
{
    /// <summary>
    /// Contains settings used by <see cref="Ef6DatabaseUpdateTool"/>.
    /// </summary>
    public class Ef6DatabaseUpdateSettings : Ef6Settings
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Ef6Settings"/> class.
        /// </summary>
        public Ef6DatabaseUpdateSettings()
            : base("database update")
        { }

        /// <summary>
        /// Only valid with --script. Specifies the name of a particular migration to use as the update's starting point. If omitted, the last applied migration in the database will be used.
        /// </summary>
        public string Source { get; set; }

        /// <summary>
        /// Specifies the name of a particular migration to update the database to. If omitted, the current model will be used.
        /// </summary>
        public string Target { get; set; }

        /// <summary>
        /// Generate a SQL script rather than executing the pending changes directly.
        /// </summary>
        public bool Script { get; set; }

        /// <summary>
        /// Specifies that data loss is acceptable during automatic migration of the database.
        /// </summary>
        public bool Force { get; set; }

        /// <summary>
        /// Specifies the migrations configuration (TYPE) to use. If omitted, migrations will attempt to locate a single migrations configuration type in the target project.
        /// </summary>
        public string MigrationsConfigurationType { get; set; }

        /// <summary>
        /// The assembly to use.
        /// </summary>
        public FilePath Assembly { get; set; }

        /// <summary>
        /// The project directory. Defaults to the current directory.
        /// </summary>
        public DirectoryPath ProjectDirectory { get; set; }

        /// <summary>
        /// The language. Defaults to 'C#'.
        /// </summary>
        public string Language { get; set; }

        /// <summary>
        /// The root namespace. Defaults to the target assembly name.
        /// </summary>
        public string RootNamespace { get; set; }

        /// <summary>
        /// The data directory.
        /// </summary>
        public DirectoryPath DataDirectory { get; set; }

        /// <summary>
        /// Specifies the configuration file to use for named connection strings.
        /// </summary>
        public FilePath ConfigurationFile { get; set; }

        /// <summary>
        /// Specifies the name of a connection string to use from the application's configuration file.
        /// </summary>
        public string ConnectionStringName { get; set; }

        /// <summary>
        /// Specifies the connection string to use. If omitted, the context's default connection will be used.
        /// </summary>
        public string ConnectionString { get; set; }

        /// <summary>
        /// Specifies the provider invariant name of the connection string.
        /// </summary>
        public string ConnectionProvider { get; set; }

        /// <summary>
        /// Evaluates the settings and writes them to <paramref name="args"/>.
        /// </summary>
        /// <param name="args">The argument builder into which the settings should be written.</param>
        protected override void EvaluateCore(ProcessArgumentBuilder args)
        {
            const string separator = " ";

            base.EvaluateCore(args);

            if (Script)
                args.Append("--script");

            if (!string.IsNullOrWhiteSpace(Source))
                args.AppendSwitchQuoted("--source", separator, Source);

            if (!string.IsNullOrWhiteSpace(Target))
                args.AppendSwitchQuoted("--target", separator, Target);

            if (Force)
                args.Append("--force");

            if (!string.IsNullOrWhiteSpace(MigrationsConfigurationType))
                args.AppendSwitchQuoted("--migrations-config", separator, MigrationsConfigurationType);

            if (!string.IsNullOrWhiteSpace(Assembly?.FullPath))
                args.AppendSwitchQuoted("--assembly", separator, Assembly.FullPath);

            if (!string.IsNullOrWhiteSpace(ProjectDirectory?.FullPath))
                args.AppendSwitchQuoted("--project-dir", separator, ProjectDirectory.FullPath);

            if (!string.IsNullOrWhiteSpace(Language))
                args.AppendSwitchQuoted("--language", separator, Language);

            if (!string.IsNullOrWhiteSpace(RootNamespace))
                args.AppendSwitchQuoted("--root-namespace", separator, RootNamespace);

            if (!string.IsNullOrWhiteSpace(DataDirectory?.FullPath))
                args.AppendSwitchQuoted("--data-dir", separator, DataDirectory.FullPath);

            if (!string.IsNullOrWhiteSpace(ConfigurationFile?.FullPath))
                args.AppendSwitchQuoted("--config", separator, ConfigurationFile.FullPath);

            if (!string.IsNullOrWhiteSpace(ConnectionStringName))
                args.AppendSwitchQuoted("--connection-string-name", separator, ConnectionStringName);

            if (!string.IsNullOrWhiteSpace(ConnectionString))
                args.AppendSwitchQuoted("--connection-string", separator, ConnectionString);

            if (!string.IsNullOrWhiteSpace(ConnectionProvider))
                args.AppendSwitchQuoted("--connection-provider", separator, ConnectionProvider);
        }
    }
}
