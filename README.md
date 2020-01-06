# Dime.Rules

[![Build Status](https://dev.azure.com/dimenicsbe/Utilities/_apis/build/status/Rules%20-%20MAIN%20-%20CI?branchName=master)](https://dev.azure.com/dimenicsbe/Utilities/_build/latest?definitionId=89&branchName=master)

## Introduction

Simple rule engine.

## Getting Started

- You must have Visual Studio 2019 Community or higher.
- The dotnet cli is also highly recommended.

## About this project

Simple rule engine.

## Build and Test

- Run dotnet restore
- Run dotnet build
- Run dotnet test

## Installation

Use the package manager NuGet to install Dime.Rules:

- dotnet cli: `dotnet add package Dime.Rules`
- Package manager: `Install-Package Dime.Rules`

## Usage

``` csharp
    using Dime.Validation;
    
    public bool Validate(MyClass item)
    {
        var rule1 = new ValidationRule<MyClass>(x => x != null, "Item cannot be null");
        var rule2 = new ValidationRule<MyClass>(x => x.MyBoolean == true, "MyBoolean needs to be true");

        ValidationEngine<MyClass> engine = new ValidationEngine<MyClass>(rule1, rule2);
        ValidationResult validationResult = engine.Validate(item);
        return validationResult.IsValid;
    }
```

## Contributing

Pull requests are welcome. For major changes, please open an issue first to discuss what you would like to change.
Please make sure to update tests as appropriate.

## License

MIT