FROM mcr.microsoft.com/dotnet/runtime:7.0 AS base
WORKDIR /app

FROM mcr.microsoft.com/dotnet/sdk:7.0 AS build
WORKDIR /src
COPY ["OCP/Before/OpenClosed.ConsoleSample/OpenClosed.ConsoleSample.csproj", "OCP/Before/OpenClosed.ConsoleSample/"]
RUN dotnet restore "OCP/Before/OpenClosed.ConsoleSample/OpenClosed.ConsoleSample.csproj"
COPY . .
WORKDIR "/src/OCP/Before/OpenClosed.ConsoleSample"
RUN dotnet build "OpenClosed.ConsoleSample.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "OpenClosed.ConsoleSample.csproj" -c Release -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "OpenClosed.ConsoleSample.dll"]
