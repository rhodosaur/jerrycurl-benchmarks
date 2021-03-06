$exe = Join-Path $PSScriptRoot "RawBencher.Core\bin\Release\netcoreapp3.1\RawBencher.Core.exe"
$path =  Join-Path $PSScriptRoot ("Results\{0:yyyyMMdd_HHmmss}_jc_netcore31.txt" -f (Get-Date))

Write-Host "Building project..." -ForegroundColor Yellow
dotnet build --nologo -v q -c Release
if ($LastExitCode -ne 0) { Exit -1 }

Write-Host "Benchmarking .NET Core 3.1..." -ForegroundColor Yellow
& $exe /a > $path
$dest = Split-Path $path -Leaf
Write-Host "Done! Wrote results to 'Results\$dest'" -ForegroundColor Green