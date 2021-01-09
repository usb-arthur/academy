export default {
  isAuthenticated: () => {
    return (
      localStorage.getItem("accessToken") && localStorage.getItem("userInfo")
    );
  }
};
