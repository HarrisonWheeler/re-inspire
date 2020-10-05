import { newsApi } from "./AxiosService"

export default {

  actions: {
    async getNews({ commit }) {
      try {
        let res = await newsApi.get("")
        console.log(res.data.articles);
        commit("setActiveNews", res.data.articles)
      } catch (error) {
        console.error(error)
      }
    }
  },
}