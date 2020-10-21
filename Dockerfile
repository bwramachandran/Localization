#Depending on the operating system of the host machines(s) that will build or run the containers, the image specified in the FROM statement may need to be changed.
#For more information, please see https://aka.ms/containercompat

FROM mcr.microsoft.com/dotnet/core/sdk:3.1 AS build-env
WORKDIR /source
COPY *.sln .
COPY LocalizationTools/*.csproj ./localizationTools/ 
COPY LocalizationTools.Data/*.csproj ./localizationTools.Data/
COPY LocalizationTools.Model/*.csproj ./localizationTools.Model/
COPY LocalizationTools.Service/*.csproj ./localizationTools.Service/
COPY LocalizationTools.Data.RDB/*.csproj ./localizationTools.Data.RDB/
COPY LocalizationTools.Data.Logging/*.csproj ./localizationTools.Data.Logging/
COPY LocalizationToolsTest/*.csproj ./localizationToolsTest/
RUN dotnet restore

COPY . ./localizationTools/
WORKDIR /source/localizationTools

RUN dotnet publish -c release -o /app

### Build runtime image
FROM mcr.microsoft.com/dotnet/core/aspnet:3.1
WORKDIR /app
COPY --from=build-env /app ./
EXPOSE 5000
EXPOSE 1433
ENTRYPOINT ["dotnet", "localizationTools.dll"]