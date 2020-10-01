<template>
  <div class="home container-fluid">
    <!-- <Images v-for="image in images" :imageData="image" :key="image.id" /> -->
    <img :src="images.urls.full" alt="" />
  </div>
</template>


<script>
// import Images from "../components/Images";
export default {
  name: "home",
  data() {
    return {};
  },
  mounted() {
    this.$store.dispatch("getQuotes");
    this.$store.dispatch("getWeather");
    this.$store.dispatch("getRandomImage");
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
  },
  methods: {},
  components: {
    // Images,
  },
};
</script>


<style scoped>
</style>