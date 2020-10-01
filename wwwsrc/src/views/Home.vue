<template>
  <div class="home"></div>
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
  },
  methods: {},
  components: {},
};
</script>


<style scoped>
</style>