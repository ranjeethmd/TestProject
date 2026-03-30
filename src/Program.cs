using Spectre.Console;

// Modern C# top-level program with Spectre.Console
// Display "Hello World" with enhanced styling for .NET 10 (currently .NET 8)

// Clear the console for a clean start
AnsiConsole.Clear();

// Display a welcome banner
var welcomeRule = new Rule("[bold blue]🌟 Welcome to Modern .NET Console Application 🌟[/]")
{
    Style = Style.Parse("blue dim"),
    Alignment = Justify.Center
};
AnsiConsole.Write(welcomeRule);
AnsiConsole.WriteLine();

// Create a beautiful "Hello World" panel with gradient colors
var helloPanel = new Panel(new Markup("[bold yellow on blue] Hello World! [/]"))
    .Border(BoxBorder.Double)
    .BorderColor(Color.Cyan1)
    .Header("[bold magenta]🚀 .NET 10 Ready Application 🚀[/]")
    .HeaderAlignment(Justify.Center)
    .Padding(3, 1)
    .Expand();

AnsiConsole.Write(helloPanel);
AnsiConsole.WriteLine();

// Create an informative table with system details
var infoTable = new Table()
    .Border(TableBorder.Rounded)
    .BorderColor(Color.Purple)
    .Title("[bold underline green]System Information[/]")
    .AddColumn(new TableColumn("[bold cyan]Property[/]").Centered())
    .AddColumn(new TableColumn("[bold magenta]Value[/]").Centered())
    .AddRow("[yellow]Framework[/]", $"[green]{System.Runtime.InteropServices.RuntimeInformation.FrameworkDescription}[/]")
    .AddRow("[yellow].NET Version[/]", $"[green]{Environment.Version}[/]")
    .AddRow("[yellow]OS Platform[/]", $"[green]{Environment.OSVersion.Platform}[/]")
    .AddRow("[yellow]OS Version[/]", $"[green]{Environment.OSVersion.VersionString}[/]")
    .AddRow("[yellow]Machine Name[/]", $"[green]{Environment.MachineName}[/]")
    .AddRow("[yellow]User Name[/]", $"[green]{Environment.UserName}[/]")
    .AddRow("[yellow]Current Time[/]", $"[green]{DateTime.Now:yyyy-MM-dd HH:mm:ss}[/]")
    .AddRow("[yellow]Architecture[/]", $"[green]{System.Runtime.InteropServices.RuntimeInformation.ProcessArchitecture}[/]");

AnsiConsole.Write(infoTable);
AnsiConsole.WriteLine();

// Display a feature showcase
var featureRule = new Rule("[bold green]✨ Application Features ✨[/]")
{
    Style = Style.Parse("green dim"),
    Alignment = Justify.Center
};
AnsiConsole.Write(featureRule);

// Create a grid to show features
var grid = new Grid();
grid.AddColumn(new GridColumn().NoWrap().PadRight(4));
grid.AddColumn(new GridColumn().NoWrap().PadRight(4));
grid.AddColumn();

grid.AddRow(
    new Markup("[bold blue]🎯[/]"),
    new Markup("[bold]Modern C# Patterns[/]"),
    new Markup("[dim]Top-level programs, implicit usings, nullable reference types[/]")
);

grid.AddRow(
    new Markup("[bold red]🌈[/]"),
    new Markup("[bold]Rich Console Output[/]"),
    new Markup("[dim]Colors, panels, tables, and beautiful formatting[/]")
);

grid.AddRow(
    new Markup("[bold yellow]📊[/]"),
    new Markup("[bold]System Information[/]"),
    new Markup("[dim]Runtime environment details and diagnostics[/]")
);

grid.AddRow(
    new Markup("[bold green]🚀[/]"),
    new Markup("[bold]Future Ready[/]"),
    new Markup("[dim]Prepared for .NET 10 with modern architecture[/]")
);

AnsiConsole.Write(grid);
AnsiConsole.WriteLine();

// Add a colorful goodbye message with progress simulation
AnsiConsole.Write(new Rule("[bold cyan]Thank You[/]").RuleStyle("dim"));

var goodbyePanel = new Panel(
    new Markup("[bold rainbow]Thank you for exploring our modern .NET console application! ✨\n\n" +
               "[dim]This application demonstrates:[/]\n" +
               "• [green]Spectre.Console[/] for beautiful terminal UI\n" +
               "• [blue]Modern C# language features[/]\n" +
               "• [yellow]Cross-platform compatibility[/]\n" +
               "• [magenta]Clean architecture patterns[/]\n\n" +
               "[bold]Ready for .NET 10 when it arrives! 🎉[/]"))
    .Border(BoxBorder.Rounded)
    .BorderColor(Color.Green)
    .Header("[bold blue]🎊 Application Complete 🎊[/]")
    .HeaderAlignment(Justify.Center)
    .Padding(2, 1);

AnsiConsole.Write(goodbyePanel);
AnsiConsole.WriteLine();