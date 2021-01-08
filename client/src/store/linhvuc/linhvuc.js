//import shop from '../../api/shop'
import axios from "@/http/axios";
// initial state
// shape: [{ id, quantity }]
const state = () => ({
  items: []
});

// getters
const getters = {
  ACatalog: state => {
    return state.items.filter(catalog => catalog.active);
  }
};

// actions
const actions = {
  getAllCategories: ({ commit }) => {
    return new Promise((resolve, reject) => {
      axios
        .get("/categories")
        .then(res => {
          commit("SET_CATEGORIES", res.data.objResult);
          resolve(resolve);
        })
        .catch(err => {
          reject(err);
        });
    });
  }
};

// mutations
const mutations = {
  SET_CATEGORIES: (state, payload) => {
    state.items = payload;
  }
};

export default {
  namespaced: true,
  state,
  getters,
  actions,
  mutations
};
