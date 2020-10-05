<template>
  <div class="home container-fluid p-0">
    <img :src="images.urls.full" alt="" class="img-fluid" />
    <Sports />
    <div class="row"></div>
  </div>
</template>


<script>
import Sports from "../components/Sports";
export default {
  name: "home",
  data() {
    return {};
  },
  mounted() {
    this.$store.dispatch("getQuotes");
    this.$store.dispatch("getWeather");
    this.$store.dispatch("getRandomImage");
    this.$store.dispatch("getSports");
    this.$store.dispatch("getRankings");
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
    utahFootball() {
      return this.$store.state.activeSports;
    },
  },
  methods: {},
  components: {
    Sports,
  },
};
</script>


<style scoped>
img {
  width: 100%;
  height: 100%;
  position: relative;
  overflow: hidden;
  background-size: cover;
  background-repeat: no-repeat;
}
</style>