Push-Location $PSScriptRoot
$timestamp = Get-Date -Format "yyyyMMddHHmmss"
dotnet pack --configuration Release --version-suffix "preview.$timestamp" --tl:auto