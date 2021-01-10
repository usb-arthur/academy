import constant from "@/constants";

export default {
  has: role => {
    var roles = localStorage.getItem(constant.ROLES);
    return roles.toLocaleLowerCase().includes(role);
  }
};
