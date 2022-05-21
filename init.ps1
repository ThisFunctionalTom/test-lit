pnpm create vite $Name --template vanilla
Set-Location $Name
dotnet new tool-manifest
dotnet tool install fable
dotnet tool install femto
dotnet new classlib -o src -n $Name