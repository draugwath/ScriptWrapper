# ScriptWrapper

ScriptWrapper is a Windows Forms application that provides a graphical user interface (GUI) for controlling a proprietary script. The application allows users to configure options, run the script, and view the script output.

## Getting Started

### Prerequisites

- [Visual Studio](https://visualstudio.microsoft.com/downloads/) (2019 or earlier recommended)
- .NET 4.0 SDK (comes with Visual Studio 2019)
- The proprietary script and its dependencies (debug-tools-new folder) should be placed in the root directory of the repository.

### Building the Solution

1. Clone this repository:

```
git clone https://github.com/draugwath/ScriptWrapper.git
```

2. Place the `debug-tools-new` folder containing the proprietary script and its dependencies in the root directory of the repository.

3. Open the `ScriptWrapper.sln` file in Visual Studio.

4. Build the solution by clicking `Build` > `Build Solution` from the menu or by pressing `Ctrl+Shift+B`.

5. Run the application by pressing `F5` or clicking `Debug` > `Start Debugging`.

### Publishing the Application

To create a standalone executable, follow these steps:

1. In Visual Studio, right-click the `ScriptWrapper` project in the Solution Explorer and select `Publish`.

2. Choose a target location for the publish output, and click `Publish`.

3. The resulting published application will be available at the specified location.

## License

This project is licensed under the MIT License.
