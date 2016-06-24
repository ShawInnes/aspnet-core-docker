# ASPNET Core with Docker

Setup (on OS X with VMWare Fusion):
```bash
brew install docker
brew install docker-machine
brew install boot2docker

docker-machine create --driver=vmwarefusion default
eval $(docker-machine env default)
```

# Build

```
docker build .
```
output:

    aspnet (master) $ docker build .
    Sending build context to Docker daemon 1.812 MB
    Step 1 : FROM microsoft/dotnet:latest
    ---> 8318ba6b5e74
    Step 2 : EXPOSE 5000
    ---> Using cache
    ---> 68d1f18b8a69
    Step 3 : COPY src /opt/src
    ---> Using cache
    ---> 0b4dfdc0b0e4
    Step 4 : WORKDIR /opt/src
    ---> Using cache
    ---> 0d6963b4ecb4
    Step 5 : RUN dotnet restore
    ---> Using cache
    ---> 29e49f45c90b
    Step 6 : ENTRYPOINT dotnet run
    ---> Using cache
    ---> d2fc41f63552
    Successfully built d2fc41f63552

# Run

```
docker run -p 5000:5000 d2fc41f63552
```