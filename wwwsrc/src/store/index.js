import Vue from 'vue'
import Vuex from 'vuex'
import { api } from "./AxiosService"
import weatherModule from "./WeatherModule"
import imageModule from "./ImageModule"
import SportsModule from "./SportsModule"

Vue.use(Vuex)

export default new Vuex.Store({
  state: {
    activeQuotes: [],
    activeWeather: {},
    randomImage: {},
    activeRankings: [],
    activeScores: {},
  },
  mutations: {
    setActiveQuotes(state, quotes) {
      state.activeQuotes = quotes
    },
    setActiveWeather(state, weather) {
      state.activeWeather = weather
    },
    setRandomImage(state, randomImage) {
      state.randomImage = randomImage
    },
    setActiveRankings(state, activeRankings) {
      state.activeRankings = activeRankings
    },
    setActiveScores(state, activeScores) {
      state.activeScores = activeScores
    }
  },
  actions: {
    async getQuotes({ commit }) {
      try {
        let res = await api.get("quotes")
        console.log(res.data);
        commit("setActiveQuotes", res.data)
      } catch (error) {
        console.error(error)
      }
    },
  },
  modules: {
    weatherModule,
    imageModule,
    SportsModule,
  }
})
