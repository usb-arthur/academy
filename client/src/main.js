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
import VueCurrencyFilter from "vue-currency-filter";

const linkActiveClass = "my-link-active-class";
import VueCoreVideoPlayer from 'vue-core-video-player'

Vue.use(VueCoreVideoPlayer)
// pass custom class to Vue Material
Vue.material.router.linkActiveClass = linkActiveClass;
Vue.use(VueCurrencyFilter, {
  symbol: "đ",
  thousandsSeparator: ",",
  fractionCount: 0,
  fractionSeparator: ",",
  symbolPosition: "end",
  symbolSpacing: false,
  avoidEmptyDecimals: undefined
});
new Vue({
  el: "#app",
  render: h => h(App),
  vuetify,
  router,
  store: store
});
