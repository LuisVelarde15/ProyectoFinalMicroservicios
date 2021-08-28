#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:5.0 AS base
WORKDIR /app
EXPOSE 80

FROM mcr.microsoft.com/dotnet/sdk:5.0 AS build
WORKDIR /src
COPY ["WebApiPelicula/WebApiPelicula.csproj", "WebApiPelicula/"]
RUN dotnet restore "WebApiPelicula/WebApiPelicula.csproj"
COPY . .
WORKDIR "/src/WebApiPelicula"
RUN dotnet build "WebApiPelicula.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "WebApiPelicula.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "WebApiPelicula.dll"]