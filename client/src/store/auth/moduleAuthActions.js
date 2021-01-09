import axios from "@/http/axios";
import router from "@/router";

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
              "accessToKen",
              res.data.objResult.accessToken
            );
            commit("SET_BEARER", res.data.objResult.accessToken);
            resolve(res);
          }
        })
        .catch(err => {
          reject(err);
        });
    });
  }
};
