# Dime.Rules

Simple rule engine.

## Installation

Use the package manager NuGet to install the package:

```cli
dotnet add package Dime.Rules
```

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

## Local development

- You must have Visual Studio 2022 Community or higher.
- The dotnet cli is also highly recommended.

## License

[![License](http://img.shields.io/:license-mit-blue.svg?style=flat-square)](http://badges.mit-license.org)