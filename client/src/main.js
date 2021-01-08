import Vue from "vue";
import App from "./App.vue";
import VueRouter from "vue-router";
import router from "./router";
import store from "./store/index.js";
import VueMaterial from "vue-material";
import MaterialDesignIcon from "material-design-icons";
import "vue-material/dist/vue-material.min.css";
import "vue-material/dist/theme/default.css";

import "bootstrap/dist/css/bootstrap.css";
import "bootstrap-vue/dist/bootstrap-vue.css";
import BootstrapVue from "bootstrap-vue/dist/bootstrap-vue.esm";
import vuetify from "./plugins/vuetify.js";

Vue.use(MaterialDesignIcon);
Vue.use(VueMaterial);
Vue.use(VueRouter);
Vue.use(BootstrapVue);

const linkActiveClass = "my-link-active-class";

// pass custom class to Vue Material
Vue.material.router.linkActiveClass = linkActiveClass;

new Vue({
  el: "#app",
  render: h => h(App),
  vuetify,
  router,
  store: store
});
