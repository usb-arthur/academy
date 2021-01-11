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
  getAllCourses: ({ commit }) => {
    return new Promise((resolve, reject) => {
      axios
        .get("/courses/all")
        .then(res => {
          commit("SET_COURSES", res.data.objResult);
          resolve(resolve);
        })
        .catch(err => {
          reject(err);
        });
    });
  },
  DeleteCourse: ({ commit }, lid) => {
    commit("DONOTHING");
    console.log(lid);
    return new Promise((resolve, reject) => {
      axios
        .delete("/courses/" + lid.id)
        .then(() => {
          resolve(resolve);
        })
        .catch(err => {
          reject(err);
        });
    });
  },
  GetStaticsCourse: ({ commit }, lid) => {
    return new Promise((resolve, reject) => {
      axios
        .get("/statistic", {
          params: {
            Payload: lid.Payload,
            Criteria: lid.Criteria
          }
        })
        .then(res => {
          commit("SET_COURSES", res.data.objResult);
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
  SET_COURSES: (state, payload) => {
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
