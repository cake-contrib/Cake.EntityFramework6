using Cake.Core.IO;
using System;

namespace Cake.EntityFramework6.Database
{
    /// <summary>
    /// Extensions for <see cref="Ef6DatabaseUpdateSettings"/>.
    /// </summary>
    public static class Ef6DatabaseUpdateExtensions
    {
        /// <summary>
        /// Specifies the name of a particular migration to use as the update's starting point. If omitted, the last applied migration in the database will be used.
        /// </summary>
        /// <param name="settings">The settings.</param>
        /// <param name="source">Destination directory path.</param>        
        /// <returns>The <paramref name="settings"/> instance with <see cref="Ef6DatabaseUpdateSettings.Source"/> set to <paramref name="source"/>.</returns>
        public static Ef6DatabaseUpdateSettings WithSource(this Ef6DatabaseUpdateSettings settings, string source)
        {
            if (settings == null)
                throw new ArgumentNullException(nameof(settings));

            settings.Source = source;

            return settings;
        }

        /// <summary>
        /// Specifies the name of a particular migration to update the database to. If omitted, the current model will be used.
        /// </summary>
        /// <param name="settings">The settings.</param>
        /// <param name="target">Destination directory path.</param>        
        /// <returns>The <paramref name="settings"/> instance with <see cref="Ef6DatabaseUpdateSettings.Target"/> set to <paramref name="target"/>.</returns>
        public static Ef6DatabaseUpdateSettings WithTarget(this Ef6DatabaseUpdateSettings settings, string target)
        {
            if (settings == null)
                throw new ArgumentNullException(nameof(settings));

            settings.Target = target;

            return settings;
        }

        /// <summary>
        /// Generate a SQL script rather than executing the pending changes directly.
        /// </summary>
        /// <param name="settings">The settings.</param>
        /// <returns>The <paramref name="settings"/> instance with <see cref="Ef6DatabaseUpdateSettings.Script"/> set to true.</returns>
        public static Ef6DatabaseUpdateSettings ScriptChanges(this Ef6DatabaseUpdateSettings settings)
        {
            if (settings == null)
                throw new ArgumentNullException(nameof(settings));

            settings.Script = true;

            return settings;
        }

        /// <summary>
        /// Specifies that data loss is acceptable during automatic migration of the database.
        /// </summary>
        /// <param name="settings">The settings.</param>
        /// <returns>The <paramref name="settings"/> instance with <see cref="Ef6DatabaseUpdateSettings.Force"/> set to true.</returns>
        public static Ef6DatabaseUpdateSettings ForceChanges(this Ef6DatabaseUpdateSettings settings)
        {
            if (settings == null)
                throw new ArgumentNullException(nameof(settings));

            settings.Force = true;

            return settings;
        }

        /// <summary>
        /// Specifies the migrations configuration (TYPE) to use. If omitted, migrations will attempt to locate a single migrations configuration type in the target project.
        /// </summary>
        /// <param name="settings">The settings.</param>
        /// <param name="migrationsConfigurationType">Language the Migrations Request is coded in.</param>
        /// <returns>The <paramref name="settings"/> instance with <see cref="Ef6DatabaseUpdateSettings.MigrationsConfigurationType"/> set to <paramref name="migrationsConfigurationType"/>.</returns>
        public static Ef6DatabaseUpdateSettings SetMigrationsConfigurationType(this Ef6DatabaseUpdateSettings settings, string migrationsConfigurationType)
        {
            if (settings == null)
                throw new ArgumentNullException(nameof(settings));

            settings.MigrationsConfigurationType = migrationsConfigurationType;

            return settings;
        }

        /// <summary>
        ///  The assembly to use.
        /// </summary>
        /// <param name="settings">The settings.</param>
        /// <param name="assembly">Assembly Path</param>
        /// <returns>The <paramref name="settings"/> instance with <see cref="Ef6DatabaseUpdateSettings.Assembly"/> set to <paramref name="assembly"/>.</returns>
        public static Ef6DatabaseUpdateSettings FromAssembly(this Ef6DatabaseUpdateSettings settings, FilePath assembly)
        {
            if (settings == null)
                throw new ArgumentNullException(nameof(settings));

            settings.Assembly = assembly;

            return settings;
        }

        /// <summary>
        /// The project directory. Defaults to the current directory.
        /// </summary>
        /// <param name="settings">The settings.</param>
        /// <param name="projectDirectory">Project Directory Path</param>
        /// <returns>The <paramref name="settings"/> instance with <see cref="Ef6DatabaseUpdateSettings.ProjectDirectory"/> set to <paramref name="projectDirectory"/>.</returns>
        public static Ef6DatabaseUpdateSettings FromProjectDirectory(this Ef6DatabaseUpdateSettings settings, DirectoryPath projectDirectory)
        {
            if (settings == null)
                throw new ArgumentNullException(nameof(settings));

            settings.ProjectDirectory = projectDirectory;

            return settings;
        }

