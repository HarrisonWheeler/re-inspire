import { imageApi } from "./AxiosService"

export default {

  actions: {
    async getRandomImage({ commit }) {
      try {
        let res = await imageApi.get("photos/random?client_id=btTQJe6qtgRP5ixXrADgGzpJ-iCSJCiJrCINfD6RoYw")
        console.log(res.data);
        commit("setRandomImage", res.data)
      } catch (error) {
        console.error(error)
      }
    }
  },
}