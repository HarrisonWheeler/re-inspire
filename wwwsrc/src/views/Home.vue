<template>
  <div
    class="home container-fluid img-fluid"
    id="img"
    :style="{ backgroundImage: `url(${images.urls.full})` }"
  >
    <div class="row">
      <div class="col-12"><h1>Hello</h1></div>
      <!-- <img :src="images.urls.full" alt="" class="img-fluid" /> -->
      <Sports />
    </div>
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
    this.$store.dispatch("getUtahFootball");
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
      return this.$store.state.utahFootball;
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
  /* overflow: hidden; */
  background-size: cover;
  background-repeat: no-repeat;
}
</style>