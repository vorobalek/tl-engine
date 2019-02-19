dotnet dev-certs https --trust

rd /s /q "..\TL Engine Developer"
rd /s /q "TL.Engine\bin"
rd /s /q "TL.Engine\Data"
rd /s /q "TL.Engine\Extensions"
dotnet build -c Release
xcopy ".\TL.Clean" ".\TL.Engine" /I /H /Y /C /R /S /EXCLUDE:.\.list_no_copy_clean
@echo off
(echo.0)>.last_migration_version
@echo on
cd "TL.Engine"
dotnet ef database update
cd "..\"
rd /s /q "TL.Engine\Extensions"
dotnet build -c Release
call copy_all.bat

pause