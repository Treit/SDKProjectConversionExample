# SDKProjectConversionExample
Legacy .NET Framework project to be used as an example for converting to the SDK style project format

Two tools for converting legacy projects to the new SDK format:

## Project2015To2017.Migrate2017.Tool
First is an older tool that existed before the .NET team provided their Try-Convert tool:
```
dotnet tool install --global Project2015To2017.Migrate2017.Tool
```

Can use the above with a little helper PowerShell function like this:

```ps
function conv
{
    dotnet-migrate-2017 migrate $args[0]
    $fldr = (Split-Path $args[0])
    Remove-Item $fldr\Backup -rec -force
}
```

## Try-Convert
```
dotnet tool install --global Try-Convert
```
