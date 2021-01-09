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
    return state.items;
  }
};

// actions
const actions = {
  getAllUser: ({ commit }) => {
    return new Promise((resolve, reject) => {
      axios
        .get("/Users")
        .then(res => {
          commit("SET_USERS", res.data.objResult);
          resolve(resolve);
        })
        .catch(err => {
          reject(err);
        });
    });
  },
  UploadUser: ({ commit }, payload) => {
    commit("DONOTHING");
    return new Promise((resolve, reject) => {
      axios
        .post("/Users", {
          name: payload.name,
          gender: parseInt(payload.gender),
          email: payload.email,
          contact: payload.contact,
          dateOfBirth: payload.dateOfBirth,
          phoneNumber: payload.phoneNumber
        })
        .then(() => {
          resolve(resolve);
        })
        .catch(err => {
          reject(err);
        });
    });
  },
  DeleteUser: ({ commit }, lid) => {
    commit("DONOTHING");
    console.log(lid);
    return new Promise((resolve, reject) => {
      axios
        .delete("/Users/" + lid.id)
        .then(() => {
          resolve(resolve);
        })
        .catch(err => {
          reject(err);
        });
    });
  },
  UpdateUser: ({ commit }, lid) => {
    commit("DONOTHING");
    console.log(lid);
    return new Promise((resolve, reject) => {
      axios
        .patch("/Users/" + lid.id, {
          name: lid.name,
          gender: parseInt(lid.gender),
          contact: lid.contact,
          dateOfBirth: lid.dateOfBirth
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
  SET_USERS: (state, payload) => {
    state.items = payload;
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
