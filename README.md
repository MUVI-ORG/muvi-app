# Muvi App

Mobile application that allows users to consult the most popular movies and new releases based on IMDB Api. Users can also consult the technical sheets of the selection of films, as well as to view a ranking of films according to their classification.

## Features:
- List top 100 most popular movies based on IMDB.
- List top 100 coming soon movies based on IMDB.
- Search and view movie details.

## App Demo
<img src="/Gifs/MuviAppDemo.gif" width="200" height="500"/>

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

## Technologies & Libraries:
- Xamarin Forms
- Prism
- Refit
- Fody
- PropertyChanged.Fody
- GlideX
- ImageCircle.Forms

### Prototype Mockup on Figma (Recommended open it with Firefox or Safari)
https://www.figma.com/file/Dua28cgYD70c3YIuDETEfk/figma-file?node-id=0%3A1

### Team Work Distribution on Trello
https://trello.com/b/s1cuKhhK/muvi

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

## Developers
- Ana Paredes (1086701)
- Adriel Rosario (1087472)
- Alexis Novas (1086316)
