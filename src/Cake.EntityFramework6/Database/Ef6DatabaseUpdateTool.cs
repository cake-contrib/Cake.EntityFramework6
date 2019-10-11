using Cake.Core;
using Cake.Core.Diagnostics;
using Cake.Core.IO;
using Cake.Core.Tooling;
using System;

namespace Cake.EntityFramework6.Database
{
    /// <summary>
    /// Tool for updating a database using EF6 migrations and the ef6.exe console tool
    /// </summary>
    public class Ef6DatabaseUpdateTool : Ef6Tool<Ef6DatabaseUpdateSettings>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Ef6DatabaseUpdateTool"/> class.
        /// </summary>
        /// <param name="fileSystem">The file system.</param>
        /// <param name="environment">The environment.</param>
        /// <param name="processRunner">The process runner.</param>
        /// <param name="tools">The tool locator.</param>
        /// <param name="log">Cake log instance.</param>
        public Ef6DatabaseUpdateTool(IFileSystem fileSystem, ICakeEnvironment environment, IProcessRunner processRunner, IToolLocator tools, ICakeLog log)
            : base(fileSystem, environment, processRunner, tools, log)
        { }

        /// <summary>
        /// Applies any pending migrations to the database using the specified <see cref="Ef6DatabaseUpdateSettings"/> settings.
        /// </summary>
        /// <param name="settings">The settings.</param>
        public void Update(Ef6DatabaseUpdateSettings settings)
        {
            if (settings == null)
                throw new ArgumentNullException(nameof(settings));

            RunCore(settings);
        }
    }
}
