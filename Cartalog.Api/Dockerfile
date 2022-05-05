#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:6.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /src
COPY ["Cartalog.Api/Cartalog.Api.csproj", "Cartalog.Api/"]
RUN dotnet restore "Cartalog.Api/Cartalog.Api.csproj"
COPY . .
WORKDIR "/src/Cartalog.Api"
RUN dotnet build "Cartalog.Api.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "Cartalog.Api.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "Cartalog.Api.dll"]