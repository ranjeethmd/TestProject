using Spectre.Console;

// Modern C# top-level program with Spectre.Console
// Display "Hello World" with enhanced styling

// Create a beautiful panel with gradient colors
var panel = new Panel(new Markup("[bold yellow]Hello World![/]"))
    .Border(BoxBorder.Double)
    .BorderColor(Color.Cyan1)
    .Header("[bold blue]🌟 Welcome to .NET 10 🌟[/]")
    .HeaderAlignment(Justify.Center)
    .Padding(2, 1);

// Display the panel
AnsiConsole.Write(panel);

// Add some additional styled text
AnsiConsole.WriteLine();
AnsiConsole.Write(new Rule("[bold green]Modern C# Console Application[/]").RuleStyle("dim"));
AnsiConsole.WriteLine();

// Display system information with colors
var table = new Table()
    .Border(TableBorder.Rounded)
    .BorderColor(Color.Purple)
    .AddColumn(new TableColumn("[bold cyan]Property[/]").Centered())
    .AddColumn(new TableColumn("[bold magenta]Value[/]").Centered())
    .AddRow("[yellow].NET Version[/]", $"[green]{Environment.Version}[/]")
    .AddRow("[yellow]OS Platform[/]", $"[green]{Environment.OSVersion.Platform}[/]")
    .AddRow("[yellow]Machine Name[/]", $"[green]{Environment.MachineName}[/]")
    .AddRow("[yellow]Current Time[/]", $"[green]{DateTime.Now:yyyy-MM-dd HH:mm:ss}[/]");

AnsiConsole.Write(table);

// Add a colorful goodbye message
AnsiConsole.WriteLine();
AnsiConsole.Write(new Markup("[bold rainbow]Thank you for using our modern .NET 10 Hello World application! ✨[/]"));
AnsiConsole.WriteLine();