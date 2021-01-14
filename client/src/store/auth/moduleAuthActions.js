import axios from "@/http/axios";
import router from "@/router";
import constant from "@/constants";

export default {
  loginJWT({ commit }, payload) {
    return new Promise((resolve, reject) => {
      axios
        .post("/auth/sign-in", {
          email: payload.email,
          password: payload.password,
          rememberMe: payload.rememberMe,
        })
        .then((res) => {
          if (res.status === 200) {
            router.push(router.currentRoute.query.to || "/");
            localStorage.setItem(
              constant.ACCESS_TOKEN,
              res.data.objResult.accessToken
            );
            localStorage.setItem(constant.ROLES, res.data.objResult.roles);
            localStorage.setItem(constant.USER_INFOR, res.data.objResult.name);
            localStorage.setItem(
              constant.USER,
              JSON.stringify(res.data.objResult)
            );
            commit("SET_BEARER", res.data.objResult.accessToken);
            resolve(res);
          }
        })
        .catch((err) => {
          reject(err);
        });
    });
  },
  changePassword(_, payload) {
    return axios.post("/auth/change-password", payload);
  },
  registerUser(_, payload) {
    return axios.post("/auth/register", payload);
  },
  logout({ commit }) {
    localStorage.removeItem(constant.ACCESS_TOKEN);
    localStorage.removeItem(constant.ROLES);
    localStorage.removeItem(constant.USER_INFOR);
    localStorage.removeItem(constant.USER);
    commit("SET_IS_AUTHENTICATED", false);
  },
  verifyEmail(_, payload) {
    return axios.post("/auth/verify-email", payload);
  },
};
