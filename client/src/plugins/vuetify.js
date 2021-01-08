import Vue from "vue";
import Vuetify from "vuetify";
import { TiptapVuetifyPlugin } from "tiptap-vuetify";

// don't forget to import CSS styles
import "tiptap-vuetify/dist/main.css";
import "vuetify/dist/vuetify.min.css"; // Add this line
const vuetify = new Vuetify();

Vue.use(Vuetify);

Vue.use(TiptapVuetifyPlugin, {
  // the next line is important! You need to provide the Vuetify Object to this place.
  vuetify, // same as "vuetify: vuetify"
  // optional, default to 'md' (default vuetify icons before v2.0.0)
  iconsGroup: "md"
});
const opts = {
  theme: {
    dark: false
  },
  options: {
    customProperties: true
  },
  icons: {
    iconfont: "mdi"
  }
};

export default new Vuetify(opts);
