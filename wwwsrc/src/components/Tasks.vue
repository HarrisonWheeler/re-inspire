<template>
  <tr class="tasks table-light text-dark">
    <th scope="row" id="bg-transparent"></th>
    <td>
      <h6>
        {{ taskData.name }}
      </h6>
    </td>
    <td>
      <h6>
        {{ taskData.description }}
      </h6>
    </td>
    <td>
      <h6>
        {{ taskData.isDone }}
      </h6>
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