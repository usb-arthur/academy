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
          rememberMe: payload.rememberMe
        })
        .then(res => {
          if (res.status === 200) {
            router.push(router.currentRoute.query.to || "/");
            localStorage.setItem(
              constant.ACCESS_TOKEN,
              res.data.objResult.accessToken
            );
            localStorage.setItem(constant.ROLES, res.data.objResult.roles);
            commit("SET_BEARER", res.data.objResult.accessToken);
            resolve(res);
          }
        })
        .catch(err => {
          reject(err);
        });
    });
  },
  changePassword(_, payload) {
    return axios.post("/auth/change-password", payload);
  },
  registerUser(_, payload) {
    return axios.post("/auth/register", payload);
  }
};
