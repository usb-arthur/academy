import axios from "@/http/axios";
import constant from "@/constants";

export default {
  getAllWishList: ({ commit }, payload) => {
    return new Promise((resolve, reject) => {
      let url = "/watch-lists";
      if (payload.page) {
        url = url + "?page=" + payload.page;
      }
      if (payload.limit) {
        url = url + "&limit=" + payload.limit;
      }
      axios
        .get(url)
        .then(res => {
          commit("SET_WISH_LIST", res.data.objResult);
          resolve(res);
        })
        .catch(err => {
          reject(err);
        });
    });
  },
  getSubscribeCourse({ commit }, payload) {
    return new Promise((resolve, reject) => {
      let url = "/students/courses";
      if (payload.page) {
        url = url + "?page=" + payload.page;
      } else {
        url = `${url}?page=1`;
      }
      if (payload.limit) {
        url = url + "&limit=" + payload.limit;
      }
      console.log(url, payload);
      axios
        .get(url)
        .then(res => {
          commit("SET_SUBSCRIBE_COURSES", res.data.objResult);
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
  getCoursesPaging: ({ commit }, payload) => {
    return new Promise((resolve, reject) => {
      let url = "/courses/paging/teachers";
      if (payload.page) {
        url = `${url}?page=${payload.page}`;
      }
      if (payload.limit) {
        url = `${url}&limit=${payload.limit}`;
      }
      axios
        .get(url)
        .then(res => {
          commit("SET_COURSES_PAGING", res.data.objResult);
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
  },
  getCoursesByCategory: ({ commit }, payload) => {
    return new Promise((resolve, reject) => {
      let url = `/courses/paging/categories/${payload.id}`;
      let uri = new URL(url, axios.defaults.baseURL);

      if (payload.search) uri.searchParams.append("search", payload.search);

      if (payload.page) uri.searchParams.append("page", payload.page);

      if (payload.limit) uri.searchParams.append("limit", payload.limit);

      if (payload.order) uri.searchParams.append("order", payload.order);

      if (payload.sort) uri.searchParams.append("sortBy", payload.sort);

      axios
        .get(uri)
        .then(res => {
          commit("SET_COURSES_BY_CATEGORY", res.data.objResult);
          resolve(res);
        })
        .catch(err => {
          reject(err);
        });
    });
  },
  addToWishList: ({ dispatch }, payload) => {
    return new Promise((resolve, reject) => {
      axios
        .post("/watch-lists", { courseId: payload })
        .then(res => {
          dispatch("getAllWishList");
          resolve(res);
        })
        .catch(err => reject(err));
    });
  },
  patchCourseStatus: ({ commit }, payload) => {
    return new Promise((resolve, reject) => {
      axios
        .patch(`/courses/${payload.id}/status`, { status: payload.status })
        .then(res => {
          commit("SET_COURSE", res.data.objResult);
          resolve(res);
        })
        .catch(err => reject(err));
    });
  },
  getIsInCourse({ commit }, payload) {
    const user = JSON.parse(localStorage.getItem(constant.USER));
    if (!user) {
      commit("SET_IS_IN_COURSE", false);
      return new Promise(resolve => resolve(false));
    }
    return new Promise((resolve, reject) => {
      axios
        .post(`/students/courses/${payload}/is-in-course`, { userId: user.id })
        .then(res => {
          commit("SET_IS_IN_COURSE", res.data);
          resolve(res);
        })
        .catch(err => reject(err));
    });
  },
  getRelativeCourse({ commit }, payload) {
    return new Promise((resolve, reject) => {
      axios
        .get(
          `/courses/${payload.courseId}/statistic/categories/${payload.categoryId}?payload=5`
        )
        .then(res => {
          commit("SET_RELATIVE_COURSE", res.data.objResult);
          resolve(res);
        })
        .catch(err => reject(err));
    });
  },
  registerCourse({ commit }, payload) {
    return new Promise((resolve, reject) => {
      axios
        .post(`/students/courses/${payload}`)
        .then(res => {
          commit("SET_IS_IN_COURSE", true);
          resolve(res);
        })
        .catch(err => reject(err));
    });
  },

  getCoursesBySearch: ({ commit }, payload) => {
    return new Promise((resolve, reject) => {
      let url = `/courses/paging`;
      let uri = new URL(url, axios.defaults.baseURL);

      if (payload.search) uri.searchParams.append("search", payload.search);

      if (payload.page) uri.searchParams.append("page", payload.page);

      if (payload.limit) uri.searchParams.append("limit", payload.limit);

      if (payload.order) uri.searchParams.append("order", payload.order);

      if (payload.sort) uri.searchParams.append("sortBy", payload.sort);

      axios
        .get(uri)
        .then(res => {
          commit("SET_COURSE_BY_SEARCH", res.data.objResult);
          resolve(res);
        })
        .catch(err => {
          reject(err);
        });
    });
  },
  removeWishList: ({ dispatch }, payload) => {
    return new Promise((resolve, reject) => {
      axios
        .delete(`/watch-lists/${payload.id}`)
        .then(res => {
          dispatch("getAllWishList", { page: payload.page });
          resolve(res);
        })
        .catch(err => reject(err));
    });
  }
};
