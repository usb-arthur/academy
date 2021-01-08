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
  getCourseById: ({ commit }, payload) => {
    return new Promise((resolve, reject) => {
      axios
        .get(`/courses/${payload}`)
        .then(res => {
          commit("SET_COURSE", res.data.objResult);
          resolve(res);
        })
        .catch(err => {
          reject(err);
        });
    });
  },
  updateCourseById: (_, { id, course }) => {
    return new Promise((resolve, reject) => {
      course.courseFee = +course.courseFee;
      axios
        .put(`/courses/${id}`, course)
        .then(res => {
          resolve(res);
        })
        .catch(err => {
          reject(err);
        });
    });
  },
  deleteCourse: ({ dispatch }, payload) => {
    return new Promise((resolve, reject) => {
      axios
        .delete(`/courses/${payload}`)
        .then(res => {
          dispatch("getAllCourses");
          resolve(res);
        })
        .catch(err => {
          reject(err);
        });
    });
  },
  createNewCourse: (_, payload) => {
    return new Promise((resolve, reject) => {
      payload.courseFee = +payload.courseFee;
      axios
        .post("/courses", payload)
        .then(res => {
          resolve(res);
        })
        .catch(err => {
          reject(err);
        });
    });
  },
  getCourseDetailByCourseId({ commit }, payload) {
    return new Promise((resolve, reject) => {
      axios
        .get(`/course-details/courses/${payload}`)
        .then(res => {
          commit("SET_COURSE_DETAILS", res.data.objResult);
          resolve(res);
        })
        .catch(err => {
          reject(err);
        });
    });
  },
  createCourseDetail({ dispatch }, { id, courseDetail }) {
    return new Promise((resolve, reject) => {
      axios
        .post("/course-details", {
          courseId: +id,
          content: courseDetail.content,
          isReview: courseDetail.isReview
        })
        .then(res => {
          dispatch("getCourseDetailByCourseId", id);
          resolve(res);
        })
        .catch(err => {
          reject(err);
        });
    });
  },
  deleteCourseDetail: ({ dispatch }, payload) => {
    return new Promise((resolve, reject) => {
      axios
        .delete(`/course-details/${payload.courseDetailId}`)
        .then(res => {
          dispatch("getCourseDetailByCourseId", payload.courseId);
          resolve(res);
        })
        .catch(err => {
          reject(err);
        });
    });
  }
};