        /// <summary>
        /// The language. Defaults to 'C#'.
        /// </summary>
        /// <param name="settings">The settings.</param>
        /// <param name="language">Language the Migrations Request is coded in.</param>
        /// <returns>The <paramref name="settings"/> instance with <see cref="Ef6DatabaseUpdateSettings.Language"/> set to <paramref name="language"/>.</returns>
        public static Ef6DatabaseUpdateSettings SetLanguage(this Ef6DatabaseUpdateSettings settings, string language)
        {
            if (settings == null)
                throw new ArgumentNullException(nameof(settings));

            settings.Language = language;

            return settings;
        }

        /// <summary>
        /// The root namespace. Defaults to the target assembly name.
        /// </summary>
        /// <param name="settings">The settings.</param>
        /// <param name="rootNamespace">Namespace the migrations is located in.</param>
        /// <returns>The <paramref name="settings"/> instance with <see cref="Ef6DatabaseUpdateSettings.RootNamespace"/> set to <paramref name="rootNamespace"/>.</returns>
        public static Ef6DatabaseUpdateSettings SetRootNamespace(this Ef6DatabaseUpdateSettings settings, string rootNamespace)
        {
            if (settings == null)
                throw new ArgumentNullException(nameof(settings));

            settings.RootNamespace = rootNamespace;

            return settings;
        }

        /// <summary>
        /// The data directory
        /// </summary>
        /// <param name="settings">The settings.</param>
        /// <param name="dataDirectory">Namespace the migrations is located in.</param>
        /// <returns>The <paramref name="settings"/> instance with <see cref="Ef6DatabaseUpdateSettings.DataDirectory"/> set to <paramref name="dataDirectory"/>.</returns>
        public static Ef6DatabaseUpdateSettings FromDataDirectory(this Ef6DatabaseUpdateSettings settings, DirectoryPath dataDirectory)
        {
            if (settings == null)
                throw new ArgumentNullException(nameof(settings));

            settings.DataDirectory = dataDirectory;

            return settings;
        }

        /// <summary>
        ///  Specifies the configuration file to use for named connection strings.
        /// </summary>
        /// <param name="settings">The settings.</param>
        /// <param name="configFilePath">Assembly Path</param>
        /// <returns>The <paramref name="settings"/> instance with <see cref="Ef6DatabaseUpdateSettings.ConfigurationFile"/> set to <paramref name="configFilePath"/>.</returns>
        public static Ef6DatabaseUpdateSettings FromConfigurationFile(this Ef6DatabaseUpdateSettings settings, FilePath configFilePath)
        {
            if (settings == null)
                throw new ArgumentNullException(nameof(settings));

            settings.ConfigurationFile = configFilePath;

            return settings;
        }

        /// <summary>
        /// Specifies the name of a connection string to use from the application's configuration file.
        /// </summary>
        /// <param name="settings">The settings.</param>
        /// <param name="connectionStringName">Name of the connection string in the configuration file</param>
        /// <returns>The <paramref name="settings"/> instance with <see cref="Ef6DatabaseUpdateSettings.ConnectionStringName"/> set to <paramref name="connectionStringName"/>.</returns>
        public static Ef6DatabaseUpdateSettings SetConnectionStringName(this Ef6DatabaseUpdateSettings settings, string connectionStringName)
        {
            if (settings == null)
                throw new ArgumentNullException(nameof(settings));

            settings.ConnectionStringName = connectionStringName;

            return settings;
        }

        /// <summary>
        /// Specifies the connection string to use. If omitted, the context's default connection will be used.
        /// </summary>
        /// <param name="settings">The settings.</param>
        /// <param name="connectionString">Name of the connection string in the configuration file</param>
        /// <returns>The <paramref name="settings"/> instance with <see cref="Ef6DatabaseUpdateSettings.ConnectionString"/> set to <paramref name="connectionString"/>.</returns>
        public static Ef6DatabaseUpdateSettings SetConnectionString(this Ef6DatabaseUpdateSettings settings, string connectionString)
        {
            if (settings == null)
                throw new ArgumentNullException(nameof(settings));

            settings.ConnectionString = connectionString;

            return settings;
        }

        /// <summary>
        /// Specifies the connection string to use. If omitted, the context's default connection will be used.
        /// </summary>
        /// <param name="settings">The settings.</param>
        /// <param name="connectionProvider">Name of the connection string in the configuration file</param>
        /// <returns>The <paramref name="settings"/> instance with <see cref="Ef6DatabaseUpdateSettings.ConnectionProvider"/> set to <paramref name="connectionProvider"/>.</returns>
        public static Ef6DatabaseUpdateSettings SetConnectionprovider(this Ef6DatabaseUpdateSettings settings, string connectionProvider)
        {
            if (settings == null)
                throw new ArgumentNullException(nameof(settings));

            settings.ConnectionProvider = connectionProvider;

            return settings;
        }
    }
}
