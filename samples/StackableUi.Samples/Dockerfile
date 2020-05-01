#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/core/aspnet:3.1-buster-slim AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/core/sdk:3.1-buster AS build
WORKDIR /src
COPY ["src/StackableUi.Component/StackableUi.Component.csproj", "src/StackableUi.Component/"]
COPY ["samples/StackableUi.Samples/StackableUi.Samples.csproj", "samples/StackableUi.Samples/"]
RUN dotnet restore "samples/StackableUi.Samples/StackableUi.Samples.csproj"
COPY . .
WORKDIR "/samples/StackableUi.Samples"
RUN dotnet build "StackableUi.Samples.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "StackableUi.Samples.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "StackableUi.Samples.dll"]
