export default {
  SET_COURSES: (state, payload) => {
    state.courses = payload;
  },
  SET_COURSE: (state, payload) => {
    state.course = payload;
  },
  SET_COURSE_DETAILS: (state, payload) => {
    state.courseDetails = payload;
  },
  SET_WISH_LIST: (state, payload) => {
    state.wishList = payload;
  },
  SET_COURSES_PAGING: (state, payload) => {
    console.log(payload);
    state.coursesPaging = payload;
  },
  SET_COURSES_BY_CATEGORY: (state, payload) => {
    state.coursesByCategory = payload;
  },
  SET_SUBSCRIBE_COURSES: (state, payload) => {
    state.subscribeCourses = payload;
  },
  SET_IS_IN_COURSE: (state, payload) => {
    state.isInCourse = payload;
  },
  SET_RELATIVE_COURSE: (state, payload) => {
    state.relativeCourse = payload;
  }
};
