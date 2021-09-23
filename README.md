# Dotnet Generating Documentation

This sample demonstrates generating scoped documentation of .NET projects.

## Getting Started

1.  Build the solution

    ```sh
    dotnet build
    ```

    The above should involve restoring nuget packages, which includes the `docfx` command-line tool.

1.  Build and serve the documentation for Contracts in the solution (you may need to add the `docfx.console/{version}/tools`
    directory to your PATH)

        ```sh
        docfx ./docs/contracts/dtos/docfx.json --serve
        ```

For further details, see [Getting Started with DocFX](https://dotnet.github.io/docfx/tutorial/docfx_getting_started.html).
