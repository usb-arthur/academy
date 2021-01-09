import axios from "@/axios";
import router from "@/router";

axios.interceptors.request.use(
  config => {
    const token = localStorage.getItem("accessToKen");
    if (token) {
      config.headers["Authorization"] = `Bearer ${token}`;
    }
    return config;
  },
  error => {
    Promise.reject(error);
  }
);

axios.interceptors.response.use(
  response => response,
  error => {
    const originalRequest = error.config;

    if (error.response.status === 403) {
      router.push("/forbidden");
    } else if (error.response.status === 401 && !originalRequest._retry) {
      originalRequest._retry = true;
      return axios
        .post("auth/refresh-token", {
          accessToken: localStorage.getItem("accessToken")
        })
        .then(res => {
          if (res.status === 200) {
            localStorage.setItem(
              "accessToken",
              res.data.objResult.accessToken
            );
            axios.defaults.headers.common["Authorization"] =
              res.data.objResult.accessToken;
            return axios(originalRequest);
          }
        })
        .catch(() => {
          return axios(originalRequest);
        });
    } else if (error.response.status === 401 && originalRequest._retry) {
      router.push("/dang-nhap");
    }
    return Promise.reject(error);
  }
);

export default axios;
