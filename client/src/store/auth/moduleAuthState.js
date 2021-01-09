export default {
  isAuthenticated: () => {
    return (
      window.localStorage.getItem("accessToKen") && window.localStorage.getItem("userInfo")
    );
  }
};
