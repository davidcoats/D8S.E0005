# WebAPI-WebLibrary-FrameworkReference-NET8
A class library with types that depend on ASP.NET Core types.

This library uses the suggested way of referencing ASP.NET Core types: https://learn.microsoft.com/en-us/aspnet/core/fundamentals/target-aspnetcore?view=aspnetcore-8.0&tabs=visual-studio#use-the-aspnet-core-shared-framework
Specifically, the project SDK value "Microsoft.NET.Sdk" is used, but a framework reference is added to "Microsoft.AspNetCore.App"

Example:
<ItemGroup>
	<FrameworkReference Include="Microsoft.AspNetCore.App" />
</ItemGroup>

Note: You cannot use .NET Standard 2.1 (netstandard2.1) for this! Instead, you need to choose a target framework that allows for framework references (https://learn.microsoft.com/en-us/dotnet/core/project-sdk/msbuild-props#frameworkreference). Which is netcoreapp3.0 hor higher (https://learn.microsoft.com/en-us/aspnet/core/migration/22-to-30?view=aspnetcore-3.1&tabs=visual-studio#remove-obsolete-package-references).

Note that the available ASP.NET Core types are then decided by the target framework (net6.0 vs. net8.0). For example, the .NET 8.0 WebApplicationBuilder has the Metrics: IMetricsBuilder property, while the .NET 6.0 WebApplicationBuilder does not.

Framework reference documentation is here: https://learn.microsoft.com/en-us/aspnet/core/migration/22-to-30?view=aspnetcore-3.1&tabs=visual-studio#framework-reference
