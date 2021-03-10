@echo off

SET DIR=%~d0%~p0%

SET sql.files.directory="%DIR%scripts"
SET connectionString="Host=127.0.0.1;User Id=yugabyte;Password=yugabyte;Database=testdb;Port=5433;SslMode=Disable"
SET databaseType="postgres"
SET environment="development"

"rh.exe" /f=%sql.files.directory% /c=%connectionString% /dt=%databaseType% /env=%environment% /drop /silent /v=0
"rh.exe" /f=%sql.files.directory% /c=%connectionString% /dt=%databaseType% /env=%environment% /silent /v=0