<template>
  <div class="home container-fluid">
    <img :src="images.urls.full" alt="" class="img-fluid" />
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
</style>