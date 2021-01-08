import axios from "axios";

const baseURL = "https://localhost:5001";

export default axios.create({
  baseURL,
  withCredentials: true,
  xsrfCookieName: "refreshToken"
});
