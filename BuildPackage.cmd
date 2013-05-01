@ECHO OFF
SET PACKAGESPATH=bin\packages
IF NOT EXIST %PACKAGESPATH% md %PACKAGESPATH%
"%VS110COMNTOOLS%nuget" pack dokas.FluentStrings.nuspec -OutputDirectory %PACKAGESPATH% -Symbols -Version %1