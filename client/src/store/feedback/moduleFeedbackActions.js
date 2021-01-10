import axios from "@/http/axios";

export default {
  getFeedbacksByCourseId({ commit }, payload) {
    return new Promise((resolve, reject) => {
      axios
        .get(`/feedbacks/courses/${payload}`)
        .then(res => {
          commit("SET_FEEDBACKS", res.data.objResult);
          resolve(res);
        })
        .catch(err => reject(err));
    });
  }
};
