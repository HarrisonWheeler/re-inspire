<template>
  <tr id="bg-transparent" v-if="taskData.isDone == false" class="isDone">
    <td>{{ taskData.name }}</td>
    <td>{{ taskData.description }}</td>
    <td>
      <div class="custom-control custom-switch pt-1">
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
.isDone {
  text-decoration: line-through;
}
</style>