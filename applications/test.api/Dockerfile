#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:5.0-buster-slim AS base
WORKDIR /app
EXPOSE 80

FROM mcr.microsoft.com/dotnet/sdk:5.0-buster-slim AS build
WORKDIR /src
COPY ["test.api.csproj", "test.api/"]
RUN dotnet restore "test.api/test.api.csproj"
COPY . ./test.api
WORKDIR "/src/test.api"
RUN dotnet build "test.api.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "test.api.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "test.api.dll"]