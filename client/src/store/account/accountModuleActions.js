import axios from "@/http/axios";

export default {
  getUserInformation({ commit }) {
    return new Promise((resolve, reject) => {
      axios
        .get("/users/information")
        .then(res => {
          commit("SET_USER", res.data.objResult);
          resolve(res);
        })
        .catch(err => {
          reject(err);
        });
    });
  },
  patchUser({ commit }, payload) {
    return new Promise((resolve, reject) => {
      payload.gender = payload.userGender;
      axios
        .patch(`/users/${payload.id}`, payload)
        .then(res => {
          commit("SET_USER", res.data.objResult);
          resolve(res);
        })
        .catch(err => {
          reject(err);
        });
    });
  }
};
