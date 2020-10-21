#Depending on the operating system of the host machines(s) that will build or run the containers, the image specified in the FROM statement may need to be changed.
#For more information, please see https://aka.ms/containercompat

FROM mcr.microsoft.com/dotnet/core/sdk:3.1 AS build-env
WORKDIR /usr/src/app
COPY *.sln .
COPY LocalizationTools/*.csproj ./LocalizationTools/ 
COPY LocalizationTools.Data/*.csproj ./LocalizationTools.Data/
COPY LocalizationTools.Model/*.csproj ./LocalizationTools.Model/
COPY LocalizationTools.Service/*.csproj ./LocalizationTools.Service/
COPY LocalizationTools.Data.RDB/*.csproj ./LocalizationTools.Data.RDB/
COPY LocalizationTools.Data.Logging/*.csproj ./LocalizationTools.Data.Logging/
COPY LocalizationToolsTest/*.csproj ./LocalizationToolsTest/

#COPY ["./LocalizationTools","/usr/src/app/LocalizationTools/"]
#COPY ["./LocalizationTools.Data", "/usr/src/app/LocalizationTools.Data/"]
#COPY ["./LocalizationTools.Data.Logging", "/usr/src/app/LocalizationTools.Data.Logging/"]
#COPY ["./LocalizationTools.Data.RDB", "/usr/src/app/LocalizationTools.Data.RDB/"]
#COPY ["./LocalizationTools.Model", "/usr/src/app/LocalizationTools.Model/"]
#COPY ["./LocalizationTools.Service", "/usr/src/app/LocalizationTools.Service/"]

COPY LocalizationTools/. ./LocalizationTools/
WORKDIR /usr/src/app/LocalizationTools
#RUN dotnet publish -c release -o /app --no-restore
#RUN dotnet publish -c Release -o out


#RUN dotnet build "/usr/src/app/LocalizationTools/LocalizationTools.csproj" -c Release -o /app
#RUN dotnet publish "/usr/src/app/LocalizationTools.csproj" -c Release -o /publish

# Build runtime image
FROM mcr.microsoft.com/dotnet/core/aspnet:3.1
WORKDIR /usr/src/app
EXPOSE 61905
EXPOSE 44307
ENTRYPOINT ["dotnet", "LocalizationTools.dll"]