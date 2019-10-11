using Xunit;

namespace Cake.EntityFramework6.Tests.Database
{
    public sealed class Ef6DatabaseUpdateTests
    {
        public sealed class TheUpdateMethod
        {
            [Fact]
            public void Should_Redirect_Standard_Error()
            {
                var fixture = new Ef6DatabaseUpdateToolFixture();
                fixture.Settings.RedirectStandardError = true; ;

                var result = fixture.Run();

                Assert.True(result.Process.RedirectStandardError);
            }

            [Fact]
            public void Should_Throw_If_Settings_Are_Null()
            {
                // Given
                var fixture = new Ef6DatabaseUpdateToolFixture();
                fixture.Settings = null;

                // When
                var result = Record.Exception(() => fixture.Run());

                // Then
                result.IsArgumentNullException("settings");
            }

            [Theory]
            [InlineData(true, "database update --script")]
            [InlineData(false, "database update")]
            public void Should_Add_Script_To_Arguments_If_Not_False(bool value, string expected)
            {
                // Given
                var fixture = new Ef6DatabaseUpdateToolFixture();
                fixture.Settings.Script = value;

                // When
                var result = fixture.Run();

                // Then
                Assert.Equal(expected, result.Args);
            }

            [Theory]
            [InlineData("20190201_CakeUserAdded", "database update --source \"20190201_CakeUserAdded\"")]
            [InlineData("", "database update")]
            [InlineData(" ", "database update")]
            [InlineData(null, "database update")]
            public void Should_Add_Source_To_Arguments(string value, string expected)
            {
                // Given
                var fixture = new Ef6DatabaseUpdateToolFixture();
                fixture.Settings.Source = value;

                // When
                var result = fixture.Run();

                // Then
                Assert.Equal(expected, result.Args);
            }

            [Theory]
            [InlineData("20190202_CakeUserRemoved", "database update --target \"20190202_CakeUserRemoved\"")]
            [InlineData("", "database update")]
            [InlineData(" ", "database update")]
            [InlineData(null, "database update")]
            public void Should_Add_Target_To_Arguments(string value, string expected)
            {
                // Given
                var fixture = new Ef6DatabaseUpdateToolFixture();
                fixture.Settings.Target = value;

                // When
                var result = fixture.Run();

                // Then
                Assert.Equal(expected, result.Args);
            }

            [Theory]
            [InlineData(true, "database update --force")]
            [InlineData(false, "database update")]
            public void Should_Add_Force_To_Arguments_If_Not_False(bool value, string expected)
            {
                // Given
                var fixture = new Ef6DatabaseUpdateToolFixture();
                fixture.Settings.Force = value;

                // When
                var result = fixture.Run();

                // Then
                Assert.Equal(expected, result.Args);
            }

            [Theory]
            [InlineData("Cake.Core.Database.MigrationsDb", "database update --migrations-config \"Cake.Core.Database.MigrationsDb\"")]
            [InlineData("", "database update")]
            [InlineData(" ", "database update")]
            [InlineData(null, "database update")]
            public void Should_Add_MigrationsConfiguration_Type_To_Arguments(string value, string expected)
            {
                // Given
                var fixture = new Ef6DatabaseUpdateToolFixture();
                fixture.Settings.MigrationsConfigurationType = value;

                // When
                var result = fixture.Run();

                // Then
                Assert.Equal(expected, result.Args);
            }

            [Theory]
            [InlineData("c:/Temp/Cake.Core.Database.dll", "database update --assembly \"c:/Temp/Cake.Core.Database.dll\"")]
            [InlineData("", "database update")]
            [InlineData(" ", "database update")]
            [InlineData(null, "database update")]
            public void Should_Add_Assembly_Path_To_Arguments(string value, string expected)
            {
                // Given
                var fixture = new Ef6DatabaseUpdateToolFixture();
                fixture.Settings.Assembly = value;

                // When
                var result = fixture.Run();

                // Then
                Assert.Equal(expected, result.Args);
            }

            [Theory]
            [InlineData("c:/Temp/", "database update --project-dir \"c:/Temp\"")]
            [InlineData("", "database update")]
            [InlineData(" ", "database update")]
            [InlineData(null, "database update")]
            public void Should_Add_Project_Directory_To_Arguments(string value, string expected)
            {
                // Given
                var fixture = new Ef6DatabaseUpdateToolFixture();
                fixture.Settings.ProjectDirectory = value;

                // When
                var result = fixture.Run();

                // Then
                Assert.Equal(expected, result.Args);
            }

