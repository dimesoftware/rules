# Dime.Rules

[![Build Status](https://dev.azure.com/dimenicsbe/Utilities/_apis/build/status/Rules%20-%20MAIN%20-%20CI?branchName=master)](https://dev.azure.com/dimenicsbe/Utilities/_build/latest?definitionId=89&branchName=master) ![Azure DevOps coverage](https://img.shields.io/azure-devops/coverage/dimenicsbe/Utilities/89?label=code%20coverage)

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