import { tasksApi } from "./AxiosService"

export default {

  actions: {
    async getTasks({ commit }) {
      try {
        let res = await tasksApi.get("tasks")
        console.log(res.data);
        commit("setActiveTasks", res.data)
      } catch (error) {
        console.error(error)
      }
    },
    async createTask({ dispatch }, newTaskData) {
      try {
        let res = await tasksApi.post("tasks", newTaskData)
        console.log(res);
        dispatch("getTasks")
      } catch (error) {
        console.error(error)
      }
    }
  },
}