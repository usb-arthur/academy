import Vue from "vue";
import Vuex from "vuex";
import linhvuc from "./modules/linhvuc.js";
import khoahoc from "./modules/khoahoc.js";
import user from "./modules/user.js";
import paths from "./modules/path.js";
import auth from "./auth/moduleAuth";
import course from "./course/moduleCourse";
import categories from "./categories/moduleCategory";
import account from "./account/accountModule";
import feedback from "./feedback/moduleFeedback";

Vue.use(Vuex);

export default new Vuex.Store({
  modules: {
    linhvuc,
    khoahoc,
    user,
    paths,
    auth,
    course,
    categories,
    account,
    feedback
  }
});
