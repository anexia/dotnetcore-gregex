## Anexia.Gregex

[![](https://img.shields.io/nuget/v/Anexia.Gregex "NuGet version badge")](https://www.nuget.org/packages/Anexia.Gregex)
[![](https://github.com/anexia/dotnetcore-gregex/actions/workflows/test.yml/badge.svg?branch=main "Test status")](https://github.com/anexia/dotnetcore-gregex/actions/workflows/test.yml)
[![codecov.io](https://codecov.io/github/Anexia/gregex/coverage.svg?branch=main "Code coverage")](https://codecov.io/github/Anexia/dotnetcore-gregex/coverage.svg?branch=main)


Generalized regular expressions for sequences (IEnumerables, Lists, Arrays).

## Goals

Provide an API to match lists similar to how you can match regexes against strings.

### Usage

The main entry point is the ```Gregex``` class it allows you to construct expressions. You can use the
Matcher class to match these expressions against instances of IEnumerable.

Example:
```
using Anexia.Gregex;

var testList = "FooBarFooBarFoo".ToCharArray();

var gregex = Gregex.Is('o').Times(2);

var matcher = new Matcher<char>();

var matches = matcher.FindMatches(gregex, testList).ToArray();

Console.WriteLine($"Found: {matches.Length} matches.");
Console.WriteLine(string.Join("\n", matches.AsEnumerable()));
```

You can find more detailed examples in the [Examples Folder](examples).

### Contributing

Contributions are welcomed! Read the [Contributing Guide](CONTRIBUTING.md) for more information.

### Licensing

See [LICENSE](LICENSE) for more information.
