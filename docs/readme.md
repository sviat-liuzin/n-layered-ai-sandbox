Development tasks

1. EF Core

1.1 Create migration (run inside "src" folder)

dotnet ef migrations add InitialCreateMyMaps --project RedPanda.NLayered.Data.Sql --startup-project RedPanda.NLayered.Web --output-dir Migrations

1.2 Apply migrations to the database

dotnet ef database update --project RedPanda.NLayered.Data.Sql --startup-project RedPanda.NLayered.Web

2. Docker

2.1 Create docker image for SQL Server

docker run -e "ACCEPT_EULA=Y" -e "MSSQL_SA_PASSWORD=123qweASD" -p 1433:1433 --name sqlserver -d mcr.microsoft.com/mssql/server:2022-latest

2.2 Run already created docker image

docker start sqlserver
