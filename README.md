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
    $fileName = $args[0]
    $fullPath = (Resolve-Path $fileName).Path
    $rootPath = $args[1]

    if (!$rootPath) {
        $loc = $fullPath.ToLowerInvariant().IndexOf("\private\")

        if ($loc -ge 0) {
            $rootPath = $fullPath.Substring(0, $loc)
        } else {
            Write-Host "Could not infer the root path. Falling back to hard-coded value."
            $rootPath = "C:\src\github\Treit\Scratch\ProjectConverter"
        }
    }

```

## Try-Convert
```
dotnet tool install --global Try-Convert
```

These tools may fail to run if you do not have older legacy .NET runtimes installed, such as .NET 5.0.

Can force a roll-forward with:

```ps
$env:DOTNET_ROLL_FORWARD = 'LatestMajor'
```