<template>
  <div
    class="home container-fluid img-fluid"
    id="img"
    :style="{ backgroundImage: `url(${images.urls.full})` }"
  >
    <div class="row justify-content-end p-2">
      <!-- need to make white background more transparent -->
      <div class="card border-light mb-3" style="max-width: 20rem">
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
    <div class="row justify-content-center">
      <div class="col-6">
        <div class="jumbotron" style="min-width: 45rem">
          <h1 class="display-3 text-center">Hello, Harrison!</h1>
          <h1 class="display-4 text-center">It's {{ currentTime }}</h1>
          <p class="lead text-center">Here are some headlines:</p>
          <hr class="my-4" />
          <p>
            <news
              v-for="news in headlineNews"
              :newsData="news"
              :key="news.id"
            />
          </p>
          <p class="lead">
            <a class="btn btn-primary btn-lg" href="#" role="button"
              >Learn more</a
            >
          </p>
        </div>
      </div>
      <sports
        v-for="ranking in rankings"
        :rankingData="ranking"
        :key="ranking.id"
      />
    </div>
  </div>
</template>


<script>
import Sports from "../components/Sports";
import News from "../components/News";
import moment from "moment";
export default {
  name: "home",
  data() {
    return {
      url: "",
    };
  },
  mounted() {
    // best way to refactor?
    this.$store.dispatch("getRandomImage");
    this.$store.dispatch("getWeather");
    this.$store.dispatch("getQuotes");
    this.$store.dispatch("getRankings");
    this.$store.dispatch("getFootballScores");
    this.$store.dispatch("getNews");
  },
  computed: {
    // best way to refactor?
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
    headlineNews() {
      return this.$store.state.activeNews;
    },
    currentTime() {
      return moment().format("h:mm a, MMMM Do");
    },
  },
  methods: {},
  components: {
    Sports,
    News,
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