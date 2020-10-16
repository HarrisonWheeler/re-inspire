<template>
  <tr id="bg-transparent" v-if="taskData.isDone == true" class="isDone">
    <td>{{ taskData.name }}</td>
    <td>{{ taskData.description }}</td>
    <td>
      <div class="custom-control custom-switch pt-1">
        <input
          v-model="taskData.isDone"
          type="checkbox"
          class="custom-control-input"
          id="customSwitch1"
          checked=""
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