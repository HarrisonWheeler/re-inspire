import Vue from 'vue'
import Vuex from 'vuex'
import { api } from "./AxiosService"

Vue.use(Vuex)

export default new Vuex.Store({
  state: {
    activeQuotes: [],
    // images: [],
  },
  mutations: {
    setActiveQuotes(state, quotes) {
      state.activeQuotes = quotes
    },
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
    // async getWeather({ commit }) {
    //   try {
    //     let res = await weatherApi.get()
    //   } catch (error) {
    //     console.error(error)
    //   }
    // }
  },
  modules: {
  }
})
