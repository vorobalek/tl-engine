dotnet dev-certs https --trust

rd /s /q "..\TL Engine Developer"
rd /s /q "TL.Engine\bin"
rd /s /q "TL.Engine\Data"
rd /s /q "TL.Engine\Extensions"

dotnet build -c Release

xcopy ".\TL.Clean" ".\TL.Engine" /I /H /Y /C /R /S /EXCLUDE:.\.list_no_copy_clean

call copy_all.bat

pause