using Cake.EntityFramework6.Database;

namespace Cake.EntityFramework6.Tests.Database
{
    internal sealed class Ef6DatabaseUpdateToolFixture : Ef6ToolFixture<Ef6DatabaseUpdateSettings>
    {
        protected override void RunTool()
        {
            var tool = new Ef6DatabaseUpdateTool(FileSystem, Environment, ProcessRunner, Tools, Log);
            tool.Update(Settings);
        }
    }
}
