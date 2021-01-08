import axios from "@/http/axios";

export default {
  getAllCategories: ({ commit }) => {
    return new Promise((resolve, reject) => {
      axios
        .get("/categories")
        .then(res => {
          commit("SET_CATEGORIES", res.data.objResult);
          resolve(res);
        })
        .catch(err => {
          reject(err);
        });
    });
  }
};
