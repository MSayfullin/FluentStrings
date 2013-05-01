@ECHO OFF
SET PACKAGESPATH=bin\packages
IF NOT EXIST %PACKAGESPATH% md %PACKAGESPATH%
"%WINDIR%\Microsoft.NET\Framework\v4.0.30319\MSBuild" FluentStrings.sln /t:Rebuild /p:Configuration=Release /m
packages\NuGet pack dokas.FluentStrings.nuspec -OutputDirectory %PACKAGESPATH% -Symbols -Version %1