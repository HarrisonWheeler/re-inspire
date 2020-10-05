<template>
  <div
    class="home container-fluid img-fluid"
    id="img"
    :style="{ backgroundImage: `url(${images.urls.full})` }"
  >
    <div class="row justify-content-end p-2">
      <div class="card bg-secondary mb-3" style="max-width: 20rem">
        <div class="card-header text-center">
          Boise, ID -
          {{ weather.weather_code.value.toUpperCase() }}
        </div>
        <div class="card-body">
          <p class="card-text">
            Temp: {{ Math.round(weather.temp.value) }}°{{
              weather.temp.units
            }}
            || Humidity: {{ Math.round(weather.humidity.value)
            }}{{ weather.humidity.units }}
          </p>
          <p>
            Feels Like: {{ Math.round(weather.feels_like.value) }}°{{
              weather.feels_like.units
            }}
            || Wind: {{ Math.round(weather.wind_gust.value)
            }}{{ weather.wind_gust.units }}
          </p>
          <p>Sunrise: {{ new Date(weather.sunrise.value).toLocaleString() }}</p>
          <p>Sunset: {{ new Date(weather.sunset.value).toLocaleString() }}</p>
          <p>Air Quality Index: {{ Math.round(weather.epa_aqi.value) }}</p>
        </div>
      </div>
    </div>
    <sports
      v-for="ranking in rankings"
      :rankingData="ranking"
      :key="ranking.id"
    />
  </div>
</template>


<script>
import Sports from "../components/Sports";
export default {
  name: "home",
  data() {
    return {
      url: "",
    };
  },
  mounted() {
    this.$store.dispatch("getRandomImage");
    this.$store.dispatch("getWeather");
    this.$store.dispatch("getQuotes");
    this.$store.dispatch("getRankings");
    this.$store.dispatch("getFootballScores");
    this.$store.dispatch("getNews");
  },
  computed: {
    quotes() {
      return this.$store.state.activeQuotes;
    },
    weather() {
      return this.$store.state.activeWeather;
    },
    images() {
      return this.$store.state.randomImage;
    },
    rankings() {
      return this.$store.state.activeRankings;
    },
    scores() {
      return this.$store.state.activeScores;
    },
    news() {
      return this.$store.state.activeNews;
    },
  },
  methods: {},
  components: {
    Sports,
  },
};
</script>


<style scoped>
#img {
  max-width: 100vw;
  min-height: 100vh;
  position: relative;
  background-size: cover;
  background-repeat: no-repeat;
}
</style>