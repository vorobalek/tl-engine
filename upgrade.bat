xcopy ..\TLEngine\netcoreapp2.1\Data .\TL.Engine\Data /I /H /Y /C /R /S
rd /s /q ..\TLEngine
rd /s /q TL.Engine\Extensions

dotnet build -c Release

for /F %%F in (.last_migration_version) do (
	cd TL.Engine
	dotnet ef migrations add MigrationUpdate%%F
	dotnet ef database update
	cd ..\
	version_inc.exe .last_migration_version
)

call copy_all.dat

pause