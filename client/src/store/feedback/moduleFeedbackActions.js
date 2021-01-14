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
  },
  createFeedback: ({ dispatch }, payload) => {
    return new Promise((resolve, reject) => {
      payload.courseId = +payload.courseId;
      axios
        .post(`/feedbacks`, payload)
        .then(res => {
          dispatch("getFeedbacksByCourseId", payload.courseId);
          resolve(res);
        })
        .catch(err => reject(err));
    });
  }
};
