@echo off
(echo.cd netcoreapp2.2
echo.dotnet TL.Engine.dll --ef-migrate-check
echo.pause)> "..\TL Engine Developer\check_db.bat"

(echo.cd netcoreapp2.2
echo.dotnet TL.Engine.dll --ef-migrate
echo.pause)> "..\TL Engine Developer\init_db.bat"
