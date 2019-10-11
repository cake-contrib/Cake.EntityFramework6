using Cake.EntityFramework6.Database;
using Shouldly;
using Xunit;

namespace Cake.EntityFramework6.Tests
{
    public sealed class Ef6SettingsExtensionsTests
    {
        public sealed class TheSetVerboseMethod
        {
            [Fact]
            public void Should_Throw_If_Settings_Are_Null()
            {
                // Given
                Ef6Settings settings = null;

                // When
                var result = Record.Exception(() => settings.SetVerbose());

                // Then
                result.IsArgumentNullException(nameof(settings));
            }

            [Fact]
            public void Should_Set_Verbose_To_True()
            {
                // Given
                var settings = new Ef6DatabaseUpdateSettings();

                // When
                settings.SetVerbose();

                // Then
                settings.Verbose.ShouldBeTrue();
            }
        }

        public sealed class TheSetNoColorMethod
        {
            [Fact]
            public void Should_Throw_If_Settings_Are_Null()
            {
                // Given
                Ef6Settings settings = null;

                // When
                var result = Record.Exception(() => settings.SetNoColor());

                // Then
                result.IsArgumentNullException(nameof(settings));
            }

            [Fact]
            public void Should_Set_NoColor_To_True()
            {
                // Given
                var settings = new Ef6DatabaseUpdateSettings();

                // When
                settings.SetNoColor();

                // Then
                settings.NoColor.ShouldBeTrue();
            }
        }

        public sealed class TheSetVersionMethod
        {
            [Fact]
            public void Should_Throw_If_Settings_Are_Null()
            {
                // Given
                Ef6Settings settings = null;

                // When
                var result = Record.Exception(() => settings.SetVersion());

                // Then
                result.IsArgumentNullException(nameof(settings));
            }

            [Fact]
            public void Should_Set_Version_To_True()
            {
                // Given
                var settings = new Ef6DatabaseUpdateSettings();

                // When
                settings.SetVersion();

                // Then
                settings.Version.ShouldBeTrue();
            }

        }

        public sealed class TheSetPrefixOutputMethod
        {
            [Fact]
            public void Should_Throw_If_Settings_Are_Null()
            {
                // Given
                Ef6Settings settings = null;

                // When
                var result = Record.Exception(() => settings.SetPrefixOutput());

                // Then
                result.IsArgumentNullException(nameof(settings));
            }

            [Fact]
            public void Should_Set_PrefixOutput_To_True()
            {
                // Given
                var settings = new Ef6DatabaseUpdateSettings();

                // When
                settings.SetPrefixOutput();

                // Then
                settings.PrefixOutput.ShouldBeTrue();
            }
        }

        public sealed class TheFromPathMethod
        {
            [Fact]
            public void Should_Throw_If_Settings_Are_Null()
            {
                // Given
                Ef6Settings settings = null;

                // When
                var result = Record.Exception(() => settings.FromPath(@"c:\temp"));

                // Then
                result.IsArgumentNullException(nameof(settings));
            }

            [Fact]
            public void Should_Throw_If_Path_Is_Null()
            {
                // Given
                var settings = new Ef6DatabaseUpdateSettings();

                // When
                var result = Record.Exception(() => settings.FromPath(null));

                // Then
                result.IsArgumentNullException("path");
            }

            [Fact]
            public void Should_Set_WorkingDirectory()
            {
                // Given
                var settings = new Ef6DatabaseUpdateSettings();

                // When
                settings.FromPath(@"c:\temp");

                // Then
                settings.WorkingDirectory.ToString().ShouldBe(@"c:/temp");
            }
        }
    }
}
