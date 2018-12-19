dotnet dev-certs https --trust
cd ".\TL.Engine"
dotnet publish --self-contained -r win10-x64 -o "..\..\TL Engine Enterprise\"
xcopy "Data" "..\..\TL Engine Enterprise\Data" /I /H /Y /C /R /S /EXCLUDE:..\.list_no_copy_databases
xcopy "Extensions" "..\..\TL Engine Enterprise\Extensions" /I /H /Y /C /R /S /EXCLUDE:..\.list_no_copy_extensions

pause