dotnet dev-certs https --trust

rd /s /q ..\TLEngine
rd /s /q TL.Engine\Data
rd /s /q TL.Engine\Extensions
rd /s /q TL.Engine\Migrations

dotnet build -c Release

xcopy .\TL.Clean .\TL.Engine /I /H /Y /C /R /S /EXCLUDE:.\.list_no_copy_clean

@echo off
(echo.0)>.last_migration_version
@echo on
cd TL.Engine
dotnet ef migrations add InitialCreate
dotnet ef database update
cd ..\
version_inc.exe .last_migration_version

call copy_all.bat

pause