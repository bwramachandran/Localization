#Depending on the operating system of the host machines(s) that will build or run the containers, the image specified in the FROM statement may need to be changed.
#For more information, please see https://aka.ms/containercompat

FROM mcr.microsoft.com/dotnet/core/sdk:3.1 AS build-env
WORKDIR /source
COPY *.sln .
COPY LocalizationTools/*.csproj ./LocalizationTools/ 
COPY LocalizationTools.Data/*.csproj ./LocalizationTools.Data/
COPY LocalizationTools.Model/*.csproj ./LocalizationTools.Model/
COPY LocalizationTools.Service/*.csproj ./LocalizationTools.Service/
COPY LocalizationTools.Data.RDB/*.csproj ./LocalizationTools.Data.RDB/
COPY LocalizationTools.Data.Logging/*.csproj ./LocalizationTools.Data.Logging/
COPY LocalizationToolsTest/*.csproj ./LocalizationToolsTest/
RUN dotnet restore

COPY . ./LocalizationTools/
WORKDIR /source/LocalizationTools

RUN dotnet publish -c release -o /app

### Build runtime image
FROM mcr.microsoft.com/dotnet/core/aspnet:3.1
WORKDIR /app
COPY --from=build-env /app ./
EXPOSE 5000
EXPOSE 1433
ENTRYPOINT ["dotnet", "LocalizationTools.dll"]