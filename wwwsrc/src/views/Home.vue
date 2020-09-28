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
  },
  computed: {
    quotes() {
      return this.$store.state.activeQuotes;
    },
  },
  methods: {},
  components: {},
};
</script>


<style scoped>
</style>