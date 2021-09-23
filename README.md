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

1.  Feel free to modify files within `docs` subdirectories. A brief outline of these files, relative to `docs/contracts/dtos`
    are:

    -   `docfx.json`: The configuration that the `docfx` tool uses to construct static documentation from .NET source
        code. See [docfx.json Format](https://dotnet.github.io/docfx/tutorial/docfx.exe_user_manual.html#3-docfxjson-format)
        for more
    -   `index.md`: The main landing page of the scoped documentation. For the purposes of this sample, the 'scope'
        chosen is the `Contracts` project of the `DotnetGeneratingDocumentation` solution
    -   `toc.yml`: Configuration for the main site navigation
    -   `overview/toc.yml`: Configuration for the 'Overview' directory's navigation
    -   `api` directory: Contains mostly generated (by `docfx`) files. `api/index.md` is the landing page for the 'Api
        Documentation'
    -   `images`: Houses any visual resources referenced in documentation that is to be hosted on the site
    -   `_site`: Once the `docfx` command has been run as described in the previous step, this generated directory
        serves as the web root for the documentation site

For further details, see [Getting Started with DocFX](https://dotnet.github.io/docfx/tutorial/docfx_getting_started.html).
