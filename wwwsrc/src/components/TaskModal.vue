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
        <div class="modal-body">
          <div class="form-group">
            <input
              type="text"
              class="form-control"
              placeholder="Enter Task name..."
              id="inputDefault"
            />
          </div>
        </div>
        <div class="modal-footer">
          <button type="button" class="btn btn-primary">Create Task</button>
          <button type="button" class="btn btn-secondary" data-dismiss="modal">
            Close
          </button>
        </div>
      </div>
    </div>
  </div>
</template>


<script>
export default {
  name: "taskModal",
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