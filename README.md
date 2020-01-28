# Car Vendor
Project Asp.Net Core in the back-end with Angular
Features (More will be added as the project evolves):



# Creation
## Commands used
### Dot Net project
```sh
dotnet new angular
```

### MSSQL Database
Install Docker and
```sh
docker pull microsoft/mssql-server-linux
docker run -e 'ACCEPT_EULA=Y' -e 'SA_PASSWORD=AddC0mplexP455W0rdH5r3!' -p 1433:1433 -v /home/userorotherplace/db:/var/opt/mssql -d microsoft/mssql-server-linux
```
The login is sa

### Nuget Console Commands
```sh
Add-Migration InitialModel
Remove-Migration
Update-Database
Install-Package <PackageName>
```

### Angular Cli Commands
```sh
ng g c vehicle-form --module ../app
```