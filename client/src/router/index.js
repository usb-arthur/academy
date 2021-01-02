//import { createRouter, createWebHistory } from "vue-router";

import Home from "../views/Home.vue";
import AdminLayout from "../views/Page/Admin/Layout/AdminLayout.vue";

const routes = [
  {
    path: "/",
    name: "Home",
    component: Home
  },
  {
    path: "/about",
    name: "About",
    // route level code-splitting
    // this generates a separate chunk (about.[hash].js) for this route
    // which is lazy-loaded when the route is visited.
    component: () =>
      import(/* webpackChunkName: "about" */ "../views/About.vue")
  },
  {
    path: "/admin",
    component: AdminLayout,
    redirect: { name: "LinhVuc" },
    children: [
      {
        path: "linhvuc",
        name: "LinhVuc",
        component: () =>
          import(
            /* webpackChunkName: "demo" */ "../views/Page/Admin/QuanliLinhVuc.vue"
          )
      },
      {
        path: "khoahoc",
        name: "KhoaHoc",
        component: () =>
          import(
            /* webpackChunkName: "demo" */ "../views/Page/Admin/QuanliKhoaHoc.vue"
          )
      },
      {
        path: "user",
        name: "user",
        component: () =>
          import(
            /* webpackChunkName: "demo" */ "../views/Page/Admin/QuanliDanhSachHocVien.vue"
          )
      }
    ]
  }
];

export default routes;
