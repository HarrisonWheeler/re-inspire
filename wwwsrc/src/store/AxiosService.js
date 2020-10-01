import Axios from "axios";

export const baseUrl = location.host.includes("localhost")
  ? "https://localhost:5001/"
  : "/";

export const api = Axios.create({
  baseURL: baseUrl + "api/",
  timeout: 5000,
  withCredentials: true
});

// if error, may need to add / after v3
let weatherKey = "https://api.climacell.co/v3/weather"

export const weatherApi = Axios.create({
  baseURL: weatherKey,
  timeout: 10000,
})


export const setBearer = function (bearer) {
  api.defaults.headers.authorization = bearer;
};

export const resetBearer = function () {
  api.defaults.headers.authorization = "";
};
