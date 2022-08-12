# Uroskur
A ASP.NET app that fetches a weather forecast for the next 48 hours from OpenWeather and routes from Strava to display the weather conditions along your routes based upon your pace, time of day and start date.

## Screen Shots
<img src="https://i.ibb.co/dgMVRbK/main.png" alt="main" border="0">
<img src="https://i.ibb.co/HNcJdc7/weather.png" alt="weather-2" border="0">
<img src="https://i.ibb.co/NTRnmLC/weather-1.png" alt="weather-1" border="0">
<img src="https://i.ibb.co/4m55pGn/settings.png" alt="settings" border="0">

## How to use
You will need a Strava account, a OpenWeather account and a Google account. Google is used for authentication, Strava for routes and OpenWeather for weather forecasts.

### Strava
The process for creating a Strava API application is described on the Strava website. Follow the instructions on [Getting Started]( https://developers.strava.com/docs/getting-started/). To configure Uroskur you need the **Client ID** and **Client Secret**. You will find these on the My API Application page under Settings.

### OpenWeather
Sign up for an account on https://openweathermap.org/. To configure Uroskur you need the OpenWeather **API key**.

### Google
Follow the instructions on [Setting up OAuth 2.0](https://support.google.com/cloud/answer/6158849?hl=en "A"). To configure Uroskur you need the **Client ID** and **Client secret**. For example, if you deploy Uroskur at domain changeit.changeit set Authorized JavaScript origins to https://changeit.changeit and Authorized redirect URIs to https://changeit.changeit/signin-google.

### Configure Uroskur
Configuration of Uroskur depends on how you deploy it.

#### IIS
Edit the appsettings.production.json file.

    {
        "ConnectionStrings": {
            "DefaultConnection": "Data Source=C:/uroskur/uroskur.db"
        },
        "AppSettings": {
            "StravaAuthorizationTokenUrl": "https://www.strava.com/oauth/token",
            "StravaSubscriptionUrl": "https://www.strava.com/api/v3/push_subscriptions",
            "StravaCallbackUrl": "https://changeit.changeit/api/v1/Strava/SubscriptionCallback/cf547d74-db54-44d8-ad1a-83caa67c89ef",
            "StravaRoutesUrl": "https://www.strava.com/api/v3/athletes/@AthleteId/routes",
            "StravaGxpUrl": "https://www.strava.com/api/v3/routes/@RouteId/export_gpx",
            "ForecastUrl": "https://api.openweathermap.org/data/2.5/onecall?lat=@Lat&lon=@Lon&exclude=@Exclude&units=metric&appid=@AppId&lang=en"
        },
        "Authentication": {
            "Google": {
                "ClientId": "",
                "ClientSecret": ""
            }
        },
        "Cache": {
            "CachePath": "C:/uroskur/cache.db"
        },
        "Logging": {
            "LogLevel": {
                "Default": "Information",
                "Microsoft": "Warning",
                "Microsoft.Hosting.Lifetime": "Information"
            }
        },
        "AllowedHosts": "*"
    }

### Docker
Edit the docker-compose file (in the example below Uroskur is proxied by Traefik):

    version: "2.4"
    
    services:
      uroskur:
        container_name: uroskur
        image: ahaggqvist/uroskur:latest
        mem_limit: 512m
        memswap_limit: 1024m
        restart: unless-stopped
        networks:
          - traefik_network
        environment:
          - ASPNETCORE_URLS=http://+:80
          - ASPNETCORE_CUSTOM_HTTPS_REDIRECT=false
          - ConnectionStrings__DefaultConnection=Data Source=/data/uroskur.db
          - Cache__CachePath=/data/cache.db
          - AppSettings__StravaCallbackUrl=https://changeit.changeit/api/v1/Strava/SubscriptionCallback/cf547d74-db54-44d8-ad1a-83caa67c89ef
          - Authentication__Google__ClientId=
          - Authentication__Google__ClientSecret=
        volumes:
          - "./uroskur.db:/data/uroskur.db"
        labels:
          - "traefik.enable=true"
          - "traefik.http.services.uroskur.loadbalancer.server.port=80"
          - "traefik.http.routers.uroskur.rule=Host(`changeit.changeit`)"
          - "traefik.http.routers.uroskur.entrypoints=web"
          - "traefik.http.routers.uroskur-secure.rule=Host(`changeit.changeit`)"
          - "traefik.http.routers.uroskur-secure.entrypoints=web-secure"
          - "traefik.http.routers.uroskur-secure.tls=true"
          - "traefik.http.routers.uroskur-secure.tls.certresolver=letsencrypt"
          - "traefik.http.middlewares.uroskur-http-redirect.redirectscheme.scheme=https"
          - "traefik.http.routers.uroskur.middlewares=uroskur-http-redirect"
    networks:
      traefik_network:
        external: true

You only need to configure the **Google Client ID** and **Client Secret** in the configuration files. The **Strava Client ID** and **Client Secrets** as well as the **OpenWeather API key** are configured under Settings in Uroskur.

## Docker image
A docker image is available at [Docker Hub](https://hub.docker.com/r/ahaggqvist/uroskur "Docker Hub"):

    docker pull ahaggqvist/uroskur:latest

## Database
If you are not running the migrations from scratch to create the database you can download an empty database **uroskur.db**.
