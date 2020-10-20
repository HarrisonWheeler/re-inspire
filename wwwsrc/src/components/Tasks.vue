<template>
  <tr id="bg-transparent" class="tasks p-2">
    <td>{{ taskData.name }}</td>
    <td>{{ taskData.description }}</td>
    <td>{{ taskData.isDone }}</td>
    <button class="btn btn-sm btn-danger" @click="deleteTask(taskData.id)">
      Done
    </button>
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
  methods: {
    deleteTask(id) {
      this.$store.dispatch("deleteTask", id);
    },
  },
  components: {},
};
</script>


<style scoped>
#bg-transparent {
  background-color: #0a0a0a60;
}
.cursor {
  cursor: pointer;
}
.isDone {
  text-decoration: line-through;
}
</style>