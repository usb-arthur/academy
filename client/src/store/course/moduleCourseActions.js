import axios from "@/http/axios";

export default {
  getAllCourses: ({ commit }) => {
    return new Promise((resolve, reject) => {
      axios
        .get("/courses")
        .then(res => {
          commit("SET_COURSES", res.data.objResult);
          resolve(res);
        })
        .catch(err => {
          reject(err);
        });
    });
  },
  deleteCourse: ({ commit }, payload) => {
    console.log(payload, commit);
  },
  createNewCourse: ({ commit }, payload) => {
    return new Promise((resolve, reject) => {
      payload.courseFee = +payload.courseFee;
      axios
        .post("/courses", payload)
        .then(res => {
          const {
            id,
            courseName,
            courseFee,
            createdDate,
            updatedDate
          } = res.data.objResult;
          commit("ADD_COURSE", {
            id,
            courseName,
            courseFee,
            createdDate,
            updatedDate
          });
          resolve(res);
        })
        .catch(err => {
          reject(err);
        });
    });
  }
};
