# Modern .NET 10 Console Application with Spectre.Console

A modern C# console application that displays "Hello World" with enhanced styling using Spectre.Console library, built with .NET 10.

## Features

- 🎯 **Modern C# Patterns**: Uses top-level programs and latest C# features
- 🌈 **Enhanced Console Output**: Beautiful styling with Spectre.Console
- 📊 **System Information Display**: Shows runtime environment details
- 🎨 **Rich Formatting**: Panels, tables, colors, and Unicode symbols
- ⚡ **Fast Performance**: Optimized for .NET 10
- 🚀 **Latest Framework**: Built with .NET 10

## Requirements

- [.NET 10 SDK](https://dotnet.microsoft.com/download/dotnet/10.0) or later
- Terminal with Unicode and color support (Windows Terminal, macOS Terminal, or modern Linux terminal)

## Project Structure

```
├── src/
│   ├── HelloWorld.csproj    # Project file targeting .NET 10
│   └── Program.cs           # Main application with top-level program
├── .gitignore              # Git ignore patterns for .NET projects
└── README.md               # This file
```

## Getting Started

### 1. Clone the Repository

```bash
git clone https://github.com/ranjeethmd/TestProject.git
cd TestProject
```

### 2. Build the Application

```bash
cd src
dotnet build
```

### 3. Run the Application

```bash
dotnet run
```

Or build and run in one command:

```bash
dotnet run --project src/HelloWorld.csproj
```

### 4. Create a Release Build

```bash
dotnet build --configuration Release
```

## Dependencies

- **Spectre.Console** (v0.49.1): A .NET library that makes it easier to create beautiful console applications with rich formatting, tables, panels, and more.

## What You'll See

The application displays:

1. 🌟 A beautiful "Hello World" message in a styled panel with double borders
2. 📋 A system information table showing:
   - .NET runtime version
   - Operating system platform
   - Machine name
   - Current timestamp
3. 🎨 Colorful text with gradients and Unicode symbols

## Technical Details

- **Target Framework**: `net10.0`
- **Language Features**: 
  - Top-level programs (C# 9+)
  - Implicit usings (C# 10+)
  - Nullable reference types enabled
- **Console Enhancement**: Spectre.Console for rich terminal UI
- **Modern Patterns**: Minimal API-style program structure

## Development

### Adding New Features

The application uses Spectre.Console which provides many features:

- **Panels and Borders**: Create beautiful boxes around content
- **Tables**: Display structured data with styling
- **Colors and Markup**: Rich text formatting with BBCode-like syntax
- **Progress Bars**: Show long-running operations
- **Prompts**: Interactive user input with validation
- **Trees**: Hierarchical data display

### Example Extensions

```csharp
// Add a progress bar
await AnsiConsole.Progress()
    .StartAsync(async ctx =>
    {
        var task = ctx.AddTask("[green]Processing...[/]");
        while (!task.IsFinished)
        {
            await Task.Delay(100);
            task.Increment(10);
        }
    });

// Add user interaction
var name = AnsiConsole.Ask<string>("What's your [green]name[/]?");
AnsiConsole.WriteLine($"Hello {name}!");
```

## Troubleshooting

### Common Issues

1. **Target framework not found**: Ensure you have .NET 10 SDK installed
2. **Colors not showing**: Use a modern terminal that supports ANSI colors
3. **Unicode symbols broken**: Ensure your terminal supports UTF-8 encoding

### Checking .NET Installation

```bash
dotnet --version
dotnet --list-sdks
```

## Contributing

1. Fork the repository
2. Create a feature branch (`git checkout -b feature/amazing-feature`)
3. Commit your changes (`git commit -m 'Add some amazing feature'`)
4. Push to the branch (`git push origin feature/amazing-feature`)
5. Open a Pull Request

## License

This project is part of a learning exercise and is available under the MIT License.

---

Built with ❤️ using .NET 10 and Spectre.Console