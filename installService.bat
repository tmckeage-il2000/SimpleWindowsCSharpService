@ECHO OFF

set DOTNETFX2=%SystemRoot%\Microsoft.NET\Framework\v4.0.30319
set PATH=%PATH%;%DOTNETFX2%

echo Installing SimpleWindowsCSharpService...
echo ---------------------------------------------------
InstallUtil /i SimpleWindowsCSharpService\bin\Debug\SimpleWindowsCSharpService.exe
echo ---------------------------------------------------
echo Done.