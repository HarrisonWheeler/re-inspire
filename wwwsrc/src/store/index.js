import Vue from 'vue'
import Vuex from 'vuex'
import { api } from "./AxiosService"
import weatherModule from "./WeatherModule"

Vue.use(Vuex)

export default new Vuex.Store({
  state: {
    activeQuotes: [],
    activeWeather: {}
  },
  mutations: {
    setActiveQuotes(state, quotes) {
      state.activeQuotes = quotes
    },
    setActiveWeather(state, weather) {
      state.activeWeather = weather
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
  }
})
