<template>
  <tr class="tasks" id="bg-transparent">
    <th scope="row">Dark</th>
    <td>{{ taskData.name }}</td>
    <td>{{ taskData.description }}</td>
    <td>{{ taskData.isDone }}</td>
  </tr>
</template>


<script>
export default {
  name: "tasks",
  props: ["taskData"],
  data() {
    return {};
  },
  mounted() {},
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