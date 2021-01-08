//import shop from '../../api/shop'
import axios from "@/http/axios";
// initial state
// shape: [{ id, quantity }]
const state = () => ({
  items: []
});

// getters
const getters = {
  ACatalog: () => {
    return state.items;
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
  },
  UploadCategory: ({ commit }, payload) => {
    commit("DONOTHING");
    console.log(payload);
    return new Promise((resolve, reject) => {
      axios
        .post("/categories", {
          categoryName: payload.categoryName,
          categoryId: payload.categoryId
        })
        .then(() => {
          resolve(resolve);
        })
        .catch(err => {
          reject(err);
        });
    });
  },
  DeleteCategory: ({ commit }, lid) => {
    commit("DONOTHING");
    console.log(lid);
    return new Promise((resolve, reject) => {
      axios
        .delete("/categories/" + lid.id)
        .then(() => {
          resolve(resolve);
        })
        .catch(err => {
          reject(err);
        });
    });
  },
  UpdateNameCategory: ({ commit }, lid) => {
    commit("DONOTHING");
    console.log(lid);
    return new Promise((resolve, reject) => {
      axios
        .put("/categories/" + lid.id, {
          categoryName: lid.categoryName
        })
        .then(() => {
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
  },
  ADD_CATEGORIES: (state, payload) => {
    state.items.push(payload);
  },
  DONOTHING: () => {}
};

export default {
  namespaced: true,
  state,
  getters,
  actions,
  mutations
};
