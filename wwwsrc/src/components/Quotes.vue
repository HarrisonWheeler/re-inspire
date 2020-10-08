<template>
  <div class="col-12 quotes text-light text-center">
    <h6>"{{ quoteData.description }}"</h6>
    <small>-{{ quoteData.name }}</small>
  </div>
</template>


<script>
export default {
  name: "quotes",
  props: ["quoteData"],
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