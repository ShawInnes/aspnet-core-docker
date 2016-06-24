FROM microsoft/dotnet:latest

EXPOSE 5000

COPY src /opt/src

WORKDIR /opt/src

RUN ["dotnet", "restore"]

ENTRYPOINT ["dotnet", "run"]
