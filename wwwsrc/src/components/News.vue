<template>
  <div class="news text-dark">
    <h6>
      {{ newsData.title }}
    </h6>
  </div>
</template>


<script>
export default {
  name: "news",
  props: ["newsData"],
  data() {
    return {};
  },
  computed: {},
  methods: {},
  components: {},
};
</script>


<style scoped>
</style>