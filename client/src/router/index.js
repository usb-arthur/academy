import HomePageLayout from "../views/Page/HomePage/HomePageLayout.vue";
import TestAdminLayout from "../views/Page/Admin/Layout/TestAdminLayout.vue";
import VueRouter from "vue-router";
import Layout from "@/views/Page/Layout/Layout";
import Course from "@/views/Page/Teacher/CourseList";
import TeacherLayout from "@/views/Page/Teacher/Layout/Layout";

const routes = [
  {
    path: "/",
    name: "Home",
    component: HomePageLayout
  },
  {
    path: "",
    component: Layout,
    children: [
      {
        path: "/chi-tiet-khoa-hoc/:id",
        component: () => import("@/views/Page/Shared/CourseDetailShared")
      },
      {
        path: "/danh-sach-khoa-hoc/:id",
        component: () => import("@/views/Page/Shared/ListCouser")
      },
      {
        path: "/giang-vien",
        redirect: { name: "Course" },
        component: TeacherLayout,
        children: [
          {
            name: "Course",
            path: "khoa-hoc",
            component: Course
          },
          {
            name: "CreateCourse",
            path: "tao-khoa-hoc",
            component: () =>
              import(
                /* webpackChunkName: "CreateCourse" */ "../views/Page/Teacher/CreateCourse"
              )
          },
          {
            name: "UpdateCourse",
            path: "cap-nhat-khoa-hoc/:id",
            component: () =>
              import(
                /* webpackChunkName: "UpdateCourse" */ "../views/Page/Teacher/UpdateCourse"
              )
          },
          {
            name: "CourseDetail",
            path: "chi-tiet-khoa-hoc/:id",
            component: () =>
              import(
                /* webpackChunkName: "UpdateCourse" */ "../views/Page/Teacher/CourseDetail"
              )
          }
        ]
      },
      {
        path: "/thong-tin-ca-nhan",
        name: "PersonalAccount",
        component: () =>
          import(
            /* webpackChunkName: "FullPageLayout" */ "../views/Page/Account/Account"
          ),
        children: [
          {
            path: "",
            name: "DetailAccount",
            component: () => import("../views/Page/Account/DetailAccount")
          },
          {
            path: "doi-mat-khau",
            name: "ChangePassword",
            component: () => import("../views/Page/Account/ChangePassword")
          },
          {
            path: "khoa-hoc-cua-toi",
            name: "MyCourseList",
            component: () => import("../views/Page/Teacher/MyCourseList")
          }
        ]
      }
    ]
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
