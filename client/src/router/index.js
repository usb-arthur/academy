//import { createRouter, createWebHistory } from "vue-router";

//import Home from "../views/Home.vue";
import HomePageLayout from "../views/Page/HomePage/HomePageLayout.vue";
//import AdminLayout from "../views/Page/Admin/Layout/AdminLayout.vue";
import TestAdminLayout from "../views/Page/Admin/Layout/TestAdminLayout.vue";
import VueRouter from "vue-router";

const routes = [
  {
    path: "/",
    name: "Home",
    component: HomePageLayout
  },
  {
    path: "",
    name: "FullPageLayout",
    component: () =>
      import(
        /* webpackChunkName: "FullPageLayout" */ "../views/Page/Layout/FullPage"
      ),
    children: [
      {
        path: "/dang-nhap",
        name: "Login",
        component: () =>
          import(/* webpackChunkName: "Login" */ "../views/Page/Auth/vLogin")
      },
      {
        path: "/dang-ky",
        name: "Register",
        component: () =>
          import(
            /* webpackChunkName: "Register" */ "../views/Page/Auth/vRegister"
          )
      }
    ]
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
    component: TestAdminLayout,
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
  },
  {
    path: "/test",
    name: "Test",
    component: () =>
      import(
        /* webpackChunkName: "demo" */ "../views/Page/Admin/Layout/TestAdminLayout.vue"
      ),
    redirect: { name: "LinhVuct" },
    children: [
      {
        path: "linhvuc",
        name: "LinhVuct",
        component: () =>
          import(
            /* webpackChunkName: "demo" */ "../views/Page/Admin/QuanliLinhVuc.vue"
          )
      },
      {
        path: "khoahoc",
        name: "KhoaHoct",
        component: () =>
          import(
            /* webpackChunkName: "demo" */ "../views/Page/Admin/QuanliKhoaHoc.vue"
          )
      },
      {
        path: "user",
        name: "usert",
        component: () =>
          import(
            /* webpackChunkName: "demo" */ "../views/Page/Admin/QuanliDanhSachHocVien.vue"
          )
      }
    ]
  }
];

const linkActiveClass = "my-link-active-class";

const router = new VueRouter({
  mode: "history",
  routes,
  linkActiveClass
});

export default router;