            [Theory]
            [InlineData("C#", "database update --language \"C#\"")]
            [InlineData("", "database update")]
            [InlineData(" ", "database update")]
            [InlineData(null, "database update")]
            public void Should_Add_Language_To_Arguments(string value, string expected)
            {
                // Given
                var fixture = new Ef6DatabaseUpdateToolFixture();
                fixture.Settings.Language = value;

                // When
                var result = fixture.Run();

                // Then
                Assert.Equal(expected, result.Args);
            }

            [Theory]
            [InlineData("Cake.Core.Database", "database update --root-namespace \"Cake.Core.Database\"")]
            [InlineData("", "database update")]
            [InlineData(" ", "database update")]
            [InlineData(null, "database update")]
            public void Should_Add_Root_Namespace_To_Arguments(string value, string expected)
            {
                // Given
                var fixture = new Ef6DatabaseUpdateToolFixture();
                fixture.Settings.RootNamespace = value;

                // When
                var result = fixture.Run();

                // Then
                Assert.Equal(expected, result.Args);
            }

            [Theory]
            [InlineData("c:/Temp/DataDirectory", "database update --data-dir \"c:/Temp/DataDirectory\"")]
            [InlineData("", "database update")]
            [InlineData(" ", "database update")]
            [InlineData(null, "database update")]
            public void Should_Add_Data_Directory_To_Arguments(string value, string expected)
            {
                // Given
                var fixture = new Ef6DatabaseUpdateToolFixture();
                fixture.Settings.DataDirectory = value;

                // When
                var result = fixture.Run();

                // Then
                Assert.Equal(expected, result.Args);
            }

            [Theory]
            [InlineData("c:/Temp/app.config", "database update --config \"c:/Temp/app.config\"")]
            [InlineData("", "database update")]
            [InlineData(" ", "database update")]
            [InlineData(null, "database update")]
            public void Should_Add_Configuration_File_Path_To_Arguments(string value, string expected)
            {
                // Given
                var fixture = new Ef6DatabaseUpdateToolFixture();
                fixture.Settings.ConfigurationFile = value;

                // When
                var result = fixture.Run();

                // Then
                Assert.Equal(expected, result.Args);
            }

            [Theory]
            [InlineData("MigrationsDb", "database update --connection-string-name \"MigrationsDb\"")]
            [InlineData("", "database update")]
            [InlineData(" ", "database update")]
            [InlineData(null, "database update")]
            public void Should_Add_ConnectionStringName_To_Arguments(string value, string expected)
            {
                // Given
                var fixture = new Ef6DatabaseUpdateToolFixture();
                fixture.Settings.ConnectionStringName = value;

                // When
                var result = fixture.Run();

                // Then
                Assert.Equal(expected, result.Args);
            }

            [Theory]
            [InlineData("Server=myServerAddress;Database=myDataBase;Trusted_Connection=True;", "database update --connection-string \"Server=myServerAddress;Database=myDataBase;Trusted_Connection=True;\"")]
            [InlineData("", "database update")]
            [InlineData(" ", "database update")]
            [InlineData(null, "database update")]
            public void Should_Add_ConnectionString_To_Arguments(string value, string expected)
            {
                // Given
                var fixture = new Ef6DatabaseUpdateToolFixture();
                fixture.Settings.ConnectionString = value;

                // When
                var result = fixture.Run();

                // Then
                Assert.Equal(expected, result.Args);
            }

            [Theory]
            [InlineData("System.Data.SqlClient", "database update --connection-provider \"System.Data.SqlClient\"")]
            [InlineData("", "database update")]
            [InlineData(" ", "database update")]
            [InlineData(null, "database update")]
            public void Should_Add_ConnectionProvider_To_Arguments(string value, string expected)
            {
                // Given
                var fixture = new Ef6DatabaseUpdateToolFixture();
                fixture.Settings.ConnectionProvider = value;

                // When
                var result = fixture.Run();

                // Then
                Assert.Equal(expected, result.Args);
            }
        }
    }
}
