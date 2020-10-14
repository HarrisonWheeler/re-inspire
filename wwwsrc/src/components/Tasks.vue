<template>
  <div class="tasks">
    {{ taskData.description }}
  </div>
</template>


<script>
export default {
  name: "tasks",
  props: ["taskData"],
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