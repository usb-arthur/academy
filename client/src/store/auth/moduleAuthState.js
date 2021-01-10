import constant from "@/constants";

export default {
  isHas: role => {
    var roles = localStorage.getItem(constant.ROLES);
    return roles.toLocaleLowerCase().includes(role);
  }
};
