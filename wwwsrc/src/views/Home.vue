<template>
  <div class="home container-fluid p-0">
    <div class="row">
      <img :src="images.urls.full" alt="" class="img-fluid" />
    </div>
  </div>
</template>


<script>
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
  components: {},
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