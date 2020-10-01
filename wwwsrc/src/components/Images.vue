<template>
  <div class="images container-fluid">
    {{ imageData.urls.full }}
  </div>
</template>


<script>
export default {
  name: "images",
  props: ["imageData"],
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