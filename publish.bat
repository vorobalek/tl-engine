rd /s /q "..\TL Engine Enterprise"
dotnet dev-certs https --trust
cd ".\TL.Engine"
dotnet publish --framework netcoreapp2.2 -r win-x86 --force --self-contained  -o "..\..\TL Engine Enterprise\"
cd "..\"
xcopy ".\TL.Engine\Data" "..\TL Engine Enterprise\Data" /I /H /Y /C /R /S /EXCLUDE:.\.list_no_copy_databases
xcopy ".\TL.Engine\Extensions" "..\TL Engine Enterprise\Extensions" /I /H /Y /C /R /S /EXCLUDE:.\.list_no_copy_extensions
@echo off
(echo.dotnet TL.Engine.dll)> "..\TL Engine Enterprise\run.bat"
pause