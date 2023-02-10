FROM mcr.microsoft.com/dotnet/aspnet:6.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /src
COPY ["/Villa/Villa.csproj", "Villa/"]
COPY ["/Villa.Infrastructure/Villa.Infrastructure.csproj", "Villa.Infrastructure/"]
COPY ["/Villa.Service/Villa.Service.csproj", "Villa.Service/"]
COPY ["/Villa.Persistence/Villa.Persistence.csproj", "Villa.Persistence/"]
COPY ["/Villa.Domain/Villa.Domain.csproj", "Villa.Domain/"]
RUN dotnet restore "./Villa.csproj"
COPY . .
WORKDIR "/src/Villa"
RUN dotnet build "Villa.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "Villa.csproj" -c Release -o /app/publish

FROM base AS final

RUN apt-get update && \
    apt-get install -yq tzdata

ENV TZ="Europe/Istanbul"

WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "Villa.dll"]
