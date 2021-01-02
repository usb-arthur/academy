import Vue from "vue";
import Vuex from "vuex";
import linhvuc from "./linhvuc/linhvuc.js";
import khoahoc from "./modules/khoahoc.js";
import user from "./modules/user.js";

Vue.use(Vuex);

export default new Vuex.Store({
  modules: {
    linhvuc,
    khoahoc,
    user
  }
});
