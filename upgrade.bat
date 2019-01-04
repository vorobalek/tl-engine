taskkill /F /IM dotnet.exe
xcopy "..\TL Engine Developer\netcoreapp2.2\Data" ".\TL.Engine\Data" /I /H /Y /C /R /S
rd /s /q "..\TL Engine Developer"
rd /s /q "TL.Engine\bin"
rd /s /q "TL.Engine\Extensions"
dotnet build -c Release
for /F %%F in (.last_migration_version) do (
	cd "TL.Engine"
	dotnet ef migrations add MigrationUpdate%%F
	dotnet ef database update
	cd "..\"
	version_inc.exe .last_migration_version
)
rd /s /q "TL.Engine\Extensions"
dotnet build -c Release
call copy_all.bat
call restart.bat