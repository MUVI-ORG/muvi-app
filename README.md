# Muvi App

Mobile application that allows users to consult the most popular movies and new releases based on IMDB Api. Users can also consult the technical sheets of the selection of films, as well as to view a ranking of films according to their classification.

## Features:
- List top 100 most popular movies based on IMDB.
- List top 100 coming soon movies based on IMDB.
- Search and view movie details.
- View actors details.

## About the IMDB Api:

The IMDb-API is a web service for receiving movie, serial and cast information. APIs results is a JSON and includes items such as movie specifications, images, posters, trailers, ratings, Wikipedia page content and more.

You can find it on: https://imdb-api.com/

Endpoints used in project:

``GET MostPopularMovies
https://imdb-api.com/en/API/MostPopularMovies/PASTE_API_KEY ``

``GET ComingSoon
https://imdb-api.com/en/API/ComingSoon/PASTE_API_KEY ``

``GET Title
https://imdb-api.com/en/API/Title/PASTE_API_KEY/{movieId} ``

``GET Trailer
https://imdb-api.com/en/API/Trailer/PASTE_API_KEY/{movieId} ``

## Technologies:
- Xamarin Forms
- Prism
- Refit
- Fody

### App Navigation Flows
 
- Flow 1: Most Popular Movies Page > Movie Detail Page > Actor Detail Page
- Flow 2: Coming Soon Movies Page > Movie Detail Page > Actor Detail Page

### Screenshots of the app

#### Most Popular Movies Page
![MostPopularMoviesPage](https://user-images.githubusercontent.com/47201459/135704165-4735445a-50b1-4e93-913d-65d33310ad49.PNG)

#### Coming Soon Movies Page
![ComingSoonMoviesPage](https://user-images.githubusercontent.com/47201459/135704186-e5a3234e-61aa-4a02-b5a6-95e691fc656e.PNG)

#### Movie Detail Page
![MovieDetailPage](https://user-images.githubusercontent.com/47201459/135704197-9add480d-d1b8-4ee6-9c5d-6648680dd3fb.PNG)

#### Actor Detail Page
![ActorDetailPage](https://user-images.githubusercontent.com/47201459/135704212-0844fdf7-bfe8-45d6-a937-423e179294c5.PNG)


## How to get the API Key

Register on https://imdb-api.com/ and follow the steps below.

#### Step 1 - Go to user settings
![GetApiKey1](/Screenshots/GetApiKeyStep1.PNG)

#### Step 2 - Click on 'Profile'
![GetApiKey2](/Screenshots/GetApiKeyStep2.png)


#### Step 3 - Copy your API key
![GetApiKey3](/Screenshots/GetApiKeyStep3a.png)

#### Step 4 - Paste it on the code

![GetApiKey4](/Screenshots/GetApiKeyStep4a.png)
