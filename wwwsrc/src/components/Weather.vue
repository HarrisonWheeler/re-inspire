<template>
  <div
    class="card mb-3"
    id="bg-transparent"
    style="max-width: 20rem"
    v-if="currentWeather.temp"
  >
    <div class="card-header text-center">
      Boise, ID -
      {{ currentWeather.weather_code.value.toUpperCase() }}
    </div>
    <div class="card-body">
      <p class="card-text">
        Temp: {{ Math.round(currentWeather.temp.value) }}°{{
          currentWeather.temp.units
        }}
        || Humidity: {{ Math.round(currentWeather.humidity.value)
        }}{{ currentWeather.humidity.units }}
      </p>
      <p>
        Feels Like: {{ Math.round(currentWeather.feels_like.value) }}°{{
          currentWeather.feels_like.units
        }}
        || Wind: {{ Math.round(currentWeather.wind_gust.value)
        }}{{ currentWeather.wind_gust.units }}
      </p>
      <p>
        Sunrise: {{ new Date(currentWeather.sunrise.value).toLocaleString() }}
      </p>
      <p>
        Sunset: {{ new Date(currentWeather.sunset.value).toLocaleString() }}
      </p>
      <p>Air Quality Index: {{ Math.round(currentWeather.epa_aqi.value) }}</p>
    </div>
    <h1></h1>
  </div>
</template>


<script>
export default {
  name: "weather",
  data() {
    return {};
  },
  mounted() {
    this.$store.dispatch("getWeather");
  },
  computed: {
    currentWeather() {
      return this.$store.state.activeWeather;
    },
  },
  methods: {},
  components: {},
};
</script>


<style scoped>
</style>