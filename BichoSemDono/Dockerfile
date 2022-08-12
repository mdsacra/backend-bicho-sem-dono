FROM mcr.microsoft.com/dotnet/aspnet:6.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /src
COPY ["BichoSemDono.csproj", "./"]
RUN dotnet restore "BichoSemDono.csproj"
COPY . .
WORKDIR "/src/"
RUN dotnet build "BichoSemDono.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "BichoSemDono.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
CMD ASPNETCORE_URLS="http://*:$PORT" dotnet BichoSemDono.dll
