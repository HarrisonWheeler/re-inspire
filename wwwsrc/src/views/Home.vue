<template>
  <div
    class="home container-fluid img-fluid"
    id="img"
    :style="{ backgroundImage: `url(${images.urls.full})` }"
  >
    <div class="row justify-content-end p-2">
      <div class="card bg-light mb-3" style="max-width: 18rem">
        <div class="card-header text-center">Boise, ID</div>
        <div class="card-body">
          <p class="card-text">
            {{ weather.temp.value }} {{ weather.temp.units }}
          </p>
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
    this.$store.dispatch("getQuotes");
    this.$store.dispatch("getWeather");
    this.$store.dispatch("getRandomImage");
    this.$store.dispatch("getRankings");
    this.$store.dispatch("getFootballScores");
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