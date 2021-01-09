export default {
  isAuthenticated: () => {
    return (
      localStorage.getItem("accessToKen") &&
      localStorage.getItem("userInfo")
    );
  }
};
