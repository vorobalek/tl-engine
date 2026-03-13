FROM mcr.microsoft.com/dotnet/core/sdk:2.2

WORKDIR /src

COPY . .

RUN dotnet build TL.sln -c Release \
    && rm -rf /app \
    && mkdir -p /app/Extensions \
    && cp -a TL.Engine/bin/netcoreapp2.2/. /app/ \
    && cp -a TL.Engine/Extensions/. /app/Extensions/ \
    && find /app/Extensions -type f \( -name '*.json' -o -name '*.pdb' \) -delete

WORKDIR /app

EXPOSE 5000

ENTRYPOINT ["dotnet", "TL.Engine.dll", "--urls=http://0.0.0.0:5000/"]
