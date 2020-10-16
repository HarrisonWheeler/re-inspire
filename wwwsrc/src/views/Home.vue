<template>
  <div
    class="home container-fluid img-fluid"
    id="img"
    v-if="images.urls"
    :style="{ backgroundImage: `url(${images.urls.full})` }"
  >
    <div class="row justify-content-between text-light p-2">
      <div class="col-8">
        <table class="table table-dark rounded" id="bg-transparent">
          <thead>
            <tr>
              <th scope="col">Task</th>
              <th scope="col">Description</th>
              <th scope="col">Done</th>
            </tr>
          </thead>
          <tbody>
            <Tasks v-for="task in tasks" :taskData="task" :key="task.id" />
          </tbody>
        </table>
      </div>
      <Weather />
    </div>
    <div class="row justify-content-center">
      <div class="col-6">
        <div
          class="jumbotron text-light"
          id="bg-transparent"
          style="min-width: 50rem"
        >
          <h1 class="display-3 text-center">Hello, Harrison!</h1>
          <h1 class="display-4 text-center">It's {{ currentTime }}</h1>
          <p class="lead text-center">Here are some headlines:</p>
          <hr class="my-4" />
          <p v-if="showMoreStories">
            <News
              v-for="news in headlineNews.slice(0, 3)"
              :newsData="news"
              :key="news.id"
            />
          </p>
          <p class="lead text-center">
            <!-- TODO need to change the way this is implemented - need to fetch more stories from the local state on button click, not just hide them -->
            <button
              class="btn btn-info btn-lg"
              v-if="!isLoadingStories"
              @click="showMoreStories = !showMoreStories"
            >
              See More....
            </button>
          </p>
        </div>
      </div>
      <Sports
        v-for="ranking in rankings"
        :rankingData="ranking"
        :key="ranking.id"
      />
    </div>
    <div class="row">
      <Quotes
        v-for="quote in quotes.slice(0, 1)"
        :quoteData="quote"
        :key="quote.id"
      />
    </div>
  </div>
</template>


<script>
import Sports from "../components/Sports";
import News from "../components/News";
import moment from "moment";
import Quotes from "../components/Quotes";
import Weather from "../components/Weather";
import Tasks from "../components/Tasks";
import TaskModal from "../components/TaskModal";
export default {
  name: "home",
  data() {
    return {
      isLoadingStories: false,
      showMoreStories: true,
    };
  },
  mounted() {
    // best way to refactor?
    this.$store.dispatch("getRandomImage");
    this.$store.dispatch("getQuotes");
    this.$store.dispatch("getRankings");
    this.$store.dispatch("getFootballScores");
    this.$store.dispatch("getNews");
    this.$store.dispatch("getTasks");
  },
  computed: {
    // best way to refactor?
    quotes() {
      return this.$store.state.activeQuotes;
    },
    images() {
      return this.$store.state.randomImage;
    },
    rankings() {
      return this.$store.state.activeRankings;
    },
    scores() {
      return this.$store.state.activeScores;
    },
    tasks() {
      return this.$store.state.activeTasks;
    },
    headlineNews() {
      return this.$store.state.activeNews;
    },
    currentTime() {
      return moment().format("h:mm a, MMMM Do");
    },
  },
  methods: {},
  components: {
    Sports,
    News,
    Quotes,
    Weather,
    Tasks,
    TaskModal,
  },
};
</script>


<style scoped>
#img {
  max-width: 100vw;
  min-height: 100vh;
  position: relative;
  background-size: cover;
  background-repeat: no-repeat;
}
#bg-transparent {
  background-color: #0a0a0a60;
}
</style>