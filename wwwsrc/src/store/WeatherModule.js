import { weatherApi } from "./AxiosService"

export default {

  actions: {
    // may need to run null check if certain weather conditions are not met
    async getWeather({ commit }) {
      try {
        let res = await weatherApi.get("nowcast?lat=43.615&lon=116.2023&unit_system=si&timestep=5&start_time=now&fields=precipitation%2Cwind_gust%2Ctemp%2Cfeels_like%2Chumidity%2Csunrise%2Csunset%2Cweather_code%2Cepa_aqi&apikey=9Qenj97iFgL3Zk7m3KiaLYGj6ITiV9YT")
        console.log(res.data[0]);
        commit("setActiveWeather", res.data[0])
      } catch (error) {
        console.error(error)
      }
    }
  },
}