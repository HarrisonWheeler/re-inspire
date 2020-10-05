import { sportsApi } from "./AxiosService"

export default {

  actions: {
    async getFootballScores({ commit }) {
      try {
        let res = await sportsApi.get("games?year=2020&seasonType=regular")
        console.log(res.data);
        commit("setActiveScores", res.data)
      } catch (error) {
        console.error(error)
      }
    },
    async getRankings({ commit }) {
      try {
        let res = await sportsApi.get("rankings?year=2020&seasonType=regular")
        console.log(res.data);
        commit("setActiveRankings", res.data)
      } catch (error) {
        console.error(error)
      }
    }
  },
}