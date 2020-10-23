FROM mcr.microsoft.com/dotnet/core/aspnet:3.1 AS base
WORKDIR /app
EXPOSE 80

FROM mcr.microsoft.com/dotnet/core/sdk:3.1 AS build
WORKDIR /src
COPY ["Kubernetes3/Kubernetes3.csproj", "Kubernetes3/"]

RUN dotnet restore "Kubernetes3/Kubernetes3.csproj"
COPY . .
WORKDIR "/src/Kubernetes3"
RUN dotnet build "Kubernetes3.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "Kubernetes3.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "Kubernetes3.dll"]