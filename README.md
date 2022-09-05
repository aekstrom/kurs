# Empty CMS template

## How to run

Chose one of the following options to get started. 

### Windows

Prerequisities
- .NET SDK 6+
- SQL Server 2016 Express LocalDB (or later)

```bash
$ dotnet run
````

### Any OS with Docker

Prerequisities
- Docker
- Enable Docker support when applying the template

```bash
$ docker-compose up
````

> Note that this Docker setup is just configured for local development. Follow this [guide to enable HTTPS](https://github.com/dotnet/dotnet-docker/blob/main/samples/run-aspnetcore-https-development.md).

### Any OS with external database server

Prerequisities
- .NET SDK 6+
- SQL Server 2016 (or later) on a external server, e.g. Azure SQL

Create an empty database on the external database server and update the connection string accordingly.

```bash
$ dotnet run
````

###More
Environment setup tasks (these only need running once)

Run powershell (pswh in terminal or from finder, mission control, etc)
Run dotnet new -i EPiServer.Net.Templates --nuget-source https://nuget.optimizely.com/feed/packages.svc/ --force
Run dotnet tool install EPiServer.Net.Cli --global --add-source https://nuget.optimizely.com/feed/packages.svc/
Run dotnet nuget add source http://nuget.episerver.com/feed/packages.svc -n Optimizely
Run dotnet dev-certs https --trust

Setup a DB server on Docker
Grab the docker compose file sql-compose.yml.
In Terminal run docker compose up from where you saved the docker compose file.

Create a new empty project. In Powershell run the following
dotnet new epi-cms-empty --name kurs
cd kurs
dotnet-episerver create-cms-database kurs.csproj -S localhost -U sa -P 0pti_R0cks
dotnet-episerver add-admin-user kurs.csproj -u admin -p P4ssw0rd! -e user@email.com -c EPiServerDB
dotnet build
dotnet run
