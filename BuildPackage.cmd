@ECHO OFF
SET PACKAGESPATH=FluentStrings\bin\Packages
IF NOT EXIST %PACKAGESPATH% md %PACKAGESPATH%
"%VS110COMNTOOLS%nuget" pack dokas.FluentStrings.nuspec -OutputDirectory %PACKAGESPATH% -Symbols -Version %1