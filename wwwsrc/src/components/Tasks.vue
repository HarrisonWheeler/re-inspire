<template>
  <tr id="bg-transparent" v-if="taskData.isDone == false" class="isDone">
    <td>{{ taskData.name }}</td>
    <td>
      <div class="custom-control custom-switch cursor pt-1">
        <!-- TODO toggle only works for the first task, and doesn't after that -->
        <input
          v-model="taskData.isDone"
          type="checkbox"
          class="custom-control-input"
          id="customSwitch1"
          :checked="taskData.isDone"
        />
        <label class="custom-control-label" for="customSwitch1"></label>
      </div>
    </td>
    <i
      class="fas fa-trash text-danger cursor"
      @click="deleteTask(taskData.id)"
    ></i>
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