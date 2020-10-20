<template>
  <tr id="bg-transparent">
    <td class="p-2">{{ taskData.name }}</td>
    <td class="p-2">{{ taskData.description }}</td>
    <td class="p-2">{{ taskData.isDone }}</td>
    <button class="btn btn-sm btn-danger mt-1" @click="deleteTask(taskData.id)">
      Done
    </button>
  </tr>
</template>


<script>
import swal from "../components/SwalService";
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
      swal.toast("Task Deleted!");
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