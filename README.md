# Dynamic Summary

Proof of concept of DotNet Core 7 API returning dynamic data structures

### Run application

```sh
docker run --rm -itd --name dynamic-summary -p 5000:80 $(docker build -q .)
```

Open in your browser [http://localhost:5000/summary](http://localhost:5000/summary)

### Stop application

```sh
docker container stop dynamic-summary
```

