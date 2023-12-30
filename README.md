<div align="center"><img src="assets/logo.png?raw=true" width="350" alt="Logo"></div>


<div align="center"><h1>Dime.Rules</h1></div>

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
using Dime.Rules;

public bool Validate(MyClass item)
{
    var rule1 = new ValidationRule<Customer>(x => x != null, "Item cannot be null");
    var rule2 = new ValidationRule<Customer>(x => x.IsActive == true, "IsActive needs to be true");

    ValidationEngine<Customer> engine = new ValidationEngine<Customer>(rule1, rule2);
    ValidationResult validationResult = engine.Validate(item);
    return validationResult.IsValid;
}
```

## Contributing

![PRs Welcome](https://img.shields.io/badge/PRs-welcome-brightgreen.svg?style=flat-square)

Pull requests are welcome. Please check out the contribution and code of conduct guidelines.

## License

[![License](http://img.shields.io/:license-mit-blue.svg?style=flat-square)](http://badges.mit-license.org)