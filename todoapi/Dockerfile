FROM microsoft/dotnet:2.1-aspnetcore-runtime AS base
WORKDIR /app
EXPOSE 80

FROM microsoft/dotnet:2.1-sdk AS build
WORKDIR /src
COPY ["todoapi.csproj", ""]
RUN dotnet restore "todoapi.csproj"  
COPY . .
WORKDIR "/src/"
RUN dotnet build "todoapi.csproj" -c Release -o /app

FROM build AS publish
RUN dotnet publish "todoapi.csproj" -c Release -o /app

FROM base AS final
WORKDIR /app
COPY --from=publish /app .
ENV ASPNETCORE_URLS http://*:80
ENTRYPOINT ["dotnet", "todoapi.dll"]