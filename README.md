# Qué hay configurado en esta plantilla

1. Un proyecto de biblioteca (creado con [`dotnet new classlib`](https://docs.microsoft.com/en-us/dotnet/core/tools/dotnet-new?tabs=netcore22)) en la carpeta `src\ClassLibrary`
2. Un proyecto de aplicación de consola (creado con [`dotnet new console`](https://docs.microsoft.com/en-us/dotnet/core/tools/dotnet-new?tabs=netcore22)) en la carpeta `src\ConsoleApplication`
3. Un proyecto de prueba en [NUnit](https://nunit.org/) (creado con [`dotnet new nunit`](https://docs.microsoft.com/en-us/dotnet/core/tools/dotnet-new?tabs=netcore22))) en la carpeta `test\NUnitTestProject`
4. Un proyecto de [DocFx](https://dotnet.github.io/docfx/) para generación de sitio web de documentación en la carpeta `docs`
5. Análisis estático con [FxCop](https://github.com/dotnet/roslyn-analyzers/blob/master/README.md) en los proyectos de biblioteca y de aplicación
6. Análisis de estilo con [StyleCop](https://github.com/DotNetAnalyzers/StyleCopAnalyzers/blob/master/README.md) en los proyectos de biblioteca y de aplicación
7. Una solución que referencia todos los proyectos de C#
8. Tareas preconfiguradas para compilar y ejecutar los proyectos de consola y de pruebas desde VSCode en la carpeta `.vscode`


# Dónde encontrar información sobre los errores/avisos al compilar

[C# Compiler Errors (CS*)](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/compiler-messages/)

[FxCop Analyzer Warnings (CA*)](https://docs.microsoft.com/en-us/visualstudio/code-quality/code-analysis-warnings-for-managed-code-by-checkid?view=vs-2019)

[StyleCop Analyzer Warnings (SA*)](https://github.com/DotNetAnalyzers/StyleCopAnalyzers/blob/master/DOCUMENTATION.md)

# Cómo deshabilitar temporalmente los avisos al compilar

## FxCop Analyzer

Comentar la línea `<PackageReference Include="Microsoft.CodeAnalysis.FxCopAnalyzers" Version="2.9.3" />` en los archivos de proyecto (`*.csproj`)

## StyleCop Analyzer

Comentar la línea `<PackageReference Include="StyleCop.Analyzers" Version="1.1.118" />` en los archivos de proyecto (`*.csproj`)