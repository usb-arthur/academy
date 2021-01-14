import axios from "@/http/axios";
import constant from "@/constants";
export default {
  SET_BEARER(state, accessToken) {
    axios.defaults.headers.common["Authorization"] = "Bearer" + accessToken;
  },
  SET_IS_AUTHENTICATED(state) {
    state.isAuthenticated = () =>
      localStorage.getItem(constant.USER_INFOR) != null;
  },
};
