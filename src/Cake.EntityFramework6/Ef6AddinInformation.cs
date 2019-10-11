using Cake.Core.Diagnostics;
using System.Reflection;

namespace Cake.EntityFramework6
{
    internal static class Ef6AddinInformation
    {
        private static readonly string InformationalVersion = typeof(Ef6AddinInformation).GetTypeInfo().Assembly.GetCustomAttribute<AssemblyInformationalVersionAttribute>()?.InformationalVersion;
        private static readonly string AssemblyVersion = typeof(Ef6AddinInformation).GetTypeInfo().Assembly.GetName().Version.ToString();
        private static readonly string AssemblyName = typeof(Ef6AddinInformation).GetTypeInfo().Assembly.GetName().Name;

        /// <summary>
        /// verbosely log addin version information
        /// </summary>
        /// <param name="log"></param>
        public static void LogVersionInformation(ICakeLog log)
        {
            log.Verbose(entry => entry("Using addin: {0} v{1} ({2})", AssemblyName, AssemblyVersion, InformationalVersion));
        }
    }
}
