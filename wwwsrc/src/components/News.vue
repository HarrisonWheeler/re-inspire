<template>
  <div class="list-group">
    <a
      v-bind:href="newsData.url"
      class="text-light flex-column align-items-start active bg-transparent p-1"
    >
      <div class="d-flex w-100 justify-content-between">
        <h5 class="mb-1">{{ newsData.title }}</h5>
        <small>{{ new Date(newsData.publishedAt).toLocaleString() }}</small>
      </div>
      <p class="mb-1">
        {{ newsData.description }}
      </p>
      <small>By: {{ newsData.author }}</small>
    </a>
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
#bg-transparent {
  background-color: #c2bfbf46;
}
</style>