import Vue from 'vue'
import Vuex from 'vuex'
import Axios from "axios";


Vue.use(Vuex)

let baseUrl = location.host.includes("localhost")
  ? "https://localhost:5001/"
  : "/";

let api = Axios.create({
  baseURL: baseUrl + "api/",
  timeout: 10000,
  withCredentials: true
});


export default new Vuex.Store({
  state: {
    activeQuotes: {}
  },
  mutations: {
    setActiveQuotes(state, quotes) {
      state.activeQuotes = quotes
    }
  },
  actions: {
    async getQuotes({ commit }) {
      try {
        let res = await api.get("quotes")
        console.log(res);
        commit("setActiveQuotes", res)
      } catch (error) {
        console.error(error)
      }
    }
  },
  modules: {
  }
})
