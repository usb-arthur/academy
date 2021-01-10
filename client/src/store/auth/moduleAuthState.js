import constant from "@/constants/token";

export default {
  isAuthenticated: () => {
    return (
      localStorage.getItem(constant.ACCESS_TOKEN) &&
      localStorage.getItem("userInfo")
    );
  }
};
