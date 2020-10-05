import { quotesApi } from "./AxiosService"

export default {

  actions: {
    async getQuotes({ commit }) {
      try {
        let res = await quotesApi.get("quotes")
        console.log(res.data);
        commit("setActiveQuotes", res.data)
      } catch (error) {
        console.error(error)
      }
    },
  },
}