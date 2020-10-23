<template>
  <div class="col-12 quotes text-light text-center pb-2">
    <div class="card border-light mb-3 bg-transparent" style="max-width: 80rem">
      <div class="card-body">
        <h4 class="card-title">{{ quoteData.description }}</h4>
        <p class="card-text">-{{ quoteData.name }}</p>
      </div>
    </div>
  </div>
</template>


<script>
export default {
  name: "quotes",
  props: ["quoteData"],
  data() {
    return {
      showedCount: 1,
      moreCount: 1,
    };
  },
  computed: {},
  methods: {},
  components: {},
};
</script>


<style scoped>
#bg-transparent {
  background-color: #0a0a0a60;
}
</style>