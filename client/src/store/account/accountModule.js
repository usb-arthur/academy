import state from "./accountModuleState";
import mutations from "./accountModuleMutations";
import actions from "./accountModuleActions";
import getters from "./accountModuleGetters";

export default {
  namespaced: true,
  state: state,
  mutations: mutations,
  actions: actions,
  getters: getters
};
