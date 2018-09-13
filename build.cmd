@echo off

REM Set variables
set Configuration=Release
set OutputDir=artifacts\

REM Remove bin/ folders
rmdir /s/q src\AsyncQueryable\bin
rmdir /s/q src\AsyncQueryable.Fakes\bin
rmdir /s/q src\AsyncQueryable.MongoDb\bin

dotnet pack -c %Configuration% src\AsyncQueryable.sln

REM Delete OutputDir
if exist %OutputDir% rmdir /s/q %OutputDir%
mkdir %OutputDir%

REM Copy nuget packages to OutputDir
copy src\AsyncQueryable\bin\%Configuration%\*.nupkg %OutputDir%
copy src\AsyncQueryable.Fakes\bin\%Configuration%\*.nupkg %OutputDir%
copy src\AsyncQueryable.MongoDb\bin\%Configuration%\*.nupkg %OutputDir%