import constant from "@/constants";

export default {
  has: role => {
    var roles = localStorage.getItem(constant.ROLES);
    if (!roles) return false;
    return roles.toLocaleLowerCase().includes(role);
  },
  isAuthenticated: () => localStorage.getItem(constant.USER_INFOR) != null,

  userInfo: () => localStorage.getItem(constant.USER_INFOR)
};
