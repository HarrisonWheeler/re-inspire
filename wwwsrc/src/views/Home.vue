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
    // this.$store.dispatch("getBcwData");
  },
  computed: {
    quotes() {
      return this.$store.state.activeQuotes;
    },
    // images() {
    //   return this.$store.state.images;
    // },
  },
  methods: {},
  components: {},
};
</script>


<style scoped>
</style>