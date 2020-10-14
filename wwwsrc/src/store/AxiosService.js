import Axios from "axios";

export const baseUrl = location.host.includes("localhost")
  ? "https://localhost:5001/"
  : "/";

export const quotesApi = Axios.create({
  baseURL: baseUrl + "api/",
  timeout: 5000,
  withCredentials: true
});

export const tasksApi = Axios.create({
  baseURL: baseUrl + "api/",
  timeout: 5000,
  withCredentials: true
});


let weatherKey = "https://api.climacell.co/v3/weather"

let imageKey = "https://api.unsplash.com/"

let sportsKey = "https://api.collegefootballdata.com/"

let newsKey = "https://newsapi.org/v2/top-headlines?country=us&apiKey=c81be01485874f8c81e02f457799b44f"

export const weatherApi = Axios.create({
  baseURL: weatherKey,
  timeout: 10000,
})

export const imageApi = Axios.create({
  baseURL: imageKey,
  timeout: 10000,
})

export const sportsApi = Axios.create({
  baseURL: sportsKey,
  timeout: 10000,
})

export const newsApi = Axios.create({
  baseURL: newsKey,
  timeout: 10000,
})
export const setBearer = function (bearer) {
  quotesApi.defaults.headers.authorization = bearer;
};

export const resetBearer = function () {
  quotesApi.defaults.headers.authorization = "";
};
