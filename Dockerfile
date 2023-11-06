FROM mcr.microsoft.com/dotnet/aspnet:6.0 AS base
WORKDIR /app
EXPOSE 80

FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /src
COPY ["voicevista-back.csproj", "."]
RUN dotnet restore "./voicevista-back.csproj"
COPY . .
WORKDIR "/src/."
RUN dotnet build "voicevista-back.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "voicevista-back.csproj" -c Release -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "voicevista-back.dll"]