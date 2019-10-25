FROM mcr.microsoft.com/dotnet/core/aspnet:3.0-buster-slim AS base
WORKDIR /app
EXPOSE 80
EXPOSE 4000
EXPOSE 443

FROM mcr.microsoft.com/dotnet/core/sdk:3.0-buster AS build
WORKDIR /src
COPY ["WFLF/WFLF.csproj", "WFLF/"]
RUN dotnet restore "WFLF/WFLF.csproj"
COPY . .
WORKDIR "/src/WFLF"
RUN dotnet build "WFLF.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "WFLF.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "WFLF.dll"]