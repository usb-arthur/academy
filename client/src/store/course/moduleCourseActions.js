import axios from "@/http/axios";

export default {
  getAllWishList: ({ commit }) => {
    return new Promise((resolve, reject) => {
      axios
        .get("/watch-list")
        .then(res => {
          commit("SET_WISH_LIST", res.data.objResult);
          resolve(res);
        })
        .catch(err => {
          reject(err);
        });
    });
  },
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
      const formData = new FormData();
      if (course.image) {
        formData.append("Image", course.image);
      }
      formData.append("CourseName", course.courseName);
      formData.append("CourseFee", course.courseFee);
      formData.append("BriefDescription", course.briefDescription);
      // if (payload.sale) {
      //   formData.append("Sale", payload.sale);
      // }
      // if (payload.saleDate) {
      //   formData.append("SaleDate", payload.saleDate);
      // }
      if (course.detailDescription) {
        formData.append("DetailDescription", course.detailDescription);
      }
      // course.courseFee = +course.courseFee;
      axios
        .put(`/courses/${id}`, formData, {
          headers: {
            "Content-Type": "multipart/form-data"
          }
        })
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
      const formData = new FormData();
      formData.append("Image", payload.image);
      formData.append("CourseName", payload.courseName);
      formData.append("CourseFee", payload.courseFee);
      formData.append("BriefDescription", payload.briefDescription);
      if (payload.sale) {
        formData.append("Sale", payload.sale);
      }
      if (payload.saleDate) {
        formData.append("SaleDate", payload.saleDate);
      }
      if (payload.detailDescription) {
        formData.append("DetailDescription", payload.detailDescription);
      }
      formData.append("CategoryId", payload.categoryId);

      axios
        .post("/courses", formData, {
          headers: {
            "Content-Type": "multipart/form-data"
          }
        })
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
      const formData = new FormData();
      formData.append("CourseId", id);
      formData.append("Content", courseDetail.content);
      if (courseDetail.isReview) {
        formData.append("IsReview", courseDetail.isReview);
      }
      formData.append("Video", courseDetail.video);
      axios
        .post("/course-details", formData, {
          headers: {
            "Content-Type": "multipart/form-data"
          }
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
