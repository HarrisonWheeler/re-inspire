<template>
  <div class="taskModal">
    <div class="modal-dialog modal" id="taskModal" role="document">
      <div class="modal-content">
        <div class="modal-header">
          <h5 class="modal-title">Creat a Task!</h5>
          <button
            type="button"
            class="close"
            data-dismiss="modal"
            aria-label="Close"
          >
            <span aria-hidden="true">&times;</span>
          </button>
        </div>
        <form @submit.prevent="createTask()">
          <div class="modal-body">
            <label class="col-form-label" for="inputDefault">Task Name</label>
            <div class="form-group">
              <input
                v-model="newTask.name"
                type="text"
                class="form-control"
                placeholder="Enter Task name..."
                id="inputDefault"
              />
            </div>
            <label class="col-form-label" for="inputDefault"
              >Task Description</label
            >
            <div class="form-group">
              <input
                v-model="newTask.description"
                type="text"
                class="form-control"
                placeholder="Enter Task description..."
                id="inputDefault"
              />
            </div>
          </div>
        </form>
        <div class="modal-footer">
          <button type="button" class="btn btn-primary" @click="createTask()">
            Create Task
          </button>
          <button type="button" class="btn btn-secondary" data-dismiss="modal">
            Close
          </button>
        </div>
      </div>
    </div>
  </div>
</template>


<script>
import swal from "../components/SwalService";
export default {
  name: "taskModal",
  data() {
    return {
      newTask: {},
    };
  },
  computed: {},
  methods: {
    createTask() {
      this.$store.dispatch("createTask", {
        name: this.newTask.name,
        description: this.newTask.description,
      });
      this.newTask = {};
      swal.toast("Task Created!");
    },
  },
  components: {},
};
</script>


<style scoped>
</style>