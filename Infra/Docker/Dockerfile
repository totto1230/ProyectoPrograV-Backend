FROM mcr.microsoft.com/dotnet/sdk:4.8-focal as Build

WORKDIR /source

COPY . .

RUN dotnet restore "./API/ProyectoV-API.csproj" --disable-parallel

RUN dotnet publish "./API/ProyectoV-API.csproj" -c release -o /app --no-restore

FROM mcr.microsoft.com/dotnet/sdk:4.8-focal

WORKDIR /app

COPY --from=build /app ./

EXPOSE 5000

ENTRYPOINT [ "dotnet" , "ProyectoV-API.dll" ]