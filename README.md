# Excel File Reader Application

## Overview

This C# console application is designed to read data from `.xlsx` files using the ClosedXML library. It provides a simple demonstration of how to use ClosedXML to extract information from Excel spreadsheets in a structured and efficient manner.

## Features

- Read `.xlsx` files and print the content to the console.
- Handle various data types stored within the Excel cells.
- Provide clear error messages for common issues like missing files.

## Prerequisites

Before running this application, ensure you have the following installed:

- .NET 5.0 SDK or later
- ClosedXML library (This can be installed via NuGet Package Manager)

## Getting Started

To run this application, follow these steps:

1. Clone the repository to your local machine.
2. Navigate to the project directory.
3. Run the application using the .NET CLI with the command `dotnet run`.
4. To read a specific `.xlsx` file, place it in the `uploads` directory or modify the `filePath` variable in the `Program.cs` to point to the correct file location.

## Usage

The application is executed from the command line. It does not require any command-line arguments as it is preconfigured to read a file named `company.xlsx` from an `uploads` folder within the project directory.

If you need to read a different file, you can change the `filePath` variable in the `Program.cs` file to the path of your `.xlsx` file.

## Contributing

Contributions to this project are welcome. Please fork the repository and submit a pull request with your proposed changes.

## License

This project is
