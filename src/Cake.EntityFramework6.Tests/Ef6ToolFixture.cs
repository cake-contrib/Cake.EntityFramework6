using Cake.Core.Diagnostics;
using Cake.Core.IO;
using Cake.Core.Tooling;
using Cake.Testing;
using Cake.Testing.Fixtures;

namespace Cake.EntityFramework6.Tests
{
    internal abstract class Ef6ToolFixture<TSettings> : Ef6ToolFixture<TSettings, ToolFixtureResult>
         where TSettings : ToolSettings, new()
    {
        protected override ToolFixtureResult CreateResult(FilePath path, ProcessSettings process)
        {
            return new ToolFixtureResult(path, process);
        }
    }

    internal abstract class Ef6ToolFixture<TSettings, TFixtureResult> : ToolFixture<TSettings, TFixtureResult>
        where TSettings : ToolSettings, new()
        where TFixtureResult : ToolFixtureResult
    {
        protected Ef6ToolFixture()
            : base("ef6")
        {
            Log.Verbosity = Verbosity.Normal;
        }

        protected ICakeLog Log { get; } = new FakeLog();
    }
}
