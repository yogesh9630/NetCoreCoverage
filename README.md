# NetCoreCoverage
A .NET 5 solution example, to get metric coverage from the differents projects of the solution.

## Description

In this project has been used the following tools and NuGet Packages to extract the metric solutions:

- [Coverlet](https://github.com/coverlet-coverage/coverlet)
- [NUnit](https://github.com/nunit/nunit)
- [ReportGenerator](https://github.com/danielpalme/ReportGenerator)

## Getting Started

### Dependencies or tool necesaries

* Visual Studio Community 2019
* .NET 5.0

### Installing

* Clone project.
* Open NetCoreCoverage.sln


### Steps (using dotnet command)

1. Build the solution in relase target (from the base repository folder).

```
>dotnet build NetCoreCoverage.sln --configuration Release
```

2. Run the unit tests from the solution in relase target (from the base repository folder) and generate results. This command will displayed by in the command line the results of the coverage, and futhermore, this command will generate a file (.\TestResults\coverage.cobertura.xml)

```
>dotnet test NetCoreCoverage.sln --configuration Release /p:CollectCoverage=true /p:CoverletOutputFormat=cobertura /p:Exclude="[xunit*]\*" /p:CoverletOutput="../TestResults/"

```

3. Report coverage metrics in html format. This command consume the '.\TestResults\coverage.cobertura.xml' file and generate a output folder with a index.hmtl file to visualize the results in a browser.

```
>reportgenerator "-reports:TestResults\coverage.cobertura.xml" "-targetdir:TestResults\html" -reporttypes:Html -historydir:HistoriDirectory
```

4. 

## Help

Any advise for common problems or issues.


## Authors

Javier Carracedo 

Twitter Profile: [@JaviKarra94](https://twitter.com/JaviKarra94)

## Version History


## License

This project is licensed under the [NAME HERE] License - see the LICENSE.md file for details.
