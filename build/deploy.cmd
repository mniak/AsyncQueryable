@echo off

set SCRIPT_DIR=%~dp0
set ARTIFACTS_DIR=%SCRIPT_DIR%..\artifacts\

set Source=%1
set ApiKey=%2

for %%f in (%ARTIFACTS_DIR%*.nupkg) do (
    dotnet nuget push %%f --source %Source% --api-key %ApiKey%
)
