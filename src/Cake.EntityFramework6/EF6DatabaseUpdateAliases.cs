using Cake.Core;
using Cake.Core.Annotations;
using Cake.EntityFramework6.Database;
using System;

namespace Cake.EntityFramework6
{
    /// <summary>
    /// Entity Framework 6 (ef6.exe) Database Update aliases
    /// </summary>
    [CakeAliasCategory("EntityFramework6")]
    [CakeNamespaceImport("Cake.EntityFramework6.Database")]
    public static class EF6DatabaseUpdateAliases
    {
        /// <summary>
        ///  Applies any pending migrations to the database using the ef6.exe migration tool. 
        /// </summary>
        /// <param name="context">The context.</param>
        /// <param name="configurator">The settings configurator.</param>
        /// <example>
        /// <para> Applies any pending migrations to the database using the ef6.exe migration tool.  ('ef6 database update')</para>
        /// <code>
        /// <![CDATA[
        ///     Ef6DatabaseUpdate(context, settings =>
        ///     {
        ///         settings
        ///             .FromAssembly("c:/myproject/MyProject.Data.dll")
        ///             .ForceChanges()
        ///             .SetConnectionStringName("MyDataDb")
        ///             .FromConfigurationFile("c:/myproject/app.config")
        ///             .SetMigrationsConfigurationType("MyDb.Configuration.Data.MyDbMigrationsConfiguration")
        ///             .SetVerbose()
        ///             .SetVersion()
        ///             .FromPath(@"c:/myproject");
        ///     });
        /// ]]>
        /// </code>
        /// </example>
        [CakeMethodAlias]
        [CakeAliasCategory("Database")]
        public static void Ef6DatabaseUpdate(this ICakeContext context, Action<Ef6DatabaseUpdateSettings> configurator)
        {
            if (context == null)
                throw new ArgumentNullException(nameof(context));

            if (configurator == null)
                throw new ArgumentNullException(nameof(configurator));

            var settings = new Ef6DatabaseUpdateSettings();
            configurator(settings);
            context.Ef6DatabaseUpdate(settings);
        }

        /// <summary>
        /// Applies any pending migrations to the database using the ef6.exe migration tool. 
        /// </summary>
        /// <param name="context">The context.</param>
        /// <param name="settings">The settings.</param>
        /// <example>
        /// <para> Applies any pending migrations to the database using the ef6.exe migration tool.  ('ef6 database update')</para>
        /// <code>
        /// <![CDATA[
        ///     var settings = new Ef6DatabaseUpdateSettings
        ///     {
        ///         WorkingDirectory = @"c:/myproject",
        ///         Assembly = "c:/myproject/MyProject.Data.dll",
        ///         Force = true,
        ///         ConnectionStringName = "MyDataDb",
        ///         ConfigurationFile = "c:/myproject/app.config",
        ///         MigrationsConfigurationType = "MyDb.Configuration.Data.MyDbMigrationsConfiguration",
        ///         Verbose = true,
        ///         Version = true
        ///     };
        ///     Ef6DatabaseUpdate(settings);
        /// ]]>
        /// </code>
        /// </example>
        [CakeMethodAlias]
        [CakeAliasCategory("Database")]
        public static void Ef6DatabaseUpdate(this ICakeContext context, Ef6DatabaseUpdateSettings settings)
        {
            if (context == null)
                throw new ArgumentNullException(nameof(context));

            if (settings == null)
                throw new ArgumentNullException(nameof(settings));

            Ef6AddinInformation.LogVersionInformation(context.Log);
            var tool = new Ef6DatabaseUpdateTool(context.FileSystem, context.Environment, context.ProcessRunner, context.Tools, context.Log);
            tool.Update(settings);
        }
    }
}
