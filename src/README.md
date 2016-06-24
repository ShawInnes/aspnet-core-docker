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

# Run

```
docker run -p 5000:5000 {containerid}
```