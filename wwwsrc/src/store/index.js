import Vue from 'vue'
import Vuex from 'vuex'
import weatherModule from "./WeatherModule"
import imageModule from "./ImageModule"
import SportsModule from "./SportsModule"
import NewsModule from "./NewsModule"
import QuotesModule from "./QuotesModule"
import TasksModule from "./TaskModule"

Vue.use(Vuex)

export default new Vuex.Store({
  state: {
    activeQuotes: [],
    activeTasks: [],
    activeWeather: {},
    randomImage: {},
    activeRankings: [],
    activeScores: {},
    activeNews: [],
  },
  mutations: {
    setActiveQuotes(state, quotes) {
      state.activeQuotes = quotes
    },
    setActiveTasks(state, tasks) {
      state.activeTasks = tasks
    },
    setActiveWeather(state, weather) {
      state.activeWeather = weather
    },
    setRandomImage(state, randomImage) {
      state.randomImage = randomImage
    },
    setActiveRankings(state, activeRankings) {
      state.activeRankings = activeRankings
    },
    setActiveScores(state, activeScores) {
      state.activeScores = activeScores
    },
    setActiveNews(state, activeNews) {
      state.activeNews = activeNews
    }
  },
  actions: {},
  modules: {
    weatherModule,
    imageModule,
    SportsModule,
    NewsModule,
    QuotesModule,
    TasksModule
  }
})
