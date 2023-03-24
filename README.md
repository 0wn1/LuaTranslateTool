# LUA Translate Tool

This is a simple tool for translating Lua files using Google Translate. The tool is written in C# using the .NET Framework.

------------
## Preview
Streamable (v1.1.0): [View](https://streamable.com/l38yit "View")

Streamable (v1.0.0): [View](https://streamable.com/136d2v "View")

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

## Prerequisites

- Windows 7+
- .NET Framework 6.0 or later

## Usage

1. Open the Translate Tool.
2. Click the "Open Lua File" button and select the Lua file you want to translate.
3. Select the text you want to translate in the editor.
4. Enter the target language code (e.g. "es" for Spanish) in the textbox.
5. Click the "Translate Selected Text" button to translate the selected text using Google Translate.
6. The translated text will be displayed in a web view, click over the floating window and press `Escape`. Close the web view when you are finished.
7. To save the translated text, click the "Save Lua File" button and select a location to save the file.

## Features

- Open and edit Lua files.
- Translate selected text using Google Translate.
- Copy selected text to clipboard.
- Replace selected text with clipboard contents.
- Save edited Lua files.
- Copy all edited text to clipboard.

## License

This project is licensed under the MIT License - see the [LICENSE](https://github.com/0wn1/LUATranslateTool/blob/main/LICENSE) file for details.
