export default {
  SET_COURSES: (state, payload) => {
    state.courses = payload;
  },
  SET_COURSE: (state, payload) => {
    state.course = payload;
  },
  SET_COURSE_DETAILS: (state, payload) => {
    state.courseDetails = payload;
  }
};
