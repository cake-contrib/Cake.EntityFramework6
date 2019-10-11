---
Order: 2
Title: ef6.exe cli Reference
---

The **ef6.exe** utility for enabling, adding, scripting, and applying migrations from assemblies. This replaces **migrate.exe**.  

Below is a summary of the commands available and used in this Cake.EntityFramework6 plugin.  

```powershell

                    / __|
         ___  ___  | |__
        | __|| __| |  _ \
        | _| | _|  | |_| |
        |___||_|    \___/

Entity Framework Command-line Tools 6.3.0

Usage: ef6 [options] [command]

Options:
  --version        Show version information
  -h|--help        Show help information
  -v|--verbose     Show verbose output.
  --no-color       Don't colorize output.
  --prefix-output  Prefix output with level.

Commands:
  database    Commands to manage the database.
  migrations  Commands to manage migrations.
```

## Database Commands

```powershell
Usage: ef6 database [options] [command]

Options:
  -h|--help        Show help information
  -v|--verbose     Show verbose output.
  --no-color       Don't colorize output.
  --prefix-output  Prefix output with level.

Commands:
  update  Applies any pending migrations to the database.
```

### Database Update

```powershell
Usage: ef6 database update [options]

Options:
  --source <MIGRATION>             Only valid with --script. Specifies the name of a particular migration to use as the update's starting point. If omitted, the last applied migration in the database will be used.
  --target <MIGRATION>             Specifies the name of a particular migration to update the database to. If omitted, the current model will be used.
  --script                         Generate a SQL script rather than executing the pending changes directly.
  -f|--force                       Specifies that data loss is acceptable during automatic migration of the database.
  --migrations-config <TYPE>       Specifies the migrations configuration to use. If omitted, migrations will attempt to locate a single migrations configuration type in the target project.
  -a|--assembly <PATH>             The assembly to use.
  --project-dir <PATH>             The project directory. Defaults to the current directory.
  --language <LANGUAGE>            The language. Defaults to 'C#'.
  --root-namespace <NAMESPACE>     The root namespace. Defaults to the target assembly name.
  --data-dir <PATH>                The data directory.
  --config <PATH>                  Specifies the configuration file to use for named connection strings.
  --connection-string-name <NAME>  Specifies the name of a connection string to use from the application's configuration file.
  --connection-string <STRING>     Specifies the connection string to use. If omitted, the context's default connection will be used.
  --connection-provider <NAME>     Specifies the provider invariant name of the connection string.
  -h|--help                        Show help information
  -v|--verbose                     Show verbose output.
  --no-color                       Don't colorize output.
  --prefix-output                  Prefix output with level.
```

## Migrations

```powershell
Usage: ef6 migrations [options] [command]

Options:
  -h|--help        Show help information
  -v|--verbose     Show verbose output.
  --no-color       Don't colorize output.
  --prefix-output  Prefix output with level.

Commands:
  add     Scaffolds a migration script for any pending model changes.
  enable  Enables Code First Migrations in a project.
  list    Displays the migrations that have been applied to the target database.
```


### Migrations Add

```powershell
Usage: ef6 migrations add [arguments] [options]

Arguments:
  <NAME>  Specifies the name of the custom script.

Options:
  -f|--force                       Specifies that the migration user code be overwritten when re-scaffolding an existing migration.
  --ignore-changes                 Scaffolds an empty migration ignoring any pending changes detected in the current model. This can be used to create an initial, empty migration to enable Migrations for an existing database. N.B. Doing this assumes that the target database schema is compatible with the current model.
  --json                           Show JSON output.
  --migrations-config <TYPE>       Specifies the migrations configuration to use. If omitted, migrations will attempt to locate a single migrations configuration type in the target project.
  -a|--assembly <PATH>             The assembly to use.
  --project-dir <PATH>             The project directory. Defaults to the current directory.
  --language <LANGUAGE>            The language. Defaults to 'C#'.
  --root-namespace <NAMESPACE>     The root namespace. Defaults to the target assembly name.
  --data-dir <PATH>                The data directory.
  --config <PATH>                  Specifies the configuration file to use for named connection strings.
  --connection-string-name <NAME>  Specifies the name of a connection string to use from the application's configuration file.
  --connection-string <STRING>     Specifies the connection string to use. If omitted, the context's default connection will be used.
  --connection-provider <NAME>     Specifies the provider invariant name of the connection string.
  -h|--help                        Show help information
  -v|--verbose                     Show verbose output.
  --no-color                       Don't colorize output.
  --prefix-output                  Prefix output with level.
```

### Migrations Enable

```powershell
Usage: ef6 migrations enable [options]

Options:
  --auto                           Specifies whether automatic migrations will be enabled in the scaffolded migrations configuration. If omitted, automatic migrations will be disabled.
  -f|--force                       Specifies that the migrations configuration be overwritten when running more than once for a given project.
  --migrations-dir <PATH>          Specifies the name of the directory that will contain migrations code files. If omitted, the directory will be named "Migrations".
  -c|--context <DBCONTEXT>         Specifies the context to use. If omitted, migrations will attempt to locate a single context type in the target project.
  --context-assembly <PATH>        Specifies the name of the assembly which contains the DbContext class to use. If omitted, the context is assumed to be in the same assembly used for migrations.
  --json                           Show JSON output.
  -a|--assembly <PATH>             The assembly to use.
  --project-dir <PATH>             The project directory. Defaults to the current directory.
  --language <LANGUAGE>            The language. Defaults to 'C#'.
  --root-namespace <NAMESPACE>     The root namespace. Defaults to the target assembly name.
  --data-dir <PATH>                The data directory.
  --config <PATH>                  Specifies the configuration file to use for named connection strings.
  --connection-string-name <NAME>  Specifies the name of a connection string to use from the application's configuration file.
  --connection-string <STRING>     Specifies the connection string to use. If omitted, the context's default connection will be used.
  --connection-provider <NAME>     Specifies the provider invariant name of the connection string.
  -h|--help                        Show help information
  -v|--verbose                     Show verbose output.
  --no-color                       Don't colorize output.
  --prefix-output                  Prefix output with level.
```

### Migrations List

```powershell
Usage: ef6 migrations list [options]

Options:
  --migrations-config <TYPE>       Specifies the migrations configuration to use. If omitted, migrations will attempt to locate a single migrations configuration type in the target project.
  -a|--assembly <PATH>             The assembly to use.
  --project-dir <PATH>             The project directory. Defaults to the current directory.
  --language <LANGUAGE>            The language. Defaults to 'C#'.
  --root-namespace <NAMESPACE>     The root namespace. Defaults to the target assembly name.
  --data-dir <PATH>                The data directory.
  --config <PATH>                  Specifies the configuration file to use for named connection strings.
  --connection-string-name <NAME>  Specifies the name of a connection string to use from the application's configuration file.
  --connection-string <STRING>     Specifies the connection string to use. If omitted, the context's default connection will be used.
  --connection-provider <NAME>     Specifies the provider invariant name of the connection string.
  -h|--help                        Show help information
  -v|--verbose                     Show verbose output.
  --no-color                       Don't colorize output.
  --prefix-output                  Prefix output with level.
  ```