using Cake.Core.IO;
using System;

namespace Cake.EntityFramework6
{
    /// <summary>
    /// Extensions for <see cref="Ef6Settings"/>.
    /// </summary>
    public static class Ef6SettingsExtensions
    {
        /// <summary>
        /// Sets the verbose output for Entity Framework output. (e.g. - Show verbose output).
        /// </summary>
        /// <param name="settings">The settings.</param>
        /// <returns>The <paramref name="settings"/> instance with <see cref="Ef6Settings.Verbose"/> set to true.</returns>
        public static Ef6Settings SetVerbose(this Ef6Settings settings)
        {
            if (settings == null)
                throw new ArgumentNullException(nameof(settings));

            settings.Verbose = true;

            return settings;
        }

        /// <summary>
        /// Sets the no color output for Entity Framework output (e.g. - Don't colorize output).
        /// </summary>
        /// <param name="settings">The settings.</param>
        /// <returns>The <paramref name="settings"/> instance with <see cref="Ef6Settings.NoColor"/> set to true.</returns>
        public static Ef6Settings SetNoColor(this Ef6Settings settings)
        {
            if (settings == null)
                throw new ArgumentNullException(nameof(settings));

            settings.NoColor = true;

            return settings;
        }

        /// <summary>
        /// Sets the version to show  for the e6.exe. (e.g. -  Show version information).
        /// </summary>
        /// <param name="settings">The settings.</param>
        /// <returns>The <paramref name="settings"/> instance with <see cref="Ef6Settings.Version"/> set to true.</returns>
        public static Ef6Settings SetVersion(this Ef6Settings settings)
        {
            if (settings == null)
                throw new ArgumentNullException(nameof(settings));

            settings.Version = true;

            return settings;
        }

        /// <summary>
        /// Sets the Prefix Out with level for the e6.exe. (e.g. - Prefix output with level.).
        /// </summary>
        /// <param name="settings">The settings.</param>
        /// <returns>The <paramref name="settings"/> instance with <see cref="Ef6Settings.PrefixOutput"/> set to true.</returns>
        public static Ef6Settings SetPrefixOutput(this Ef6Settings settings)
        {
            if (settings == null)
                throw new ArgumentNullException(nameof(settings));

            settings.PrefixOutput = true;

            return settings;
        }

        /// <summary>
        /// Sets the working directory which should be used to run the ef6.exe command.
        /// </summary>
        /// <param name="settings">The settings.</param>
        /// <param name="path">Working directory which should be used to run the ef6.exe command.</param>
        /// <returns>The <paramref name="settings"/> instance with <see cref="Core.Tooling.ToolSettings.WorkingDirectory"/> set to <paramref name="path"/>.</returns>
        public static Ef6Settings FromPath(this Ef6Settings settings, DirectoryPath path)
        {
            if (settings == null)
                throw new ArgumentNullException(nameof(settings));

            settings.WorkingDirectory = path ?? throw new ArgumentNullException(nameof(path));

            return settings;
        }
    }
}
