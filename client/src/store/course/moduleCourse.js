import state from "./moduleCourseState";
import mutations from "./moduleCourseMutations";
import actions from "./moduleCourseActions";
import getters from "./moduleCourseGetters";

export default {
  namespaced: true,
  state: state,
  mutations: mutations,
  actions: actions,
  getters: getters
};
