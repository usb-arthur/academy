export default {
  SET_COURSES: (state, payload) => {
    state.courses = payload;
  },
  ADD_COURSE: (state, course) => {
    course.courseFee = +course.courseFee;
    state.courses = [...state.courses, course];
  }
};
