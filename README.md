# LUA Translate Tool

### About
This is a simple tool for translating Lua files using Google Translate. The tool is written in C# using the .NET Framework.

------------

### Preview
Streamable:  [View](https://streamable.com/8l1jr2 "View")

------------
### Changelogs v1.1.2

- Implemented FastColoredTextBox text editor
- Removed the “Clear Selected” and “Syntax Highlight” buttons
- And a few other minor fixes

------------

### Changelogs v1.1.1

- Added "Highlight" button: Highlights all text in RichTextBox.
- Added "Macro delay (Seconds)": Sets an interval in seconds during macro tasks.
- Added LinkLabel "About": Opens the URL of the Github repository in a web browser.
- Changed the name of the "Clear Highlight" button to "Clear Selected."
- Improved web elements on the translation page
- Improved automation (macro) code.
- Removed the "Close Ad" button.
- And some other minor modifications.

------------

### Changelogs v1.1

- Added “Prev” & “Next” buttons: Allows users to navigate back or forward and select values from a LUA table.
- Added “Copy” button: Enables users to copy translations from Google Translate.
- Added “Clear Highlight” button: Clears text highlights made with “Prev/Next” buttons.
- Added “Start Macro” button and a text box: Lets users set how many times the Macro should perform its tasks.
- Added “Close Ad” button: Closes the floating window to download Google Chrome.
- Added “Refresh” button: Refreshes the translation page.
- Added “Hide” button: Hides the translation page.
- Added “Show” button: Displays the translation page.
- Added automatic backup system: Makes a backup of your modifications in the file “%Temp%\LuaTranslateTool\backup_time_date.lua” when the "RichTextBox Text Changed" event is triggered.

------------

### Prerequisites

- Windows 7+
- .NET Framework 6.0 or later

## License

This project is licensed under the MIT License - see the [LICENSE](https://github.com/0wn1/LUATranslateTool/blob/main/LICENSE) file for details.
